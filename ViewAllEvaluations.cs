using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deliverable_1
{
    public partial class ViewAllEvaluations : Form
    {
        // Connection string for your database
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public ViewAllEvaluations()
        {
            InitializeComponent();
            LoadData(); // Load data when the form is loaded
        }

        private void LoadData()
        {
            try
            {
                // SQL query to select all evaluations from the Evaluation table
                string query = "SELECT * FROM Evaluation";

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
                        EvaluationsGrid.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


