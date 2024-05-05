using Naser_University.acount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naser_University.acount_admin
{
    public partial class homeacount : Form
    {
        public homeacount()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Login"] == null)
            {
                Login adminLogin = new Login();

                adminLogin.TopLevel = false;
                adminLogin.Size = panel1.Size;
                adminLogin.AutoScroll = true;
                panel1.Controls.Add(adminLogin);
                adminLogin.Show();
            }
            else
            {
                Application.OpenForms["Login"].Visible = true;
            }

            if (Application.OpenForms["adminsigup2"] != null)
            {
                if (Application.OpenForms["adminsigup2"].Visible)
                {
                    Application.OpenForms["adminsigup2"].Visible = false;
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["adminsigup2"] == null)
            {
                adminsigup2 adminSignup = new adminsigup2();

                adminSignup.TopLevel = false;
                adminSignup.Size = panel1.Size;
                adminSignup.AutoScroll = true;
                panel1.Controls.Add(adminSignup);
                adminSignup.Show();
            }
            else
            {
                Application.OpenForms["adminsigup2"].Visible = true;
            }

            if (Application.OpenForms["Login"] != null)
            {
                if (Application.OpenForms["Login"].Visible)
                {
                    Application.OpenForms["Login"].Visible = false;
                }
            }
        }
    }
}
