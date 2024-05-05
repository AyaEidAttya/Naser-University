using Naser_University.user_acount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naser_University.Dashboard
{
    public partial class DashboardAdmine : Form
    {
        public DashboardAdmine()
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
            panelShow.Controls.Add(form);
            panelShow.Tag = form;
            form.Show();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new employeeForm());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormStudent());

        }

        private void RebortBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ReportForm());
        }

        private void SportBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Sport_Form());
        }

        private void buttontable_Click(object sender, EventArgs e)
        {

        }
    }
}
