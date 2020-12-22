using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalse
{
    //3. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не
    //   создана база данных, обращение к несуществующему вопросу, открытие слишком большого
    //   файла и т.д.).
    //   б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив
    //   другие «косметические» улучшения на свое усмотрение.
    //   в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия,
    //   авторские права и др.).
    //   г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных
    //   (элемент SaveFileDialog). Жмачиснкий Максим

    public partial class Form1 : Form
    {
        TFclass database;
        SaveFileDialog SaveAs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) //Сохраняет список вопросов

        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TFclass(sfd.FileName);// у экземпляра класса sfd есть свойство FileName, которым мы назовем наш список вопросов
                database.Add("123", true);
                database.Save(); //Метод сохраняющий наш список в формате xml
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database != null)
            { 
               tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
               cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            else if (database != null && nudNumber.Value > database.Count)
            {
                MessageBox.Show($"Под этим индексом нет вопроса. Колличество вопросов в списке {database.Count}");
            }
            else
            {
                MessageBox.Show("Создайте список вопросов", "Ошибка");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)//если нет базы данных
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Save();
            } 
                
            else MessageBox.Show("База данных не создана");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TFclass(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                tboxQuestion.Text = database[0].Text;
            }
        }

        private void btnSaveQuest_Click(object sender, EventArgs e) //?????
        {
            database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        /// <summary>
        /// в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа <<TrueFalse>> предназначена\n для создания списка вопросов" +
                            " и\nхранения их в формате XML.\n\nv.1.0 " +
                            "\nLicense: MaxZhmachinsky", "О программе.");
        }


        /// <summary>
        /// г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs = new SaveFileDialog();
            if (SaveAs.ShowDialog() == DialogResult.OK)
            {
                if (database != null)
                {
                    database.FileName = SaveAs.FileName;
                    database.Save();
                }
                else MessageBox.Show("База данных не создана");
            }

        }


        
    }
}
