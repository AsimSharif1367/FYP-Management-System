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
    public partial class MakeAnnouncements : Form
    {
        // Connection string for your database
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public MakeAnnouncements()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            //// Get input values from the form
            //string supervisorID = supervisoridbox.Text;
            //string title = titlebox.Text;
            //string content = contentbox.Text;

            //// Ensure required fields are not empty
            //if (string.IsNullOrWhiteSpace(supervisorID) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            //{
            //    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Insert announcement into the database
            //InsertAnnouncement(supervisorID, title, content);

            //// Close the form
            //this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void supervisoridbox_TextChanged(object sender, EventArgs e)
        {
            // event handling logic here
        }

        private void InsertAnnouncement(string supervisorID, string title, string content)
        {
            // SQL query to insert announcement into MakeAnnouncements table
            string query = "INSERT INTO MakeAnnouncements (SupervisorID, AnnouncementDate, Title, Content) " +
                           "VALUES (@SupervisorID, GETDATE(), @Title, @Content)";

            try
            {
                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@SupervisorID", supervisorID);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Content", content);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

                // Display success message
                MessageBox.Show("Announcement successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("An error occurred while adding the announcement: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Get input values from the form
            string supervisorID = supervisoridbox.Text;
            string title = titlebox.Text;
            string content = contentbox.Text;

            // Ensure required fields are not empty
            if (string.IsNullOrWhiteSpace(supervisorID) || string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert announcement into the database
            InsertAnnouncement(supervisorID, title, content);

            // Close the form
            this.Close();
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
