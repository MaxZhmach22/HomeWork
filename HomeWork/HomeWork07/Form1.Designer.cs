
namespace HomeWork07
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.BtnMTCount3 = new System.Windows.Forms.Button();
            this.BtnMTCount7 = new System.Windows.Forms.Button();
            this.BtnMTCount5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(282, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(227, 77);
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Играть!";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(243, 111);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "\"Угадай число\" ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(274, 169);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(241, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Для начала игры нажмите кнопку \"Играть!\"";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnMTCount3
            // 
            this.BtnMTCount3.BackColor = System.Drawing.Color.White;
            this.BtnMTCount3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnMTCount3.Location = new System.Drawing.Point(282, 291);
            this.BtnMTCount3.Name = "BtnMTCount3";
            this.BtnMTCount3.Size = new System.Drawing.Size(227, 77);
            this.BtnMTCount3.TabIndex = 3;
            this.BtnMTCount3.Text = "3";
            this.BtnMTCount3.UseVisualStyleBackColor = false;
            this.BtnMTCount3.Visible = false;
            this.BtnMTCount3.Click += new System.EventHandler(this.BtnMTCount3_Click);
            // 
            // BtnMTCount7
            // 
            this.BtnMTCount7.BackColor = System.Drawing.Color.White;
            this.BtnMTCount7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnMTCount7.Location = new System.Drawing.Point(282, 457);
            this.BtnMTCount7.Name = "BtnMTCount7";
            this.BtnMTCount7.Size = new System.Drawing.Size(227, 77);
            this.BtnMTCount7.TabIndex = 3;
            this.BtnMTCount7.Text = "7";
            this.BtnMTCount7.UseVisualStyleBackColor = false;
            this.BtnMTCount7.Visible = false;
            this.BtnMTCount7.Click += new System.EventHandler(this.BtnMTCount7_Click);
            // 
            // BtnMTCount5
            // 
            this.BtnMTCount5.BackColor = System.Drawing.Color.White;
            this.BtnMTCount5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnMTCount5.Location = new System.Drawing.Point(282, 374);
            this.BtnMTCount5.Name = "BtnMTCount5";
            this.BtnMTCount5.Size = new System.Drawing.Size(227, 77);
            this.BtnMTCount5.TabIndex = 3;
            this.BtnMTCount5.Text = "5";
            this.BtnMTCount5.UseVisualStyleBackColor = false;
            this.BtnMTCount5.Visible = false;
            this.BtnMTCount5.Click += new System.EventHandler(this.BtnMTCount5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.Color.White;
            this.BtnCheck.Location = new System.Drawing.Point(282, 294);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(227, 75);
            this.BtnCheck.TabIndex = 6;
            this.BtnCheck.Text = "Поехали";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Visible = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMTCount7);
            this.Controls.Add(this.BtnMTCount5);
            this.Controls.Add(this.BtnMTCount3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button BtnMTCount3;
        private System.Windows.Forms.Button BtnMTCount7;
        private System.Windows.Forms.Button BtnMTCount5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCheck;
    }
}

