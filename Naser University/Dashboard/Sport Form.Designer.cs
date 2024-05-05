namespace Naser_University.Dashboard
{
    partial class Sport_Form
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
            this.comboBoxsport = new System.Windows.Forms.ComboBox();
            this.comboBoxlevel = new System.Windows.Forms.ComboBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxsport
            // 
            this.comboBoxsport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxsport.FormattingEnabled = true;
            this.comboBoxsport.Items.AddRange(new object[] {
            "Football",
            "basketball",
            "boxing",
            "roller skating",
            "cricket",
            "ice hockey"});
            this.comboBoxsport.Location = new System.Drawing.Point(169, 188);
            this.comboBoxsport.Name = "comboBoxsport";
            this.comboBoxsport.Size = new System.Drawing.Size(352, 39);
            this.comboBoxsport.TabIndex = 0;
            this.comboBoxsport.Text = "selecte your sport";
            // 
            // comboBoxlevel
            // 
            this.comboBoxlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxlevel.FormattingEnabled = true;
            this.comboBoxlevel.Items.AddRange(new object[] {
            "beginner",
            "Intermediate level",
            "professional"});
            this.comboBoxlevel.Location = new System.Drawing.Point(169, 321);
            this.comboBoxlevel.Name = "comboBoxlevel";
            this.comboBoxlevel.Size = new System.Drawing.Size(352, 39);
            this.comboBoxlevel.TabIndex = 1;
            this.comboBoxlevel.Text = "select your level";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(169, 107);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(352, 45);
            this.textBoxname.TabIndex = 2;
            this.textBoxname.Text = "enter your name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sports";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(172)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Sport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(563, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.comboBoxlevel);
            this.Controls.Add(this.comboBoxsport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sport_Form";
            this.Text = "Sport_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxsport;
        private System.Windows.Forms.ComboBox comboBoxlevel;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}