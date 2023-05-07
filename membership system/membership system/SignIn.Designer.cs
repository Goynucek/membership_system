
namespace membership_system
{
    partial class SignIn
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InsertPassword = new System.Windows.Forms.TextBox();
            this.InsertUsername = new System.Windows.Forms.TextBox();
            this.InsertSurname = new System.Windows.Forms.TextBox();
            this.InsertName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertPassword
            // 
            this.InsertPassword.Location = new System.Drawing.Point(72, 81);
            this.InsertPassword.Name = "InsertPassword";
            this.InsertPassword.Size = new System.Drawing.Size(100, 20);
            this.InsertPassword.TabIndex = 12;
            this.InsertPassword.UseSystemPasswordChar = true;
            // 
            // InsertUsername
            // 
            this.InsertUsername.Location = new System.Drawing.Point(72, 55);
            this.InsertUsername.Name = "InsertUsername";
            this.InsertUsername.Size = new System.Drawing.Size(100, 20);
            this.InsertUsername.TabIndex = 11;
            // 
            // InsertSurname
            // 
            this.InsertSurname.Location = new System.Drawing.Point(72, 32);
            this.InsertSurname.Name = "InsertSurname";
            this.InsertSurname.Size = new System.Drawing.Size(100, 20);
            this.InsertSurname.TabIndex = 10;
            // 
            // InsertName
            // 
            this.InsertName.Location = new System.Drawing.Point(72, 6);
            this.InsertName.Name = "InsertName";
            this.InsertName.Size = new System.Drawing.Size(100, 20);
            this.InsertName.TabIndex = 9;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 138);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InsertPassword);
            this.Controls.Add(this.InsertUsername);
            this.Controls.Add(this.InsertSurname);
            this.Controls.Add(this.InsertName);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InsertPassword;
        private System.Windows.Forms.TextBox InsertUsername;
        private System.Windows.Forms.TextBox InsertSurname;
        private System.Windows.Forms.TextBox InsertName;
    }
}