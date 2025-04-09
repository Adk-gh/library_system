using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace library_system
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadTitles();
            LoadMembers();
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



        //for the member name
        private void cmbToLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbToLocation.SelectedIndex != -1)
            {
                string selectedMember = cmbToLocation.SelectedItem.ToString();

                // You can retrieve additional information about the selected member (e.g., contact info, membership type)
                // Update UI or perform logic here based on the selected member.
            }
        }



        


        

        // Method to load titles into the combo box when the form loads or on demand
        private void LoadTitles()
        {
            string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
            string query = "SELECT Title FROM Books"; // Query to get the titles of the books

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cmbTitle.Items.Clear(); // Clear previous items in the combo box

                            while (reader.Read())
                            {
                                // Add each title to the combo box
                                cmbTitle.Items.Add(reader["Title"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading titles: {ex.Message}");
            }
        }




        

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedItem == null) return;

            string selectedTitle = cmbTitle.SelectedItem.ToString();
            LoadBookDetails(selectedTitle);
        }
        private void LoadBookDetails(string selectedTitle)
        {
            string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
            string query = @"
    SELECT b.ISBN, b.Title, 
    CONCAT(a.AuthorFname, ' ', a.AuthorMinitial, '. ', a.AuthorLname) AS 'Author Full Name', 
    b.Genre, b.PublicationYear
    FROM Books b
    INNER JOIN Authors a ON b.AuthorID = a.AuthorID
    WHERE b.Title = @Title";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", selectedTitle);

                        // Execute the query and load the data into a DataTable
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader); // Load data from the reader into the DataTable

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dt;

                            // Optional: Check if data was found
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No details found for the selected title.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book details: {ex.Message}");
            }
        }

        /*
        private void LoadBookDetails(string selectedTitle)
        {
            string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
            string query = @"
    SELECT b.ISBN, b.Title, a.AuthorFname, a.AuthorLname, b.Genre, b.PublicationYear
    FROM Books b
    INNER JOIN Authors a ON b.AuthorID = a.AuthorID
    WHERE b.Title = @Title";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", selectedTitle);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear any existing data in DataGridView
                            dataGridView1.Rows.Clear();

                            if (reader.Read())
                            {
                                // Add the book details to the DataGridView
                                dataGridView1.Rows.Add(
                                    reader["ISBN"].ToString(),
                                    reader["Title"].ToString(),
                                    reader["AuthorFname"].ToString() + " " + reader["AuthorLname"].ToString(),
                                    reader["Genre"].ToString(),
                                    reader["PublicationYear"].ToString()
                                );
                            }
                            else
                            {
                                MessageBox.Show("No details found for the selected title.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book details: {ex.Message}");
            }
        }
        */



        // Method to load members into the combo box with FirstName, LastName, and MiddleInitial merged
        private void LoadMembers()
        {
            string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
            // Query to concatenate FirstName, LastName, and MiddleInitial
            string query = @"
    SELECT MemberID, CONCAT(LastName, ' ', FirstName, ' ', IFNULL(MiddleInitial, '')) AS FullName
    FROM Members"; // Concatenate FirstName, MiddleInitial (if not null), and LastName

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cmbToLocation.Items.Clear(); // Clear previous items in the combo box

                            while (reader.Read())
                            {
                                // Get the concatenated full name
                                string fullName = reader["FullName"].ToString();
                                // Optionally, store the MemberID alongside the FullName (e.g., for later use)
                                cmbToLocation.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}");
            }
        }




        //for date borrowed
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime borrowedDate = dateTimePicker1.Value;

            // Automatically calculate the Due Date (2 months later)
            DateTime dueDate = borrowedDate.AddMonths(2);

            // Set the Due Date in the Due Date picker (dateTimePicker2)
            dateTimePicker2.Value = dueDate;
        }
        //for due date to be set automatically 2 months after the date borrowed
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home newHome = new Home();
            newHome.Show();
        }

        private void btnPlaceBooking_Click(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedItem == null)
            {
                MessageBox.Show("Please select a title first.");
                return;
            }

            // Get the selected title from the combo box
            string selectedTitle = cmbTitle.SelectedItem.ToString();

            // Load book details based on the selected title
            LoadBookDetails(selectedTitle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Check if a book is selected and a member is selected
            if (cmbTitle.SelectedItem == null || cmbToLocation.SelectedItem == null)
            {
                MessageBox.Show("Please select both a book and a member.");
                return;
            }

            string selectedTitle = cmbTitle.SelectedItem.ToString().Trim();
            string selectedMember = cmbToLocation.SelectedItem.ToString().Trim(); // Trim spaces from selected member

            // Debugging: Show the selected member to check if it matches the expected format
            MessageBox.Show($"Selected Member: '{selectedMember}'"); // Show with quotes to visualize extra spaces

            // Fetch book information
            string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
            string bookQuery = @"SELECT BookID
                                FROM Books
                                WHERE Title = @Title";

            // Fetch member information, now using LastName, FirstName, MiddleInitial format
            string memberQuery = @" SELECT MemberID
                                    FROM Members
                                    WHERE CONCAT(LastName, ' ', FirstName, ' ', IFNULL(MiddleInitial, '')) = @MemberName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Get the book details (BookID)
                    MySqlCommand bookCommand = new MySqlCommand(bookQuery, connection);
                    bookCommand.Parameters.AddWithValue("@Title", selectedTitle);
                    MySqlDataReader bookReader = bookCommand.ExecuteReader();

                    // Move to the first row and then access the BookID
                    if (bookReader.Read())  // Make sure Read() is called before accessing the data
                    {
                        int bookID = Convert.ToInt32(bookReader["BookID"]);
                        bookReader.Close();

                        // Get the member details (MemberID)
                        MySqlCommand memberCommand = new MySqlCommand(memberQuery, connection);
                        memberCommand.Parameters.AddWithValue("@MemberName", selectedMember);
                        MySqlDataReader memberReader = memberCommand.ExecuteReader();

                        // Move to the first row and then access the MemberID
                        if (memberReader.Read())  // Make sure Read() is called before accessing the data
                        {
                            int memberID = Convert.ToInt32(memberReader["MemberID"]);
                            memberReader.Close();

                            // Get the Borrowed Date and Due Date from the DatePickers
                            DateTime borrowedDate = dateTimePicker1.Value;
                            DateTime dueDate = dateTimePicker2.Value;

                            // Prepare the insert query for BorrowingRecords
                            string insertQuery = @"
                    INSERT INTO BorrowingRecords (MemberID, BookID, BorrowedDate, DueDate)
                    VALUES (@MemberID, @BookID, @BorrowedDate, @DueDate)";

                            // Execute the insert query to save the borrowing record
                            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@MemberID", memberID);
                            insertCommand.Parameters.AddWithValue("@BookID", bookID);
                            insertCommand.Parameters.AddWithValue("@BorrowedDate", borrowedDate);
                            insertCommand.Parameters.AddWithValue("@DueDate", dueDate);

                            // Execute the command
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Borrowing record saved successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to save borrowing record.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Member not found. Check the format of the member name.");
                            memberReader.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                        bookReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
          
        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedItem == null)
            {
                MessageBox.Show("Please select a title first.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
         "Are you sure you got everything right?",
         "Confirm Selection",
         MessageBoxButtons.YesNo
     );

            if (dialogResult == DialogResult.No)
            {
                return; // Exit the method if the user clicks 'No'
            }

            // Get the selected title from the combo box
            string selectedTitle = cmbTitle.SelectedItem.ToString();

            // Load book details based on the selected title
            LoadBookDetails(selectedTitle);
        }

        private void cmbTitle_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}

