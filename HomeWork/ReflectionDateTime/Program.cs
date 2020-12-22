using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDateTime
{
    class Program
    {
        //1. С помощью рефлексии выведите все свойства структуры DateTime. Жмачинский

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            foreach (var e in dateTime.GetType().GetRuntimeProperties()) Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
