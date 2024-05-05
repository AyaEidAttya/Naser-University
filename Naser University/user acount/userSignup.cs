using Naser_University.dashboardcon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naser_University.user_acount
{
    public partial class userSignup : Form
    {
        private string sql = "Data Source=DESKTOP-HCP8DEA;Initial Catalog=NaserUniversity;Integrated Security=True";
        public userSignup()
        {
            InitializeComponent();
        }

        private void userSignup_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string username = textBox2username.Text;
            string password = textBox2password.Text;
            string email = textBox3email.Text;


            // اتصال بقاعدة البيانات
            string connectionString = sql;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // استعلام SQL لإدراج بيانات الحساب الجديد
                string query = "INSERT INTO Users (username, password, email) VALUES (@username, @password, @email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);

                // فتح الاتصال وتنفيذ الاستعلام
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                // التحقق من نجاح إدراج البيانات
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account created successfully.");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    // إخفاء صفحة تسجيل الدخول
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Failed to create account.");
                }
            }
        }

        private void textBox2username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
