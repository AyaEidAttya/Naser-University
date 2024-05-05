namespace Naser_University.dashboardcon.Tables
{
    partial class baseTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseTable));
            this.panelshowtable = new System.Windows.Forms.Panel();
            this.buttonExam = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelshowtable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelshowtable
            // 
            this.panelshowtable.BackgroundImage = global::Naser_University.Properties.Resources.Screenshot_2024_05_04_222010;
            this.panelshowtable.Controls.Add(this.buttonExam);
            this.panelshowtable.Controls.Add(this.buttonSub);
            resources.ApplyResources(this.panelshowtable, "panelshowtable");
            this.panelshowtable.Name = "panelshowtable";
            this.panelshowtable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelshowtable_Paint);
            // 
            // buttonExam
            // 
            resources.ApplyResources(this.buttonExam, "buttonExam");
            this.buttonExam.FlatAppearance.BorderSize = 0;
            this.buttonExam.Name = "buttonExam";
            this.buttonExam.UseVisualStyleBackColor = true;
            this.buttonExam.Click += new System.EventHandler(this.buttonExam_Click);
            // 
            // buttonSub
            // 
            resources.ApplyResources(this.buttonSub, "buttonSub");
            this.buttonSub.FlatAppearance.BorderSize = 0;
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // baseTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelshowtable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "baseTable";
            this.panelshowtable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelshowtable;
        private System.Windows.Forms.Button buttonExam;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Panel panel2;
    }
}