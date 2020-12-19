using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork07._01
{
    public partial class Form1 : Form
    {
        int countClick;
        int valueToGet;
        public Stack<int> st = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            
            countClick = 0; //Счетчик команд
        }
        public void Compare()
        {
            if (lblNumber.Text == valueToGet.ToString() && valueToGet != 0)
            {
                MessageBox.Show($"Ура, вы получили число {valueToGet} c {lblCountclick.Text} попытки(ок)!");
                Close();
            }
        }

        private void btnCommand1_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            countClick += 1;
            lblCountclick.Text = countClick.ToString();
            st.Push(Convert.ToInt32(lblNumber.Text));
            Compare();
        }

        private void btnCommand2_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            countClick += 1;
            lblCountclick.Text = countClick.ToString();
            st.Push(Convert.ToInt32(lblNumber.Text));
            Compare();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            countClick = 0;
            lblCountclick.Text = countClick.ToString();
            toGet.Text = "";

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            valueToGet = r.Next(100);
            MessageBox.Show($"Поробуйте получить это число за минимальное количество попыток: {valueToGet}", "Суперигра!");
            toGet.Text = valueToGet.ToString();
            countClick = 0;
            
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            st.Pop();
            lblNumber.Text = st.Peek().ToString();
            countClick = countClick - 1;
            lblCountclick.Text = countClick.ToString();
            
        }
    }
}
