using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace deliverable_1
{
    public partial class SearchGroups : Form
    {
        private string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public SearchGroups()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //string groupID = groupIDSearchBox.Text.Trim(); // Assuming you have a textbox named groupIDSearchBox

            //if (!string.IsNullOrEmpty(groupID))
            //{
            //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //    {
            //        sqlConnection.Open();

            //        string query = "SELECT * FROM RegisterGroups WHERE GroupID LIKE @GroupID";
            //        SqlCommand cmd = new SqlCommand(query, sqlConnection);
            //        cmd.Parameters.AddWithValue("@GroupID", "%" + groupID + "%");

            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        DataTable dataTable = new DataTable();
            //        adapter.Fill(dataTable);

            //        dataGridView1.DataSource = dataTable;

            //        sqlConnection.Close();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a group ID to search.");
            //}
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_searchhh_Click(object sender, EventArgs e)
        {
            string groupID = groupIDSearchBox.Text.Trim(); // Assuming you have a textbox named groupIDSearchBox

            if (!string.IsNullOrEmpty(groupID))
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = "SELECT * FROM RegisterGroups WHERE GroupID LIKE @GroupID";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@GroupID", "%" + groupID + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a group ID to search.");
            }
        }
    }
}



