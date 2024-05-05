using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naser_University.dashboardcon
{
    public partial class employeeForm : Form
    {
        private string sql = "Data Source=DESKTOP-HCP8DEA;Initial Catalog=NaserUniversity;Integrated Security=True";
        public employeeForm()
        {
            InitializeComponent();
        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            textBoxfullname.Text = "";
            textBoxID.Text = "";
            textBoxSalary.Text = "";

            // إفراغ الكومبو بوكس
            comboBoxjop.SelectedIndex = -1;
            comboBoxgender.SelectedIndex = -1;

            // إعادة تعيين تاريخ الميلاد إلى التاريخ الحالي
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string fullname = textBoxfullname.Text;
            string id = textBoxID.Text;
            string salary = textBoxSalary.Text;
            string joptype = comboBoxjop.SelectedItem.ToString();
            string gender = comboBoxgender.SelectedItem.ToString();
            DateTime birthdate = dateTimePicker1.Value;

            // اتصال بقاعدة البيانات
            string connectionString = sql;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // استعلام SQL للتحقق من عدم تواجد قيمة id محددة في الجدول
                string checkQuery = "SELECT COUNT(*) FROM Employee WHERE id = @id";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@id", id);

                connection.Open();
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Employee with this ID already exists.");
                }
                else
                {
                    // استعلام SQL لإدراج بيانات الموظف الجديد
                    string query = "INSERT INTO Employee (fullname, id, salary, joptype, gender, birthdate) VALUES (@fullname, @id, @salary, @joptype, @gender, @birthdate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@joptype", joptype);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@birthdate", birthdate);

                    // فتح الاتصال وتنفيذ الاستعلام
                    int rowsAffected = command.ExecuteNonQuery();

                    // التحقق من نجاح إدراج البيانات
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee data added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add employee data.");
                    }
                }
            }

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
                        string query = "DELETE FROM Employee WHERE Id = @id";
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
                MessageBox.Show("Please enter the Employee ID to remove.");
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
                        string query = "SELECT * FROM Employee WHERE Id = @id";
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
                            string salary = reader["salary"].ToString();
                            string joptype = reader["joptype"].ToString();
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
                                                         $"salary: {salary}\n" +
                                                         $"joptype: {joptype}\n" +
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
                            MessageBox.Show("Employee not found.");
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
