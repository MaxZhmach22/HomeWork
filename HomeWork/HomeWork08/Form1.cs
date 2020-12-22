using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HomeWork08
{
    public partial class Form1 : Form
    {
        int symbolCount;
        List<char> correctChars;
        string listpath;

        public Form1()
        {
            correctChars = new List<char>();
            InitializeComponent();
            string path = @"notes.txt";
            listpath = @"list.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                tbMain.Text = sr.ReadToEnd();
            }
            using(StreamReader sl = new StreamReader(listpath))
            {
                string listchar = sl.ReadToEnd();
                foreach (char item in listchar)
                {
                    correctChars.Add(item);
                }
            }
            if (!tbMain.Text.Equals(null)) btnUnGen.Visible = false;
        }

        private void programInfo_Click(object sender, EventArgs e)
        {
            string license = "";
            using (StreamReader sr = new StreamReader(@"TextFile1.txt"))
            {
                license = sr.ReadToEnd();
            }
            MessageBox.Show(license, "My Note Reader");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"notes.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(tbMain.Text);
                MessageBox.Show("Сохранено");
            }
           
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            symbolCount = 35 + (int) numUDDate.Value;
            Random rnd = new Random();
            char[] array =  tbMain.Text.ToCharArray();
            for (int i = 0; i < array.Length; i+=2)
            {
                int replaceChar = rnd.Next(35, symbolCount);
                char ch = Convert.ToChar(replaceChar);
                correctChars.Add(array[i]);
                array[i] = ch;
            }
            using (StreamWriter sw = new StreamWriter(listpath, false))
            {
                for (int i = 0; i < correctChars.Count; i++)
                {
                    sw.Write(correctChars[i]);
                }
            }

            tbMain.Text = "";
            for (int i = 0; i < array.Length; i++)
            {
                tbMain.Text += array[i];
            }
            btnUnGen.Visible = true;
        }

        private void btnUnGen_Click(object sender, EventArgs e)
        {
            char[] dearray = tbMain.Text.ToCharArray();
            for (int i = 0, j = 0; i < dearray.Length; i+=2, j++)
            {
                dearray[i] = correctChars[j];
            }
            tbMain.Text = "";
            for (int i = 0; i < dearray.Length; i++)
            {
                tbMain.Text += dearray[i];
            }
            correctChars.DefaultIfEmpty();
            File.WriteAllText(listpath, string.Empty);
            
        }
    }
}
