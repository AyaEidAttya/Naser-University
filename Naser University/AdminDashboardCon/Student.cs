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
using System.Drawing.Printing;
namespace Naser_University.dashboardcon
{
    public partial class Student : Form
    {
        private string sql = "Data Source=DESKTOP-HCP8DEA;Initial Catalog=NaserUniversity;Integrated Security=True";
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string fullname = textBoxfullname.Text;
            string id = textBoxID.Text;
            string address = textBoxaddress.Text;
            string level = comboBoxLEVEL.SelectedItem.ToString();
            string gender = comboBoxgender.SelectedItem.ToString();
            DateTime birthdate = dateTimePicker1.Value;

            // اتصال بقاعدة البيانات
            string connectionString = sql;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // استعلام SQL لإدراج بيانات الطالب الجديد
                string query = "INSERT INTO Students (fullname, id, address, level, gender, birthdate) VALUES (@fullname, @id, @address, @level, @gender, @birthdate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@level", level);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birthdate", birthdate);

                // فتح الاتصال وتنفيذ الاستعلام
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                // التحقق من نجاح إدراج البيانات
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student data added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add student data.");
                }
            }
        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            textBoxfullname.Text = "";
            textBoxID.Text = "";
            textBoxaddress.Text = "";

            // إفراغ الكومبو بوكس
            comboBoxLEVEL.SelectedIndex = -1;
            comboBoxgender.SelectedIndex = -1;

            // إعادة تعيين تاريخ الميلاد إلى التاريخ الحالي
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                int idToRemove;
                if (int.TryParse(textBoxID.Text, out idToRemove))
                {
                    // اتصال بقاعدة البيانات
                    string connectionString = sql;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // استعلام SQL لحذف سجل الطالب بناءً على الـ ID
                        string query = "DELETE FROM Students WHERE Id = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", idToRemove);

                        // فتح الاتصال وتنفيذ الاستعلام
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // التحقق من نجاح الحذف
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully.");
                            // إفراغ حقل الـ ID بعد الحذف
                            textBoxID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete student record. Student ID not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the student ID to remove.");
            }
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                int idToPrint;
                if (int.TryParse(textBoxID.Text, out idToPrint))
                {
                    // اتصال بقاعدة البيانات
                    string connectionString = sql;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // استعلام SQL لاسترداد بيانات الطالب بناءً على الـ ID
                        string query = "SELECT * FROM Students WHERE Id = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", idToPrint);

                        // فتح الاتصال واسترداد البيانات
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // التحقق من وجود بيانات للطالب
                        if (reader.Read())
                        {
                            string fullname = reader["Fullname"].ToString();
                            string id = reader["ID"].ToString();
                            string address = reader["Address"].ToString();
                            string level = reader["Level"].ToString();
                            string gender = reader["Gender"].ToString();
                            DateTime birthdate = (DateTime)reader["Birthdate"];

                            // إغلاق القراءة
                            reader.Close();

                            // إعداد الطابعة وطلب اختيار التنسيقات
                            PrintDialog printDialog = new PrintDialog();
                            PrintDocument printDocument = new PrintDocument();
                            printDialog.Document = printDocument;
                            if (printDialog.ShowDialog() == DialogResult.OK)
                            {
                                printDocument.PrintPage += (s, ev) =>
                                {
                                    // تنسيق بيانات الطالب للطباعة
                                    string studentData = $"Fullname: {fullname}\n" +
                                                         $"ID: {id}\n" +
                                                         $"Address: {address}\n" +
                                                         $"Level: {level}\n" +
                                                         $"Gender: {gender}\n" +
                                                         $"Birthdate: {birthdate.ToShortDateString()}";

                                    // تحديد تنسيقات الطباعة (خط الطباعة وموقع النص)
                                    Font font = new Font("Arial", 12);
                                    ev.Graphics.DrawString(studentData, font, Brushes.Black, 100, 100);

                                    // التحكم في تنسيقات الصفحة
                                    ev.PageSettings.Margins = new Margins(100, 100, 100, 100); // هنا يمكنك ضبط الهوامش
                                };

                                // طباعة الصفحة
                                printDocument.Print();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student not found.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the student ID to print.");
            }

        }
    }
}
