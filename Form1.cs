using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace deliverable_1
{
    public partial class Form1 : Form
    {
        // Connection
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //// Check if the user has entered values in both text boxes and selected a role
            //if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || comboBox1.SelectedItem == null)
            //{
            //    MessageBox.Show("Please enter both username, password, and select a role.");
            //    return;
            //}

            //string role = comboBox1.SelectedItem.ToString();

            //if (AuthenticateUser(textBox1.Text, textBox2.Text, role))
            //{
            //    MessageBox.Show("Login successful!");

            //    if (role == "Students")
            //    {
            //        string loggedInStudentID = textBox1.Text;

            //        StudentHomeForm studentHomeForm = new StudentHomeForm(loggedInStudentID);
            //        studentHomeForm.Show();
            //        this.Hide();
            //    }
            //    else if (role == "Supervisor")
            //    {
            //        string loggedInSupervisorID = textBox1.Text;
            //        Form2 form2 = new Form2(loggedInSupervisorID);
            //        form2.Show();
            //        this.Hide();
            //    }
            //    else if (role == "Admin")
            //    {
            //        AdminHomeForm adminHomeForm = new AdminHomeForm();
            //        adminHomeForm.Show();
            //        this.Hide();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username, password, or user type. Please try again.");
            //}
        }

        private bool AuthenticateUser(string userID, string password, string role)
        {
            bool isAuthenticated = false;

            try
            {
                string query = "";

                if (role == "Admin")
                {
                    query = "SELECT COUNT(*) FROM Admin WHERE AdminID COLLATE Latin1_General_CS_AS = @UserID AND Password COLLATE Latin1_General_CS_AS = @Password";
                }
                else if (role == "Supervisor")
                {
                    query = "SELECT COUNT(*) FROM Supervisor WHERE SupervisorID COLLATE Latin1_General_CS_AS = @UserID AND Password COLLATE Latin1_General_CS_AS = @Password";
                }
                else if (role == "Students")
                {
                    query = "SELECT COUNT(*) FROM Students WHERE StudentID COLLATE Latin1_General_CS_AS = @UserID AND Password COLLATE Latin1_General_CS_AS = @Password";
                }
                else
                {
                    MessageBox.Show("Invalid role selected.");
                    return false;
                }

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            isAuthenticated = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating user: " + ex.Message);
            }

            return isAuthenticated;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the user has entered values in both text boxes and selected a role
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please enter both username, password, and select a role.");
                return;
            }

            string role = comboBox1.SelectedItem.ToString();

            if (AuthenticateUser(textBox1.Text, textBox2.Text, role))
            {
                MessageBox.Show("Login successful!");

                if (role == "Students")
                {
                    string loggedInStudentID = textBox1.Text;

                    StudentHomeForm studentHomeForm = new StudentHomeForm(loggedInStudentID);
                    studentHomeForm.Show();
                    this.Hide();
                }
                else if (role == "Supervisor")
                {
                    string loggedInSupervisorID = textBox1.Text;
                    Form2 form2 = new Form2(loggedInSupervisorID);
                    form2.Show();
                    this.Hide();
                }
                else if (role == "Admin")
                {
                    AdminHomeForm adminHomeForm = new AdminHomeForm();
                    adminHomeForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username, password, or user type. Please try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
