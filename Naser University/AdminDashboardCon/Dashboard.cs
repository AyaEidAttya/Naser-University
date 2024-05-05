using Naser_University.dashboardcon.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naser_University.dashboardcon
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

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
            panel6.Controls.Add(form);
            panel6.Tag = form;
            form.Show();
        }
        private void buttonStudent_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Student());
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {

            ShowFormInPanel(new ReportForm());
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {

            ShowFormInPanel(new employeeForm());

        }

        private void table_Click(object sender, EventArgs e)
        {
            baseTable basw = new baseTable();
            basw.Show();
            this.Hide();

        }
    }
}
