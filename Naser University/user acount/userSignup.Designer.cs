namespace Naser_University.user_acount
{
    partial class userSignup
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.textBox2password = new System.Windows.Forms.TextBox();
            this.textBox2username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(54, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // textBox3email
            // 
            this.textBox3email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3email.Location = new System.Drawing.Point(128, 111);
            this.textBox3email.Multiline = true;
            this.textBox3email.Name = "textBox3email";
            this.textBox3email.Size = new System.Drawing.Size(278, 49);
            this.textBox3email.TabIndex = 17;
            this.textBox3email.TextChanged += new System.EventHandler(this.textBox3email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(54, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(54, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "UserName";
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSignup.Location = new System.Drawing.Point(172, 455);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(200, 49);
            this.buttonSignup.TabIndex = 14;
            this.buttonSignup.Text = "SignUp";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // textBox2password
            // 
            this.textBox2password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2password.Location = new System.Drawing.Point(128, 370);
            this.textBox2password.Multiline = true;
            this.textBox2password.Name = "textBox2password";
            this.textBox2password.Size = new System.Drawing.Size(278, 49);
            this.textBox2password.TabIndex = 13;
            this.textBox2password.TextChanged += new System.EventHandler(this.textBox2password_TextChanged);
            // 
            // textBox2username
            // 
            this.textBox2username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2username.Location = new System.Drawing.Point(128, 246);
            this.textBox2username.Multiline = true;
            this.textBox2username.Name = "textBox2username";
            this.textBox2username.Size = new System.Drawing.Size(278, 49);
            this.textBox2username.TabIndex = 12;
            this.textBox2username.TextChanged += new System.EventHandler(this.textBox2username_TextChanged);
            // 
            // userSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(556, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.textBox2password);
            this.Controls.Add(this.textBox2username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userSignup";
            this.Text = "userSignup";
            this.Load += new System.EventHandler(this.userSignup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.TextBox textBox2password;
        private System.Windows.Forms.TextBox textBox2username;
    }
}