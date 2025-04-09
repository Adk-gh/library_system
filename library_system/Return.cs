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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library_system
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
            LoadMembers();
            LoadTitles();
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

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbToLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

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



        private void ClearAllComboBoxes()
        {
            // Clear the selected items from all combo boxes
            cmbTitle.SelectedItem = null;
            cmbToLocation.SelectedItem = null;


            // Clear the items from all combo boxes (optional, if you want to clear the item list too)
            cmbTitle.Items.Clear();
            cmbToLocation.Items.Clear();

        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home newHome = new Home();
            newHome.Show();
        }

        private void btnPlaceBooking_Click(object sender, EventArgs e)
        {

            // Check if both book and member are selected
            if (cmbTitle.SelectedItem == null || cmbToLocation.SelectedItem == null)
            {
                MessageBox.Show("Please select both a book and a member.");
                return;
            }

            string selectedTitle = cmbTitle.SelectedItem.ToString().Trim();  // Get the selected book title
            string selectedMember = cmbToLocation.SelectedItem.ToString().Trim();  // Get the selected member name

            // Fetch the BookID based on the selected book title
            string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
            string bookQuery = @"
        SELECT BookID
        FROM Books
        WHERE Title = @Title";

            // Fetch the MemberID based on the selected member name
            string memberQuery = @"
        SELECT MemberID
        FROM Members
        WHERE CONCAT(LastName, ' ', FirstName, ' ', IFNULL(MiddleInitial, '')) = @MemberName";

            // Query to update the ReturnDate in BorrowingRecords table
            string updateReturnDateQuery = @"
        UPDATE BorrowingRecords
        SET ReturnDate = @ReturnDate
        WHERE BookID = @BookID AND MemberID = @MemberID AND ReturnDate IS NULL";  // Ensure we only update records that are not already returned

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Get the BookID based on selected title
                    MySqlCommand bookCommand = new MySqlCommand(bookQuery, connection);
                    bookCommand.Parameters.AddWithValue("@Title", selectedTitle);
                    MySqlDataReader bookReader = bookCommand.ExecuteReader();

                    // Check if book exists
                    if (bookReader.Read())
                    {
                        int bookID = Convert.ToInt32(bookReader["BookID"]);
                        bookReader.Close();

                        // Get the MemberID based on selected member name
                        MySqlCommand memberCommand = new MySqlCommand(memberQuery, connection);
                        memberCommand.Parameters.AddWithValue("@MemberName", selectedMember);
                        MySqlDataReader memberReader = memberCommand.ExecuteReader();

                        // Check if member exists
                        if (memberReader.Read())
                        {
                            int memberID = Convert.ToInt32(memberReader["MemberID"]);
                            memberReader.Close();

                            // Get the ReturnDate from the DateTimePicker (or any other UI element you have for this)
                            DateTime returnDate = dateTimePicker3.Value;

                            // Now, update the ReturnDate in the BorrowingRecords table
                            MySqlCommand updateCommand = new MySqlCommand(updateReturnDateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@ReturnDate", returnDate);
                            updateCommand.Parameters.AddWithValue("@BookID", bookID);
                            updateCommand.Parameters.AddWithValue("@MemberID", memberID);

                            // Execute the update command
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Return date updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No matching borrowing record found or the record is already returned.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Member not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Return_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\HP\source\repos\library_system\library_system\Resources\School Studying GIF by Pudgy Penguins.gif";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

