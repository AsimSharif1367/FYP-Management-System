using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliverable_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //////////////////////////////////////////
        private void button_add_Click(object sender, EventArgs e)
        {
            //// Add new group
            //string groupName = GROUPNAME.Text;
            //string groupID = GROUPID.Text;
            //string projectName = PROJECTNAME.Text;
            //string projectDescription = PROJECTDESCRIPTION.Text;
            //string student1ID = STUDENTID1.Text;
            //string student2ID = STUDENTID2.Text;
            //string student3ID = STUDENTID3.Text;

            //string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();

            //    // Check if the provided groupID already exists
            //    string checkGroupQuery = "SELECT COUNT(*) FROM RegisterGroups WHERE GroupID = @GroupID";
            //    SqlCommand checkGroupCmd = new SqlCommand(checkGroupQuery, sqlConnection);
            //    checkGroupCmd.Parameters.AddWithValue("@GroupID", groupID);
            //    int existingGroupCount = (int)checkGroupCmd.ExecuteScalar();

            //    // If groupID already exists, prompt the user to enter a different one
            //    if (existingGroupCount > 0)
            //    {
            //        MessageBox.Show("Group ID already exists. Please enter a different Group ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return; // Stop further execution
            //    }

            //    // Check if any of the provided student IDs already exist (case-insensitive check)
            //    string checkStudentQuery = "SELECT COUNT(*) FROM RegisterGroups WHERE LOWER(Student1_ID) = LOWER(@Student1_ID) OR LOWER(Student2_ID) = LOWER(@Student2_ID) OR LOWER(Student3_ID) = LOWER(@Student3_ID)";
            //    SqlCommand checkStudentCmd = new SqlCommand(checkStudentQuery, sqlConnection);
            //    checkStudentCmd.Parameters.AddWithValue("@Student1_ID", student1ID);
            //    checkStudentCmd.Parameters.AddWithValue("@Student2_ID", student2ID);
            //    checkStudentCmd.Parameters.AddWithValue("@Student3_ID", student3ID);
            //    int existingStudentCount = (int)checkStudentCmd.ExecuteScalar();

            //    // If any of the student IDs already exist, prompt the user to enter different ones
            //    if (existingStudentCount > 0)
            //    {
            //        MessageBox.Show("One or more student IDs already exist. Please enter different student IDs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return; // Stop further execution
            //    }

            //    // Proceed with inserting the new group
            //    string insertQuery = "INSERT INTO RegisterGroups (GroupName, GroupID, ProjectName, Student1_ID, Student2_ID, Student3_ID, ProjectDescription)" +
            //                         " VALUES (@GroupName, @GroupID, @ProjectName, @Student1_ID, @Student2_ID, @Student3_ID, @ProjectDescription)";

            //    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlConnection);

            //    insertCmd.Parameters.AddWithValue("@GroupName", groupName);
            //    insertCmd.Parameters.AddWithValue("@GroupID", groupID);
            //    insertCmd.Parameters.AddWithValue("@ProjectName", projectName);
            //    insertCmd.Parameters.AddWithValue("@Student1_ID", student1ID);
            //    insertCmd.Parameters.AddWithValue("@Student2_ID", student2ID);
            //    insertCmd.Parameters.AddWithValue("@Student3_ID", student3ID);
            //    insertCmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);

            //    insertCmd.ExecuteNonQuery();
            //}

         //   this.Hide();
        }




        ////////////////////////////////////////
        private void button_clear_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MEMBERNAME1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MEMBERNAME3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MEMBERNAME2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PROJECTDESCRIPTION_TextChanged(object sender, EventArgs e)
        {

        }

        private void GROUPID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PROJECTNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void GROUPNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Add new group
            string groupName = GROUPNAME.Text;
            string groupID = GROUPID.Text;
            string projectName = PROJECTNAME.Text;
            string projectDescription = PROJECTDESCRIPTION.Text;
            string student1ID = STUDENTID1.Text;
            string student2ID = STUDENTID2.Text;
            string student3ID = STUDENTID3.Text;

            string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                // Check if the provided groupID already exists
                string checkGroupQuery = "SELECT COUNT(*) FROM RegisterGroups WHERE GroupID = @GroupID";
                SqlCommand checkGroupCmd = new SqlCommand(checkGroupQuery, sqlConnection);
                checkGroupCmd.Parameters.AddWithValue("@GroupID", groupID);
                int existingGroupCount = (int)checkGroupCmd.ExecuteScalar();

                // If groupID already exists, prompt the user to enter a different one
                if (existingGroupCount > 0)
                {
                    MessageBox.Show("Group ID already exists. Please enter a different Group ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop further execution
                }

                // Check if any of the provided student IDs already exist (case-insensitive check)
                string checkStudentQuery = "SELECT COUNT(*) FROM RegisterGroups WHERE LOWER(Student1_ID) = LOWER(@Student1_ID) OR LOWER(Student2_ID) = LOWER(@Student2_ID) OR LOWER(Student3_ID) = LOWER(@Student3_ID)";
                SqlCommand checkStudentCmd = new SqlCommand(checkStudentQuery, sqlConnection);
                checkStudentCmd.Parameters.AddWithValue("@Student1_ID", student1ID);
                checkStudentCmd.Parameters.AddWithValue("@Student2_ID", student2ID);
                checkStudentCmd.Parameters.AddWithValue("@Student3_ID", student3ID);
                int existingStudentCount = (int)checkStudentCmd.ExecuteScalar();

                // If any of the student IDs already exist, prompt the user to enter different ones
                if (existingStudentCount > 0)
                {
                    MessageBox.Show("One or more student IDs already exist. Please enter different student IDs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop further execution
                }

                // Proceed with inserting the new group
                string insertQuery = "INSERT INTO RegisterGroups (GroupName, GroupID, ProjectName, Student1_ID, Student2_ID, Student3_ID, ProjectDescription)" +
                                     " VALUES (@GroupName, @GroupID, @ProjectName, @Student1_ID, @Student2_ID, @Student3_ID, @ProjectDescription)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, sqlConnection);

                insertCmd.Parameters.AddWithValue("@GroupName", groupName);
                insertCmd.Parameters.AddWithValue("@GroupID", groupID);
                insertCmd.Parameters.AddWithValue("@ProjectName", projectName);
                insertCmd.Parameters.AddWithValue("@Student1_ID", student1ID);
                insertCmd.Parameters.AddWithValue("@Student2_ID", student2ID);
                insertCmd.Parameters.AddWithValue("@Student3_ID", student3ID);
                insertCmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);

                insertCmd.ExecuteNonQuery();
            }
            this.Hide();
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
