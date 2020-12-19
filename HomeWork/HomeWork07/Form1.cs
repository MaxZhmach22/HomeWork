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
    public partial class Form1 : Form 
    {
        
        Random r = new Random();
        int correctAnswer;
        Logic game;
        public int tryCount;

        public Form1()
        {
            InitializeComponent();
            correctAnswer = r.Next(1, 101);
            game = new Logic();
            tryCount = 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            lblInfo.ResetText();
            lblTitle.Text = "";
            label1.Font = new Font("Arial", 11F);
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Text = game.text;
            btnStart.Visible = false;
            BtnMTCount3.Visible = BtnMTCount5.Visible = BtnMTCount7.Visible = true;
        }

        private void BtnMTCount3_Click(object sender, EventArgs e)
        {
            
           
            BtnCheck.Visible = true;
            BtnMTCount3.Visible = BtnMTCount5.Visible = BtnMTCount7.Visible = false;
            label1.Visible = false;
            lblTitle.Text = "    Вы готовы?";
            game.maxTryCount = 3;
            
        }

        private void BtnMTCount5_Click(object sender, EventArgs e)
        {
            
            BtnCheck.Visible = true;
            label1.Visible = false;
            lblTitle.Text = "    Вы готовы?";
            BtnMTCount3.Visible = BtnMTCount5.Visible = BtnMTCount7.Visible = false;
            game.maxTryCount = 5;
            
        }

        private void BtnMTCount7_Click(object sender, EventArgs e)
        {
            
            
            BtnCheck.Visible = true;
            label1.Visible = false;
            lblTitle.Text = "    Вы готовы?";
            BtnMTCount3.Visible = BtnMTCount5.Visible = BtnMTCount7.Visible = false;
            game.maxTryCount = 7;
            

        }
        
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            lblTitle.Visible = false;
            FormTBox formTBox = new FormTBox();
            formTBox.ShowDialog();
            game.userAnswer = formTBox.userAnswer;
            label1.Text = "";
            game.correctAnswer = correctAnswer;
            if(tryCount < game.maxTryCount)
            {
                
                bool answwer = game.Compare();
                if (answwer == true)
                {
                    BtnCheck.Visible = false;
                    label1.Visible = true;
                    label1.Location = new Point(700/2,500/2);
                    label1.Text = $"Вы угадали с {tryCount} попытки";
                }
                else 
                {
                    tryCount += 1; BtnCheck.Font = new Font("Arial Black", 24F); BtnCheck.Text = $"{game.maxTryCount + 1 - tryCount}";
                }
                
            }
            else
            {
                
                lblTitle.Visible = false;
                label1.Visible = true;
                label1.Location = new Point(148, 169);
                label1.Text = $"Увы, попытки закончились. Вы проиграли! Правильный ответ: {correctAnswer}";
                BtnCheck.Visible = false;
                
            }

        }
    }
}
