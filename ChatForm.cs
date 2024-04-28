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
    public partial class ChatForm : Form
    {
        // Connection string for your database
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        // Store the IDs of the student and supervisor
        private string loggedInStudentID;
        private string loggedInSupervisorID;

        public ChatForm(string studentID, string supervisorID)
        {
            InitializeComponent();
            loggedInStudentID = studentID; // Assign the parameter to the class variable
            loggedInSupervisorID = supervisorID; // Assign the parameter to the class variable

            // Load messages from the database when the form loads
            LoadMessages();
        }

        // Method to load messages from the database
        private void LoadMessages()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, SupervisorID, Message, Timestamp FROM ChatMessages ORDER BY Timestamp DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Message", typeof(string)); // Add message column
                    while (reader.Read())
                    {
                        string studentID = reader["StudentID"].ToString();
                        string supervisorID = reader["SupervisorID"].ToString();
                        string message = reader["Message"].ToString();

                        // Format message with StudentID and SupervisorID
                        string formattedMessage = "";
                        if (!string.IsNullOrEmpty(studentID))
                        {
                            formattedMessage += $"{studentID}: ";
                        }
                        if (!string.IsNullOrEmpty(supervisorID))
                        {
                            formattedMessage += $"{supervisorID}: ";
                        }
                        formattedMessage += message;

                        dt.Rows.Add(formattedMessage); // Add formatted message to DataTable
                    }
                    chatdataGridView1.DataSource = dt;
                    // Auto-resize the column to fit the content
                    chatdataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading messages: " + ex.Message);
            }
        }

        
        private void InsertMessage(string message)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ChatMessages (StudentID, SupervisorID, Message) VALUES (@StudentID, @SupervisorID, @Message)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Pass either student ID or supervisor ID based on the logged-in user
                    if (!string.IsNullOrEmpty(loggedInStudentID))
                    {
                        command.Parameters.AddWithValue("@StudentID", loggedInStudentID);
                        command.Parameters.AddWithValue("@SupervisorID", DBNull.Value); // Set SupervisorID to NULL
                    }
                    else if (!string.IsNullOrEmpty(loggedInSupervisorID))
                    {
                        command.Parameters.AddWithValue("@SupervisorID", loggedInSupervisorID);
                        command.Parameters.AddWithValue("@StudentID", DBNull.Value); // Set StudentID to NULL
                       // command.Parameters.AddWithValue("@SupervisorID", loggedInSupervisorID);
                    }
                    else
                    {
                        // Neither student nor supervisor is logged in, handle this case accordingly
                        return;
                    }

                    command.Parameters.AddWithValue("@Message", message);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting message: " + ex.Message);
            }
        }



        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void msgbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chatdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a message cell
            if (e.ColumnIndex == chatdataGridView1.Columns["Message"].Index && e.RowIndex >= 0)
            {
                // Retrieve the message from the clicked cell
                string message = chatdataGridView1.Rows[e.RowIndex].Cells["Message"].Value.ToString();

                // Perform any action with the clicked message
                MessageBox.Show(message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string message = msgbox.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                InsertMessage(message);
                LoadMessages(); // Refresh messages after sending
                msgbox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a message.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}


