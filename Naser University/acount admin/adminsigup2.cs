using Naser_University.Dashboard;
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

namespace Naser_University.acount_admin
{
    public partial class adminsigup2 : Form
    {
        private string sql = "Data Source=DESKTOP-HCP8DEA;Initial Catalog=NaserUniversity;Integrated Security=True";
        public adminsigup2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2username.Text;
            string password = textBox2password.Text;
            string email = textBox3email.Text;


            // اتصال بقاعدة البيانات
            string connectionString = sql;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // استعلام SQL لإدراج بيانات الحساب الجديد
                string query = "INSERT INTO Admine (username, password, email) VALUES (@username, @password, @email)";
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



                    DashboardAdmine dashboard = new DashboardAdmine();
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
    }
}
