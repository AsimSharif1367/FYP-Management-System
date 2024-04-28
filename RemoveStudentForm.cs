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
    public partial class RemoveStudentForm : Form
    {
        // Connection string
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public RemoveStudentForm()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Select all students from the Students table
                    string query = "SELECT * FROM Students";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading student data: " + ex.Message);
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            //// Check if the user has entered an ID
            //if (string.IsNullOrWhiteSpace(idtextBox.Text))
            //{
            //    MessageBox.Show("Please enter a student ID.");
            //    return;
            //}

            //// Prompt the user to confirm deletion
            //DialogResult result = MessageBox.Show("Are you sure you want to remove the student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    RemoveStudent(idtextBox.Text);
            //}
        }

        private void RemoveStudent(string studentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the student ID exists in the Students table
                    string checkStudentQuery = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";
                    using (SqlCommand checkStudentCommand = new SqlCommand(checkStudentQuery, connection))
                    {
                        checkStudentCommand.Parameters.AddWithValue("@StudentID", studentID);
                        int count = (int)checkStudentCommand.ExecuteScalar();

                        // If the student ID exists, delete the student record
                        if (count > 0)
                        {
                            string deleteQuery = "DELETE FROM Students WHERE StudentID = @StudentID";
                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@StudentID", studentID);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Student removed successfully!");
                                LoadStudentData(); // Reload the data after removal
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student ID not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the student: " + ex.Message);
            }
        }
   
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void button_removee_Click(object sender, EventArgs e)
        {
            // Check if the user has entered an ID
            if (string.IsNullOrWhiteSpace(idtextBox.Text))
            {
                MessageBox.Show("Please enter a student ID.");
                return;
            }

            // Prompt the user to confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to remove the student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RemoveStudent(idtextBox.Text);
            }
        }
    }
}
