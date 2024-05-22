namespace RecrutCentr
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogINbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AppExitlabel = new System.Windows.Forms.Label();
            this.Rolllabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(180, 227);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(136, 20);
            this.PasswordtextBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Пароль";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(180, 186);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(136, 20);
            this.EmailtextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Электронная почта";
            // 
            // LogINbutton
            // 
            this.LogINbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogINbutton.Location = new System.Drawing.Point(353, 290);
            this.LogINbutton.Name = "LogINbutton";
            this.LogINbutton.Size = new System.Drawing.Size(97, 38);
            this.LogINbutton.TabIndex = 30;
            this.LogINbutton.Text = "Войти";
            this.LogINbutton.UseVisualStyleBackColor = true;
            this.LogINbutton.Click += new System.EventHandler(this.LogINbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 52);
            this.button1.TabIndex = 31;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AppExitlabel);
            this.panel1.Controls.Add(this.Rolllabel);
            this.panel1.Location = new System.Drawing.Point(718, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 33);
            this.panel1.TabIndex = 32;
            // 
            // AppExitlabel
            // 
            this.AppExitlabel.AutoSize = true;
            this.AppExitlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppExitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppExitlabel.Location = new System.Drawing.Point(48, 0);
            this.AppExitlabel.Name = "AppExitlabel";
            this.AppExitlabel.Size = new System.Drawing.Size(31, 29);
            this.AppExitlabel.TabIndex = 19;
            this.AppExitlabel.Text = "X";
            this.AppExitlabel.Click += new System.EventHandler(this.AppExitlabel_Click);
            // 
            // Rolllabel
            // 
            this.Rolllabel.AutoSize = true;
            this.Rolllabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rolllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rolllabel.Location = new System.Drawing.Point(5, 0);
            this.Rolllabel.Name = "Rolllabel";
            this.Rolllabel.Size = new System.Drawing.Size(28, 29);
            this.Rolllabel.TabIndex = 18;
            this.Rolllabel.Text = "—";
            this.Rolllabel.Click += new System.EventHandler(this.Rolllabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogINbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogINbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AppExitlabel;
        private System.Windows.Forms.Label Rolllabel;
    }
}