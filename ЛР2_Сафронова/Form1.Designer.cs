namespace ЛР2_Сафронова
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
            this.userControl11 = new ЛР2_Сафронова.FolderForModel.UserControl1();
            this.userControl12 = new ЛР2_Сафронова.FolderForModel.UserControl1();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(114, 85);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(564, 585);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(684, 85);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(564, 585);
            this.userControl12.TabIndex = 1;
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Location = new System.Drawing.Point(12, 228);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(75, 300);
            this.ButtonLeft.TabIndex = 2;
            this.ButtonLeft.Text = "<";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click_1);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Location = new System.Drawing.Point(1247, 228);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(75, 300);
            this.ButtonRight.TabIndex = 3;
            this.ButtonRight.Text = ">";
            this.ButtonRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 751);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FolderForModel.UserControl1 userControl11;
        private FolderForModel.UserControl1 userControl12;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonRight;
    }
}

