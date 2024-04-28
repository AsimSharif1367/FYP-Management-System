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
    public partial class Meeting_Schedule : Form
    {
        // Connection string for your database
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public Meeting_Schedule()
        {
            InitializeComponent();
            LoadData(); // Load data when the form is loaded
        }

        private void LoadData()
        {
            try
            {
                // SQL query to select all 
                string query = "SELECT * FROM ScheduleMeeting";

                // Establish connection and retrieve data
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Display data in the DataGridView 
                        meetingscheduledataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void meetingscheduledataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

       


        
