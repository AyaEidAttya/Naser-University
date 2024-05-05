namespace Naser_University.dashboardcon
{
    partial class employeeForm
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
            this.buttonprint = new System.Windows.Forms.Button();
            this.buttonremove = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonnew = new System.Windows.Forms.Button();
            this.comboBoxjop = new System.Windows.Forms.ComboBox();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxfullname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonprint
            // 
            this.buttonprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonprint.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonprint.Location = new System.Drawing.Point(704, 618);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(170, 60);
            this.buttonprint.TabIndex = 33;
            this.buttonprint.Text = "Print";
            this.buttonprint.UseVisualStyleBackColor = true;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // buttonremove
            // 
            this.buttonremove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonremove.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonremove.Location = new System.Drawing.Point(488, 618);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(170, 60);
            this.buttonremove.TabIndex = 32;
            this.buttonremove.Text = "Remove";
            this.buttonremove.UseVisualStyleBackColor = true;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonadd.Location = new System.Drawing.Point(276, 618);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(170, 60);
            this.buttonadd.TabIndex = 31;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonnew
            // 
            this.buttonnew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnew.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonnew.Location = new System.Drawing.Point(74, 618);
            this.buttonnew.Name = "buttonnew";
            this.buttonnew.Size = new System.Drawing.Size(170, 60);
            this.buttonnew.TabIndex = 30;
            this.buttonnew.Text = "New";
            this.buttonnew.UseVisualStyleBackColor = true;
            this.buttonnew.Click += new System.EventHandler(this.buttonnew_Click);
            // 
            // comboBoxjop
            // 
            this.comboBoxjop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxjop.FormattingEnabled = true;
            this.comboBoxjop.Items.AddRange(new object[] {
            "Professor",
            "Teaching Assistany",
            "Executive",
            "Safe Person",
            "Dustman "});
            this.comboBoxjop.Location = new System.Drawing.Point(322, 249);
            this.comboBoxjop.Name = "comboBoxjop";
            this.comboBoxjop.Size = new System.Drawing.Size(428, 37);
            this.comboBoxjop.TabIndex = 29;
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxgender.Location = new System.Drawing.Point(322, 506);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(428, 37);
            this.comboBoxgender.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 417);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(428, 34);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(127, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(125, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(126, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(125, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Jop Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(125, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(125, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Full Name";
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(322, 324);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(428, 47);
            this.textBoxID.TabIndex = 20;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(322, 139);
            this.textBoxSalary.Multiline = true;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(428, 47);
            this.textBoxSalary.TabIndex = 19;
            // 
            // textBoxfullname
            // 
            this.textBoxfullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfullname.Location = new System.Drawing.Point(322, 47);
            this.textBoxfullname.Multiline = true;
            this.textBoxfullname.Name = "textBoxfullname";
            this.textBoxfullname.Size = new System.Drawing.Size(428, 47);
            this.textBoxfullname.TabIndex = 18;
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(948, 725);
            this.Controls.Add(this.buttonprint);
            this.Controls.Add(this.buttonremove);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttonnew);
            this.Controls.Add(this.comboBoxjop);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxfullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeForm";
            this.Text = "employeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.Button buttonremove;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonnew;
        private System.Windows.Forms.ComboBox comboBoxjop;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxfullname;
    }
}