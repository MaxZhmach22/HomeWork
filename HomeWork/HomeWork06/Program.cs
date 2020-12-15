using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork06
{
    public delegate double Fun(double a, double x);

    public delegate double F(double x);


    class Program
    {
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double Sin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        /// <summary>Квадрат Х</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double SecDeg(double x)
        {
            return x * x;
        }

        /// <summary>Третья степень Х</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double ThDeg(double x)
        {
            return x * x * x;
        }

        /// <summary>СИНУС Х</summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double SinF(double x)
        {
            return Math.Sin(x);
        }

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, F f)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h; // x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] ar = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                ar[i] = d;
                if (d < min) min = d;
                
            }
            bw.Close();
            fs.Close();
            return ar;
        }

        static void MyTable2(double a, double b, double step, double[] min)
        {
            Console.WriteLine("------- X ------- Y -----");
            int i = 0;
            while (a <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", a, min[i]);
                a += step;
                i++;
            }
            Console.WriteLine("--------------------------");
        }

        /// <summary>
        /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static int[] AnalyzArray(List<Student> list)
        {
            int[] studentsCount = new int[6];
            
            {
                for (int i = 0, j = 0; i < studentsCount.Length; i++, j=0)
                {
                    foreach (var s in list)
                    {
                        if (s.age >= 18 && s.age <= 20)
                        {
                            if (s.course == i+1)
                            {
                                j += 1;
                                studentsCount[i] = j;
                            }
                            else
                            {
                                studentsCount[i] = j;
                            }
                        }
                        studentsCount[i] = j;
                    }
                
                    

                }

            }
            
            //for (int i = 0, j = 0; i < studentsCount.Length; i++)
            //{
            //    foreach (var s in list)
            //    {
            //        if (s.age >= 18 && s.age <= 20)
            //        {
            //            studentsCount[i] = j+1;
            //        }
            //        else
            //        {
            //            studentsCount[i] = 0;
            //        }
            //    }
            //    j = 0;
            //}
            return studentsCount;
        }

        /// <summary>
        /// в) отсортировать список по возрасту студента;
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int AnalyzAge(Student st1, Student st2)
        {
            int i;
            if (st1.age > st2.age) i = 1;
            else if (st1.age >= st2.age) i = 0;
            else i = -1;
            return i;
        }

        /// <summary>
        /// г) *отсортировать список по курсу и возрасту студента;
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int AnalyzCourse(Student st1, Student st2)
        {
            int i;
            if (st1.course > st2.course) i = 1;
            else if (st1.course >= st2.course) i = 0;
            else i = -1;
            return i;
        }

        static int MyDelegat(Student st1, Student st2) // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.firstName, st2.firstName); // Сравниваем две строки
        }

        /// <summary>
        /// Для разделения задач в консоли
        /// </summary>
        /// <param name="s"></param>
        static void Tabulation(string s)
        {
            Console.WriteLine("\n Для продолжения нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("_____________________________________________________________\n"+s+"\n");
        }
    

        static void Main()
        {
            //1.Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
            //типа double(double, double).Продемонстрировать работу на функции с функцией a*x ^ 2 и
            //функцией a* sin(x). Жмачинский Максим
            Console.WriteLine("Задание 1\n");
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), 3, -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.
            Table(MyFunc, 3, -2, 2);
            Console.WriteLine("Таблица функции а * Sin:");
            Table(Sin, 3, -2, 2); // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции a * x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double u, double x) { return u * x * x; }, 3, -2, 2);
            


            //2.Модифицировать программу нахождения минимума функции так, чтобы можно было
            //передавать функцию в виде делегата.
            //а) Сделать меню с различными функциями и представить пользователю выбор, для какой
            //функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов,
            //в котором хранятся различные функции.
            //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она
            //возвращает минимум через параметр(с использованием модификатора out). Жмачинский Максим
            Tabulation("2.Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.");

            List< F> delF = new List<F>
            {
                SecDeg,
                ThDeg,
                SinF
            };
            double min = double.MaxValue;
            Console.WriteLine("Выберите вариант функции 1) x^2; 2) x^3; 3) Sin(x)");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите на каком отрезке от a до b\na = " );
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nb = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг итерации: ");
            double step = double.Parse(Console.ReadLine());
            SaveFunc("data.bin", a, b, step, delF[i - 1]);
            MyTable2(a, b, step, Load("data.bin", out min));


            //3.Переделать программу Пример использования коллекций для решения следующих задач:
            //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный
            //массив);
            //в) отсортировать список по возрасту студента;
            //г) *отсортировать список по курсу и возрасту студента.
            // Жмачинский Максим
            Tabulation("3.Переделать программу Пример использования коллекций для решения следующих задач...");

            int course05 = 0;
            int course06 = 0;
            List<Student> list = new List<Student>();
            // Создаем список студентов
            StreamReader sr = new StreamReader(@"C:\Users\Max\Desktop\GeekBrains\C#\HWRepo\HomeWork\HomeWork06\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new
                    Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7])
                    , s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) == 5) course05++; else if (int.Parse(s[6]) == 6) course06++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine($"Колличество студентов на 5 курсе : {course05} \nКолличество студентов на 6 курсе : {course06}\n"); //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;

            int[] studentsCount = AnalyzArray(list); //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив)
            for (int z = 0; z < studentsCount.Length; z++) Console.WriteLine($"На {z + 1} курсе количество студентов от 18 до 20 лет: {studentsCount[z]}");

            list.Sort(new Comparison<Student>(AnalyzAge)); //в) отсортировать список по возрасту студента;
            Console.WriteLine("\nСписок студентов, отсортированных по возрасту:");
            foreach (var age in list) Console.WriteLine($"{age.firstName} {age.lastName} {age.age}");

            list.Sort(new Comparison<Student>(AnalyzCourse)); //г) *отсортировать список по курсу и возрасту студента;
            Console.WriteLine("\nСписок студентов, отсортированных по возрасту и курсу:");
            foreach (var ageCourse in list) Console.WriteLine($"{ageCourse.firstName} {ageCourse.lastName} возраст: {ageCourse.age} курс: {ageCourse.course}");

            Console.ReadKey();
        }
    }
}
