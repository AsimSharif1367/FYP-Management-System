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
    public partial class Form4 : Form
    {
        // Connection string for your database
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Load data when the form is loaded
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // SQL query to select details from the RegisterGroups table
                string query = "SELECT GroupName, GroupID, ProjectName, Student1_ID, Student2_ID, Student3_ID, ProjectDescription FROM RegisterGroups";

                // Establish connection and retrieve data
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Display data in a DataGridView 
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
