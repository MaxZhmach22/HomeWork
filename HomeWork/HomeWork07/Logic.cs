using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork07
{
    class Logic
    {
        
        public string text;

        public int userAnswer { get; set; }
        public int maxTryCount { get; set; }
        public int correctAnswer { get; set; }
        public int tryCount { get; set; }

        public Logic()
        {
            text = Rules();
        }

        public static string Rules()
        {
            using (StreamReader sr = new StreamReader("Rules.txt"))
            {
                string rules = sr.ReadToEnd();
                return rules;
            }

        }

        public bool Compare()
        {
            
            bool answer;
            
                if (userAnswer == correctAnswer)
                {
                    answer = true;
                    MessageBox.Show ($"Поздравляю вы угадали!", "Ура!");
                    return answer;
                }
                else if (userAnswer > correctAnswer)
                {
                    answer = false;
                    MessageBox.Show ($"Ваше число больше загаданного. Попробуйте еще раз.","Увы.");
                    tryCount++;
                }
                else
                {
                    answer = false;
                    MessageBox.Show ($"Ваше число меньше загаданного. Попробуйте еще раз.", "Увы.");
                    tryCount++;
                }


            return answer;
        }          

    }
}
