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
   
    public partial class userLogin : Form
    { private string sql = "Data Source=DESKTOP-HCP8DEA;Initial Catalog=NaserUniversity;Integrated Security=True";
        public userLogin()
        {
            InitializeComponent();
        }

        private void userLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = Password.Text;

            // اتصال بقاعدة البيانات
            string connectionString = sql;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // استعلام SQL للتحقق من صحة اسم المستخدم وكلمة المرور
                string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                // فتح الاتصال وتنفيذ الاستعلام
                connection.Open();
                int count = (int)command.ExecuteScalar();

                // التحقق من نتيجة الاستعلام
                if (count > 0)
                {
                    // تسجيل الدخول ناجح، قم بفتح صفحة ال dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                    // إخفاء صفحة تسجيل الدخول

                }
                else
                {
                    // عرض رسالة خطأ
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
