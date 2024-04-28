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
    public partial class MarksForm : Form
    {

        // Connection string for your database
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";


        private string loggedInStudentID;

        public MarksForm(string studentID)
        {
            InitializeComponent();
            loggedInStudentID = studentID;
            DisplayEvaluationResults();
        }

        private void DisplayEvaluationResults()
        {
            try
            {
                // Fetch evaluation results for the logged-in student's ID
                string query = @"
            SELECT EvaluationID, Document_Marks, Mid_Marks, Final_Marks, Grade 
            FROM Evaluation 
            WHERE Student1_ID = @StudentID OR Student2_ID = @StudentID OR Student3_ID = @StudentID";

                
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        
                        cmd.Parameters.AddWithValue("@StudentID", loggedInStudentID);

                        
                        SqlDataReader reader = cmd.ExecuteReader();

                        
                        DataTable dt = new DataTable();

                        
                        dt.Load(reader);

                        
                        marksdataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching evaluation results: " + ex.Message);
            }
        }


        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            //this.Hide();    
        }

        private void marksdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}




    