using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendMoney
{

    // 4.) *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту
    //    хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие). Жмачинский Максим

    public partial class Form1 : Form
    {
        
        Day day;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            decimal sum = 0;
            if (day == null)//если нет базы данных
            {
                MessageBox.Show("Для добавления расходов создайте новый документ.", "Сообщение");
                return;
            }
            bool flag = decimal.TryParse(tbSum.Text, out sum);
            if (flag == true)
            {
                day.Add(sum, tbGoods.Text);
                listBoxSpend.Items.Add(day[listBoxSpend.Items.Count].Goods.ToString() + " " + day[listBoxSpend.Items.Count].Sum.ToString());
            }
            else MessageBox.Show("В поле Сумма могут быть только цифры!", "Ошибка!");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                listBoxSpend.Items.Clear();
                day = new Day(sfd.FileName);
                day.Save();
                tbGoods.ResetText();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            day.Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxSpend.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                day = new Day(ofd.FileName);
                day.Load();
                string[] lboxtext = day.Print().Split(';');
                for (int i = 0; i < lboxtext.Length - 1; i++)
                {
                    listBoxSpend.Items.Add(lboxtext[i]);
                }
                
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (day == null)//если нет базы данных
            {
                MessageBox.Show("Для редактирования расходов создайте новый документ.", "Сообщение");
                return;
            }
            else if(listBoxSpend.Items == null)
            {
                MessageBox.Show("Список пуст!", "Ошибка");
                return;
            }
            else
            {
                try
                {
                    listBoxSpend.Items.RemoveAt(listBoxSpend.Items.Count - 1);
                    day.Remove(listBoxSpend.Items.Count);
                }
                catch (Exception)
                {
                    MessageBox.Show("Список пуст!", "Ошибка");
                }
               
            }
        }
    }
}
