using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliverable_1
{
    public partial class StudentsProfileForm : Form
    {
        // Define the connection string
        string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

        public StudentsProfileForm()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Define the SQL query
                    string query = "SELECT * FROM Students";

                    // Create a SqlDataAdapter and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelbutton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void PrintDataGridView()
        {
            // Set the font and color for printing
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Create a PrintDocument
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                // Define the printing area
                float x = 10, y = 10;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Draw the cell content with specified font and color
                        ev.Graphics.DrawString(cell.Value.ToString(), font, brush, x, y);
                        x += cell.Size.Width + 5; // Add some padding
                    }
                    y += row.Height; // Move to the next row
                    x = 10; // Reset x position for next row
                }
            };

            // Display print dialog and print
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDataGridView();
        }
    

    

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
