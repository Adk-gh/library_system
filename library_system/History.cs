using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace library_system
{


    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to return to the main menu?", "Return to Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks "Yes"
            if (result == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();
                Nav newForm = new Nav();

                newForm.Show();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\HP\source\repos\library_system\library_system\Resources\School Read GIF by Pudgy Penguins.gif";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
                string query = @"
                SELECT 
                b.BookID, 
                b.ISBN, 
                b.Title, 
                CONCAT(a.AuthorLname, ' ', a.AuthorFname, '. ', a.AuthorMinitial) AS 'Author Full Name', 
                CONCAT( m.LastName, ' ', m.FirstName, ' ', m.MiddleInitial) AS 'Member Full Name',
                m.MemberID, 
                br.BorrowedDate, 
                br.ReturnDate, 
                br.DueDate,
                CASE 
                    WHEN br.ReturnDate IS NULL THEN ''
                    WHEN br.ReturnDate > br.DueDate THEN 'Late' 
                    ELSE 'On Time' 
                END AS 'Status'
                FROM BorrowingRecords br
                INNER JOIN Members m ON br.MemberID = m.MemberID
                INNER JOIN Books b ON br.BookID = b.BookID
                INNER JOIN Authors a ON b.AuthorID = a.AuthorID";
                ;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader); // Load data from the reader into a DataTable

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;

                        // Optional: Check if data was found
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No borrowing records found in the database!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowing records: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
