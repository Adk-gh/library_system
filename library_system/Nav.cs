using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace library_system
{
    public partial class Nav : Form
    {
      
        public Nav()
        {
            InitializeComponent();
        }

        private void Nav_Load(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = @"C:\Users\HP\source\repos\library_system\library_system\Resources\School Studying GIF by Pudgy Penguins.gif";
            pictureBox1.ImageLocation = @"C:\Users\HP\source\repos\library_system\library_system\Resources\School Learn GIF by Pudgy Penguins (1).gif";
            pictureBox4.ImageLocation = @"C:\Users\HP\source\repos\library_system\library_system\Resources\Studying Back To School GIF by Pudgy Penguins.gif";
            pictureBox3.ImageLocation = @"C:\Users\HP\source\repos\library_system\library_system\Resources\School Read GIF by Pudgy Penguins.gif";

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Return returnBook = new Return();
            returnBook.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to return to the Home Page?", "Return Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks "Yes"
            if (result == DialogResult.Yes)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
    }
}
