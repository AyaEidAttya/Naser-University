using Naser_University.acount_admin;
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

namespace Naser_University.acount
{
    public partial class satartForm : Form
    {
        public satartForm()
        {
            InitializeComponent();
        }

        private void satartForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login_signupuser user = new login_signupuser();
            user.Show();

            // أخفي صفحة الـ login
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeacount signdForm = new homeacount();
            signdForm.Show();

            // أخفي صفحة الـ login
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
