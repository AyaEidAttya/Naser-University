using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naser_University.dashboardcon.Tables
{
    public partial class baseTable : Form
    {
        public baseTable()
        {
            InitializeComponent();
        }
        private Form currentForm = null;

        private void ShowFormInPanel(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.Show();
        }

        private void buttonExam_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new TableExam());
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new TaplesSupject());
        }

        private void panelshowtable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
