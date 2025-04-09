namespace library_system
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1308, 12);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 93;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSalmon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.IBeam;
            dataGridView1.Location = new Point(203, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(908, 451);
            dataGridView1.TabIndex = 94;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 50F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(72, 96);
            label1.Name = "label1";
            label1.Size = new Size(105, 94);
            label1.TabIndex = 95;
            label1.Text = "H";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 50F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(87, 168);
            label2.Name = "label2";
            label2.Size = new Size(72, 94);
            label2.TabIndex = 96;
            label2.Text = "I";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 50F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(79, 239);
            label3.Name = "label3";
            label3.Size = new Size(89, 94);
            label3.TabIndex = 97;
            label3.Text = "S";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold", 50F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(80, 311);
            label4.Name = "label4";
            label4.Size = new Size(87, 94);
            label4.TabIndex = 98;
            label4.Text = "T";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans Ultra Bold", 50F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(75, 382);
            label5.Name = "label5";
            label5.Size = new Size(97, 94);
            label5.TabIndex = 99;
            label5.Text = "O";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans Ultra Bold", 50F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(74, 458);
            label6.Name = "label6";
            label6.Size = new Size(100, 94);
            label6.TabIndex = 100;
            label6.Text = "R";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gill Sans Ultra Bold", 50F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(74, 528);
            label7.Name = "label7";
            label7.Size = new Size(101, 94);
            label7.TabIndex = 101;
            label7.Text = "Y";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(1071, 468);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 237);
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Salmon;
            pictureBox2.Location = new Point(1087, 458);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 233);
            pictureBox2.TabIndex = 103;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1350, 729);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}