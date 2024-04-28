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
    public partial class ProfileForm : Form
    {
        private string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";
        private string studentID;

        public ProfileForm(string loggedInStudentID)
        {
            InitializeComponent();
            this.studentID = loggedInStudentID;
            LoadProfile();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadProfile()
        {
            string query = "SELECT StudentID, GroupID, StudentName, Degree, Email, ContactNumber, DateOfBirth, City FROM Students WHERE StudentID = @StudentID";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Student not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading profile: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}