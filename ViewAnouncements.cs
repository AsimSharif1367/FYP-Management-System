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
    public partial class ViewAnouncements : Form
    {
        // Connection string for your database
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public ViewAnouncements()
        {
            InitializeComponent();
            LoadAnnouncements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAnnouncements()
        {
            try
            {
                // SQL query to select all announcements from the database
                string query = "SELECT AnnouncementID, SupervisorID, AnnouncementDate, Title, Content FROM MakeAnnouncements";

                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a data adapter and fill a DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Set the DataTable as the DataSource for the dataGridView1
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred while loading announcements: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

