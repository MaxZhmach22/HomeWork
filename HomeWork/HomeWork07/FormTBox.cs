using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork07
{
    public partial class FormTBox : Form
    {
        public int userAnswer;
        public FormTBox()
        {
            InitializeComponent();
            
        }

        private void newFormBtn_Click(object sender, EventArgs e)
        {
            try
            {
                userAnswer = int.Parse(newFormTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число от 1 до 100");
            }
            Close();
        }
        
    }
}
