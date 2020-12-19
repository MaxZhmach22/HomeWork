
namespace HomeWork07
{
    partial class FormTBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTBox));
            this.newFormTB = new System.Windows.Forms.TextBox();
            this.newFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newFormTB
            // 
            this.newFormTB.Location = new System.Drawing.Point(55, 28);
            this.newFormTB.Name = "newFormTB";
            this.newFormTB.Size = new System.Drawing.Size(130, 22);
            this.newFormTB.TabIndex = 0;
            this.newFormTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newFormBtn
            // 
            this.newFormBtn.BackColor = System.Drawing.Color.White;
            this.newFormBtn.Location = new System.Drawing.Point(55, 71);
            this.newFormBtn.Name = "newFormBtn";
            this.newFormBtn.Size = new System.Drawing.Size(130, 33);
            this.newFormBtn.TabIndex = 1;
            this.newFormBtn.Text = "Проверяем!";
            this.newFormBtn.UseVisualStyleBackColor = false;
            this.newFormBtn.Click += new System.EventHandler(this.newFormBtn_Click);
            // 
            // FormTBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(236, 116);
            this.Controls.Add(this.newFormBtn);
            this.Controls.Add(this.newFormTB);
            this.Name = "FormTBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите ваш ответ:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newFormTB;
        private System.Windows.Forms.Button newFormBtn;
    }
}