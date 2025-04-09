using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_system
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        //for the last name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //for the first name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //for the M.I.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //for the Membership type
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //for the contact number
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //for the register button
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;username=root;database=library;port=3006;password=RootPassword123;";

            // Create a connection to the database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Open the connection

                    // Prepare the SQL query to insert data
                    string sql = "INSERT INTO Members (LastName, FirstName, MiddleInitial, MembershipType, ContactNumber) VALUES (@LastName, @FirstName, @MiddleInitial, @MembershipType, @ContactNumber)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@LastName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@MiddleInitial", textBox3.Text);
                        cmd.Parameters.AddWithValue("@MembershipType", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ContactNumber", textBox5.Text);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }

                    // Show success message
                    MessageBox.Show("Successfully Registered!");

                    // Clear the textboxes
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    comboBox1.Text = "";
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Teacher");
        }
    }
}
