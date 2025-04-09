namespace library_system
{
    partial class Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow));
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            cmbToLocation = new ComboBox();
            cmbTitle = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button2.TabIndex = 92;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(251, 467);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 91;
            label2.Text = "Due Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(224, 396);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 90;
            label1.Text = "Borrow Date:";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1110, 642);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(173, 37);
            button1.TabIndex = 87;
            button1.Text = "Not a Member";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(203, 272);
            label6.Name = "label6";
            label6.Size = new Size(158, 28);
            label6.TabIndex = 85;
            label6.Text = "Member Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(238, 176);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 84;
            label5.Text = "Select Book:";
            // 
            // cmbToLocation
            // 
            cmbToLocation.DropDownHeight = 212;
            cmbToLocation.Font = new Font("Segoe UI", 15F);
            cmbToLocation.FormattingEnabled = true;
            cmbToLocation.IntegralHeight = false;
            cmbToLocation.Location = new Point(376, 269);
            cmbToLocation.Margin = new Padding(3, 2, 3, 2);
            cmbToLocation.Name = "cmbToLocation";
            cmbToLocation.Size = new Size(342, 36);
            cmbToLocation.Sorted = true;
            cmbToLocation.TabIndex = 83;
            cmbToLocation.SelectedIndexChanged += cmbToLocation_SelectedIndexChanged;
            // 
            // cmbTitle
            // 
            cmbTitle.BackColor = SystemColors.Window;
            cmbTitle.DropDownHeight = 300;
            cmbTitle.Font = new Font("Segoe UI", 15F);
            cmbTitle.FormattingEnabled = true;
            cmbTitle.IntegralHeight = false;
            cmbTitle.ItemHeight = 28;
            cmbTitle.Location = new Point(376, 173);
            cmbTitle.Margin = new Padding(3, 2, 3, 2);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(342, 36);
            cmbTitle.Sorted = true;
            cmbTitle.TabIndex = 82;
            cmbTitle.SelectedIndexChanged += cmbTitle_SelectedIndexChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 15F);
            dateTimePicker1.Font = new Font("Segoe UI", 15F);
            dateTimePicker1.Location = new Point(376, 396);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 34);
            dateTimePicker1.TabIndex = 96;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 15F);
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Font = new Font("Segoe UI", 15F);
            dateTimePicker2.Location = new Point(376, 461);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(319, 34);
            dateTimePicker2.TabIndex = 97;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSalmon;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(848, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 322);
            dataGridView1.TabIndex = 98;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.PeachPuff;
            button3.Font = new Font("Segoe UI", 15F);
            button3.ForeColor = Color.SaddleBrown;
            button3.Location = new Point(545, 643);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(173, 36);
            button3.TabIndex = 99;
            button3.Text = "Borrow Book";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PeachPuff;
            button4.Font = new Font("Segoe UI", 15F);
            button4.ForeColor = Color.SaddleBrown;
            button4.Location = new Point(1110, 427);
            button4.Name = "button4";
            button4.Size = new Size(173, 36);
            button4.TabIndex = 100;
            button4.Text = "Confirm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 50F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 412);
            label3.Name = "label3";
            label3.Size = new Size(122, 94);
            label3.TabIndex = 107;
            label3.Text = "W";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold", 50F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(36, 336);
            label4.Name = "label4";
            label4.Size = new Size(97, 94);
            label4.TabIndex = 106;
            label4.Text = "O";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans Ultra Bold", 50F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(34, 265);
            label8.Name = "label8";
            label8.Size = new Size(100, 94);
            label8.TabIndex = 105;
            label8.Text = "R";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gill Sans Ultra Bold", 50F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(34, 193);
            label9.Name = "label9";
            label9.Size = new Size(100, 94);
            label9.TabIndex = 104;
            label9.Text = "R";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gill Sans Ultra Bold", 50F);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(36, 122);
            label10.Name = "label10";
            label10.Size = new Size(97, 94);
            label10.TabIndex = 103;
            label10.Text = "O";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gill Sans Ultra Bold", 50F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(35, 50);
            label11.Name = "label11";
            label11.Size = new Size(99, 94);
            label11.TabIndex = 102;
            label11.Text = "B";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Gill Sans Ultra Bold", 50F);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(132, 597);
            label13.Name = "label13";
            label13.Size = new Size(89, 94);
            label13.TabIndex = 142;
            label13.Text = "S";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Gill Sans Ultra Bold", 50F);
            label20.ForeColor = SystemColors.ControlDarkDark;
            label20.Location = new Point(124, 522);
            label20.Name = "label20";
            label20.Size = new Size(104, 94);
            label20.TabIndex = 141;
            label20.Text = "K";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Gill Sans Ultra Bold", 50F);
            label21.ForeColor = SystemColors.ControlDarkDark;
            label21.Location = new Point(128, 450);
            label21.Name = "label21";
            label21.Size = new Size(97, 94);
            label21.TabIndex = 140;
            label21.Text = "O";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Gill Sans Ultra Bold", 50F);
            label22.ForeColor = SystemColors.ControlDarkDark;
            label22.Location = new Point(128, 379);
            label22.Name = "label22";
            label22.Size = new Size(97, 94);
            label22.TabIndex = 139;
            label22.Text = "O";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Gill Sans Ultra Bold", 50F);
            label23.ForeColor = SystemColors.ControlDarkDark;
            label23.Location = new Point(127, 307);
            label23.Name = "label23";
            label23.Size = new Size(99, 94);
            label23.TabIndex = 138;
            label23.Text = "B";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Gill Sans Ultra Bold", 50F);
            label25.ForeColor = SystemColors.ControlDarkDark;
            label25.Location = new Point(132, 605);
            label25.Name = "label25";
            label25.Size = new Size(88, 94);
            label25.TabIndex = 137;
            label25.Text = "E";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Gill Sans Ultra Bold", 50F);
            label26.ForeColor = SystemColors.ControlDarkDark;
            label26.Location = new Point(127, 534);
            label26.Name = "label26";
            label26.Size = new Size(99, 94);
            label26.TabIndex = 136;
            label26.Text = "B";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Gill Sans Ultra Bold", 50F);
            label27.ForeColor = SystemColors.ControlDarkDark;
            label27.Location = new Point(121, 462);
            label27.Name = "label27";
            label27.Size = new Size(110, 94);
            label27.TabIndex = 135;
            label27.Text = "M";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Gill Sans Ultra Bold", 50F);
            label28.ForeColor = SystemColors.ControlDarkDark;
            label28.Location = new Point(132, 391);
            label28.Name = "label28";
            label28.Size = new Size(88, 94);
            label28.TabIndex = 134;
            label28.Text = "E";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Gill Sans Ultra Bold", 50F);
            label29.ForeColor = SystemColors.ControlDarkDark;
            label29.Location = new Point(121, 319);
            label29.Name = "label29";
            label29.Size = new Size(110, 94);
            label29.TabIndex = 133;
            label29.Text = "M";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Salmon;
            pictureBox2.Location = new Point(861, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(447, 325);
            pictureBox2.TabIndex = 143;
            pictureBox2.TabStop = false;
            // 
            // Borrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1350, 729);
            Controls.Add(label13);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbToLocation);
            Controls.Add(cmbTitle);
            Controls.Add(pictureBox2);
            Name = "Borrow";
            Text = "Borrow";
            Load += Borrow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label6;
        private Label label5;
        private ComboBox cmbToLocation;
        private ComboBox cmbTitle;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private PictureBox pictureBox2;
    }
}