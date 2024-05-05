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

namespace Naser_University.user_acount
{
    public partial class login_signupuser : Form
    {
        public login_signupuser()
        {
            InitializeComponent();
        }

        private void login_signupuser_Load(object sender, EventArgs e)
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
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.Show();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new userLogin());

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new userSignup());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
