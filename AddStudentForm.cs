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

namespace deliverable_1
{
    public partial class AddStudentForm : Form
    {
        // Connection string
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(studentidbox.Text) || string.IsNullOrWhiteSpace(groupidbox.Text) || string.IsNullOrWhiteSpace(studentnamebox.Text) ||
                string.IsNullOrWhiteSpace(degreebox.Text) || string.IsNullOrWhiteSpace(datebox.Text) || string.IsNullOrWhiteSpace(emailbox.Text) ||
                string.IsNullOrWhiteSpace(contactnobox.Text) || string.IsNullOrWhiteSpace(citybox.Text) || string.IsNullOrWhiteSpace(passwordbox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Validate Student ID
            if (!IsStudentIDValid(studentidbox.Text))
            {
                MessageBox.Show("Student ID must meet the criteria: greater than 6 characters, contain at least one aplhabet and in this Format 19i0518.");
                return;
            }

            // Check if the Student ID is unique
            if (!IsStudentIDUnique(studentidbox.Text))
            {
                MessageBox.Show("Student ID already exists. Please enter a unique Student ID.");
                return;
            }

            // Validate Group ID
            if (!IsGroupIDValid(groupidbox.Text))
            {
                MessageBox.Show("Group ID  must meet the criteria: greater than OR equal to 6 characters and in this Format GID200 .");
                return;
            }

            // Validate Contact Number
            if (!IsContactNumberValid(contactnobox.Text))
            {
                MessageBox.Show("Contact number must be exactly 10 digits long.");
                return;
            }

            // Validate Date of Birth
            if (!IsDateOfBirthValid(datebox.Text))
            {
                MessageBox.Show("Date of birth must be in the format YYYY-MM-DD.");
                return;
            }

            // Validate Email
            if (!IsEmailValid(emailbox.Text))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            // Validate the password
            if (!IsPasswordValid(passwordbox.Text))
            {
                MessageBox.Show("Password must meet the criteria: greater than 8 characters, contain at least one capital letter, one numeric digit, one special character, and one English alphabet.");
                return;
            }

            // Insert the student details into the Students table
            InsertStudentDetails();

            MessageBox.Show("Student added successfully!");
        }

        // Validate Student ID
        private bool IsStudentIDValid(string studentID)
        {
            // Check if the length is at least 8 characters
            if (studentID.Length <= 6)
                return false;

            // Check if the first two characters are digits
            if (!char.IsDigit(studentID[0]) || !char.IsDigit(studentID[1]))
                return false;

            // Check if the third character is a letter
            if (!char.IsLetter(studentID[2]))
                return false;

            // Check if the remaining characters are digits
            for (int i = 3; i < studentID.Length; i++)
            {
                if (!char.IsDigit(studentID[i]))
                    return false;
            }

            // If all conditions are met, return true
            return true;
        }


        // Validate Group ID
        private bool IsGroupIDValid(string groupID)
        {
            // Check if the length is at least 6 characters
            if (groupID.Length < 6)
                return false;

            // Check if the first three characters are "GID"
            if (groupID.Substring(0, 3) != "GID")
                return false;

            // Check if the remaining characters are digits
            for (int i = 3; i < groupID.Length; i++)
            {
                if (!char.IsDigit(groupID[i]))
                    return false;
            }

            // If all conditions are met, return true
            return true;
        }


        // Validate Contact Number
        private bool IsContactNumberValid(string contactNumber)
        {
            return contactNumber.Length == 11;
        }

        // Validate Date of Birth
        private bool IsDateOfBirthValid(string dateOfBirth)
        {
            DateTime date;
            return DateTime.TryParseExact(dateOfBirth, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out date);
        }

        private bool IsDegreeValid(string degree)
        {
            // Check if the degree starts with "BS-" or "MS-"
            if (!degree.StartsWith("BS-") && !degree.StartsWith("MS-"))
                return false;

            // Extract the program name
            string[] parts = degree.Split('-');
            if (parts.Length != 2)
                return false; // Invalid format

            // If all conditions are met, return true
            return true;
        }

        // Validate Email
        private bool IsEmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private bool IsPasswordValid(string password)
        {
            // Check if the password meets all the conditions
            if (password.Length < 8)
                return false;

            if (!password.Any(char.IsUpper))
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            if (!password.Any(char.IsPunctuation))
                return false;

            if (!password.Any(char.IsLetter))
                return false;

            // If all conditions are met, return true
            return true;
        }


        private bool IsStudentIDUnique(string studentID)
        {
            bool isUnique = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        int count = (int)command.ExecuteScalar();

                        // If count is greater than 0, it means the Student ID already exists
                        if (count > 0)
                        {
                            isUnique = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking for unique Student ID: " + ex.Message);
            }

            return isUnique;
        }

        private void InsertStudentDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Students (StudentID, GroupID, StudentName, Degree, Email, ContactNumber, DateOfBirth, City, Password)
                                     VALUES (@StudentID, @GroupID, @StudentName, @Degree, @Email, @ContactNumber, @DateOfBirth, @City, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@StudentID", studentidbox.Text);
                        command.Parameters.AddWithValue("@GroupID", groupidbox.Text);
                        command.Parameters.AddWithValue("@StudentName", studentnamebox.Text);
                        command.Parameters.AddWithValue("@Degree", degreebox.Text);
                        command.Parameters.AddWithValue("@Email", emailbox.Text);
                        command.Parameters.AddWithValue("@ContactNumber", contactnobox.Text);
                        command.Parameters.AddWithValue("@DateOfBirth", datebox.Text);
                        command.Parameters.AddWithValue("@City", citybox.Text);
                        command.Parameters.AddWithValue("@Password", passwordbox.Text);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting student details: " + ex.Message);
            }
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
           // this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void cancelbutton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}