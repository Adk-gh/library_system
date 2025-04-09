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
using Microsoft.EntityFrameworkCore;




namespace library_system
{
    public partial class Members : Form
    {
        public Members()
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

        private void Members_Load(object sender, EventArgs e)
        {

            pictureBox1.ImageLocation = @"C:\Users\HP\source\repos\library_system\library_system\Resources\Studying Back To School GIF by Pudgy Penguins.gif";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
                string query = @"
        SELECT m.MemberID, m.LastName, m.FirstName, m.MiddleInitial, m.MembershipType, m.ContactNumber
        FROM Members m";

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

                        // Optional: Customize column headers
                        dataGridView1.Columns["MemberID"].HeaderText = "Member ID";
                        dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                        dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                        dataGridView1.Columns["MiddleInitial"].HeaderText = "Middle Initial";
                        dataGridView1.Columns["MembershipType"].HeaderText = "Membership Type";
                        dataGridView1.Columns["ContactNumber"].HeaderText = "Contact Number";

                        // Optional: Check if data was found
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No member records found in the database!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member records: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Get the MemberID from the selected row
            int memberID = Convert.ToInt32(selectedRow.Cells["MemberID"].Value);

            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // If the user clicks "Yes", proceed with deletion
            if (result == DialogResult.Yes)
            {
                string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";

                // Query to delete dependent records (example for BorrowingRecords)
                string deleteDependentQuery = "DELETE FROM BorrowingRecords WHERE MemberID = @MemberID";

                // Query to delete the member
                string deleteMemberQuery = "DELETE FROM Members WHERE MemberID = @MemberID";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Start a transaction to ensure both deletes are atomic
                        using (var transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Delete dependent records first
                                MySqlCommand deleteDependentCommand = new MySqlCommand(deleteDependentQuery, connection, transaction);
                                deleteDependentCommand.Parameters.AddWithValue("@MemberID", memberID);
                                deleteDependentCommand.ExecuteNonQuery();

                                // Now delete the member
                                MySqlCommand deleteMemberCommand = new MySqlCommand(deleteMemberQuery, connection, transaction);
                                deleteMemberCommand.Parameters.AddWithValue("@MemberID", memberID);
                                int rowsAffected = deleteMemberCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit(); // Commit the transaction if everything goes well
                                    MessageBox.Show("Member and related records deleted successfully.");
                                    dataGridView1.Rows.Remove(selectedRow);
                                }
                                else
                                {
                                    transaction.Rollback(); // Rollback if something goes wrong
                                    MessageBox.Show("Failed to delete member. Please try again.");
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback(); // Rollback if there is an error
                                MessageBox.Show($"Error: {ex.Message}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                // If the user clicked "No", do nothing
                return;
            }
        }


        /*
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            // Get the selected row (assuming you're selecting by full row in DataGridView)
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Get the MemberID from the selected row (assuming it's the first column)
            int memberID = Convert.ToInt32(selectedRow.Cells["MemberID"].Value); // Adjust column name if necessary

            // Show a confirmation dialog asking if the user is sure they want to delete
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // If the user clicks "Yes", proceed with deletion
            if (result == DialogResult.Yes)
            {
                string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";
                // Query to delete the member from the database
                string deleteQuery = "DELETE FROM Members m WHERE m.MemberID = @MemberID";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Create the command to delete the member from the database
                        MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@MemberID", memberID);

                        // Execute the delete command
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member deleted successfully.");

                            // After deleting from the database, remove the selected row from the DataGridView
                            dataGridView1.Rows.Remove(selectedRow);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete member. Please try again.");
                        }
                    }
                }
                catch (MySqlException mysqlEx)
                {
                    // Catch MySQL specific exceptions for more detailed information
                    MessageBox.Show($"MySQL Error: {mysqlEx.Message}");
                }
                catch (Exception ex)
                {
                    // General exception handling
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                // If the user clicked "No", we simply return and do nothing
                return;
            }
        }
        */


        private void button3_Click(object sender, EventArgs e)
        {

            // Check if any row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to update.");
                return;
            }

            // Get the selected row (assuming you're selecting by full row in DataGridView)
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Get the MemberID from the selected row (assuming it's the first column)
            int memberID = Convert.ToInt32(selectedRow.Cells["MemberID"].Value); // Adjust column name if necessary

            // Get updated values from the DataGridView cells
            string lastName = selectedRow.Cells["LastName"].Value.ToString();
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string middleInitial = selectedRow.Cells["MiddleInitial"].Value.ToString();
            string membershipType = selectedRow.Cells["MembershipType"].Value.ToString();
            string contactNumber = selectedRow.Cells["ContactNumber"].Value.ToString();

            // Show a confirmation dialog asking if the user is sure they want to update
            DialogResult result = MessageBox.Show("Are you sure you want to update this member?",
                                                  "Confirm Update",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);

            // If the user clicks "Yes", proceed with the update
            if (result == DialogResult.Yes)
            {
                string connectionString = "server=127.0.0.1; username=root; database=library; port=3006; password=RootPassword123;";

                // Query to update the member in the database
                string updateQuery = @"
            UPDATE Members
            SET LastName = @LastName,
                FirstName = @FirstName,
                MiddleInitial = @MiddleInitial,
                MembershipType = @MembershipType,
                ContactNumber = @ContactNumber
            WHERE MemberID = @MemberID";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Create the command to update the member in the database
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@LastName", lastName);
                        updateCommand.Parameters.AddWithValue("@FirstName", firstName);
                        updateCommand.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                        updateCommand.Parameters.AddWithValue("@MembershipType", membershipType);
                        updateCommand.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        updateCommand.Parameters.AddWithValue("@MemberID", memberID);

                        // Execute the update command
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member updated successfully.");

                            // After updating the database, update the DataGridView to reflect the changes
                            selectedRow.Cells["LastName"].Value = lastName;
                            selectedRow.Cells["FirstName"].Value = firstName;
                            selectedRow.Cells["MiddleInitial"].Value = middleInitial;
                            selectedRow.Cells["MembershipType"].Value = membershipType;
                            selectedRow.Cells["ContactNumber"].Value = contactNumber;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update member. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


