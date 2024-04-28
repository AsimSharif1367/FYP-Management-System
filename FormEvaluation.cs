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
    public partial class FormEvaluation : Form
    {
        public FormEvaluation()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            //string GroupID = groupIDbox.Text;
            //string Student1_ID = s1IDBOX.Text;
            //string Student2_ID = s2IDBOX.Text;
            //string Student3_ID = s2IDBOX.Text;
            //decimal Document_Marks = decimal.Parse(docmarksbox.Text);
            //decimal Mid_Marks = decimal.Parse(midmarksbox.Text);
            //decimal Final_Marks = decimal.Parse(finalmarksbox.Text);
            //string Grade = gradebox.Text;
            //
            //string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";
            //
            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();

            //    string query = @"INSERT INTO Evaluation (GroupID,Student1_ID,Student2_ID,Student3_ID, Document_Marks, Mid_Marks, Final_Marks, Grade) 
            //             VALUES (@GroupID,@Student1_ID,@Student2_ID,@Student3_ID, @Document_Marks, @Mid_Marks, @Final_Marks, @Grade)";

            //    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            //    {
            //        cmd.Parameters.AddWithValue("@GroupID", GroupID);
            //        cmd.Parameters.AddWithValue("@Student1_ID", Student1_ID);
            //        cmd.Parameters.AddWithValue("@Student2_ID", Student2_ID);
            //        cmd.Parameters.AddWithValue("@Student3_ID", Student3_ID);
            //        cmd.Parameters.AddWithValue("@Document_Marks", Document_Marks);
            //        cmd.Parameters.AddWithValue("@Mid_Marks", Mid_Marks);
            //        cmd.Parameters.AddWithValue("@Final_Marks", Final_Marks);
            //        cmd.Parameters.AddWithValue("@Grade", Grade);

            //        try
            //        {
            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("Marks successfully Entered!");
            //        }
            //        catch (SqlException ex)
            //        {
            //            MessageBox.Show("An error occurred while inserting marks: " + ex.Message);
            //        }
            //    }
            //}
        }


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void evaluationIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            string GroupID = groupIDbox.Text;
            string Student1_ID = s1IDBOX.Text;
            string Student2_ID = s2IDBOX.Text;
            string Student3_ID = s2IDBOX.Text;
            decimal Document_Marks = decimal.Parse(docmarksbox.Text);
            decimal Mid_Marks = decimal.Parse(midmarksbox.Text);
            decimal Final_Marks = decimal.Parse(finalmarksbox.Text);
            string Grade = gradebox.Text;

            string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = @"INSERT INTO Evaluation (GroupID,Student1_ID,Student2_ID,Student3_ID, Document_Marks, Mid_Marks, Final_Marks, Grade) 
                         VALUES (@GroupID,@Student1_ID,@Student2_ID,@Student3_ID, @Document_Marks, @Mid_Marks, @Final_Marks, @Grade)";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@GroupID", GroupID);
                    cmd.Parameters.AddWithValue("@Student1_ID", Student1_ID);
                    cmd.Parameters.AddWithValue("@Student2_ID", Student2_ID);
                    cmd.Parameters.AddWithValue("@Student3_ID", Student3_ID);
                    cmd.Parameters.AddWithValue("@Document_Marks", Document_Marks);
                    cmd.Parameters.AddWithValue("@Mid_Marks", Mid_Marks);
                    cmd.Parameters.AddWithValue("@Final_Marks", Final_Marks);
                    cmd.Parameters.AddWithValue("@Grade", Grade);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marks successfully Entered!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred while inserting marks: " + ex.Message);
                    }
                }
            }
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
