using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace deliverable_1
{
    public partial class ScheduleMeeting : Form
    {
        public ScheduleMeeting()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {



            //// Retrieve scheduling details
            //string GroupID = GROUPID.Text;
            //DateTime MeetingDate = dateTimePicker1.Value;
            //DateTime MeetingTime = dateTimePicker2.Value;
            //string MeetingAgenda = MEETINGAGENDA.Text;

            //// Connection string for your database
            //string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

            //// SQL query to insert scheduling details into the database
            //string query = "INSERT INTO ScheduleMeeting (GroupID, MeetingDate, MeetingTime, MeetingAgenda) VALUES (@GroupID, @MeetingDate, @MeetingTime, @MeetingAgenda)";

            //// Establish connection and execute the query
            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();
            //    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            //    {
            //        // Add parameters to the query
            //        cmd.Parameters.AddWithValue("@GroupID", GroupID);
            //        cmd.Parameters.AddWithValue("@MeetingDate", MeetingDate);
            //        cmd.Parameters.AddWithValue("@MeetingTime", MeetingTime);
            //        cmd.Parameters.AddWithValue("@MeetingAgenda", MeetingAgenda);

            //        // Execute the query
            //        cmd.ExecuteNonQuery();
            //    }
            //}

            //// Optionally hide the form 
            //this.Hide();

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void button_schedule1_Click(object sender, EventArgs e)
        {



            // Retrieve scheduling details
            string GroupID = GROUPID.Text;
            DateTime MeetingDate = dateTimePicker1.Value;
            DateTime MeetingTime = dateTimePicker2.Value;
            string MeetingAgenda = MEETINGAGENDA.Text;

            // Connection string for your database
            string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

            // SQL query to insert scheduling details into the database
            string query = "INSERT INTO ScheduleMeeting (GroupID, MeetingDate, MeetingTime, MeetingAgenda) VALUES (@GroupID, @MeetingDate, @MeetingTime, @MeetingAgenda)";

            // Establish connection and execute the query
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@GroupID", GroupID);
                    cmd.Parameters.AddWithValue("@MeetingDate", MeetingDate);
                    cmd.Parameters.AddWithValue("@MeetingTime", MeetingTime);
                    cmd.Parameters.AddWithValue("@MeetingAgenda", MeetingAgenda);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }

            // Optionally hide the form 
            this.Hide();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

