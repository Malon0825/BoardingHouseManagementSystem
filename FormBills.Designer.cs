namespace ManagementSystem
{
    partial class FormBills
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel10 = new Panel();
            panel6 = new Panel();
            panel14 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            panel20 = new Panel();
            textBox4 = new TextBox();
            panel19 = new Panel();
            textRentBill = new TextBox();
            panel18 = new Panel();
            label15 = new Label();
            labelChange = new Label();
            label13 = new Label();
            panel17 = new Panel();
            textBox2 = new TextBox();
            panel16 = new Panel();
            label11 = new Label();
            panel15 = new Panel();
            textSearchName = new TextBox();
            textTotal = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            labelName = new Label();
            label1 = new Label();
            panel12 = new Panel();
            panel11 = new Panel();
            panel3 = new Panel();
            dataSearchList = new DataGridView();
            panel13 = new Panel();
            panel7 = new Panel();
            textSearchTennant = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            panel1 = new Panel();
            panel9 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel14.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSearchList).BeginInit();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 160, 183);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1045, 630);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(228, 160, 183);
            panel10.Controls.Add(panel6);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(10, 283);
            panel10.Name = "panel10";
            panel10.Size = new Size(1035, 347);
            panel10.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(225, 138, 170);
            panel6.Controls.Add(panel14);
            panel6.Controls.Add(panel12);
            panel6.Controls.Add(panel11);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1035, 347);
            panel6.TabIndex = 8;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(225, 138, 170);
            panel14.Controls.Add(iconButton3);
            panel14.Controls.Add(iconButton2);
            panel14.Controls.Add(comboBox1);
            panel14.Controls.Add(panel20);
            panel14.Controls.Add(textBox4);
            panel14.Controls.Add(panel19);
            panel14.Controls.Add(textRentBill);
            panel14.Controls.Add(panel18);
            panel14.Controls.Add(label15);
            panel14.Controls.Add(labelChange);
            panel14.Controls.Add(label13);
            panel14.Controls.Add(panel17);
            panel14.Controls.Add(textBox2);
            panel14.Controls.Add(panel16);
            panel14.Controls.Add(label11);
            panel14.Controls.Add(panel15);
            panel14.Controls.Add(textSearchName);
            panel14.Controls.Add(textTotal);
            panel14.Controls.Add(label10);
            panel14.Controls.Add(label8);
            panel14.Controls.Add(label6);
            panel14.Controls.Add(label4);
            panel14.Controls.Add(labelName);
            panel14.Controls.Add(label1);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(0, 20);
            panel14.Name = "panel14";
            panel14.Size = new Size(1035, 327);
            panel14.TabIndex = 5;
            panel14.Paint += panel14_Paint;
            // 
            // iconButton3
            // 
            iconButton3.BackgroundImageLayout = ImageLayout.Center;
            iconButton3.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(292, 236);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(99, 36);
            iconButton3.TabIndex = 8;
            iconButton3.Text = "Save";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackgroundImageLayout = ImageLayout.Center;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(810, 179);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(145, 64);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Done";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(225, 138, 170);
            comboBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 38);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(228, 160, 183);
            panel20.Location = new Point(194, 203);
            panel20.Name = "panel20";
            panel20.Size = new Size(110, 5);
            panel20.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(225, 138, 170);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(194, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 29);
            textBox4.TabIndex = 25;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyPress += textBox4_KeyPress;
            textBox4.KeyUp += textBox4_KeyUp;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(228, 160, 183);
            panel19.Location = new Point(194, 161);
            panel19.Name = "panel19";
            panel19.Size = new Size(110, 5);
            panel19.TabIndex = 24;
            // 
            // textRentBill
            // 
            textRentBill.BackColor = Color.FromArgb(225, 138, 170);
            textRentBill.BorderStyle = BorderStyle.None;
            textRentBill.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textRentBill.Location = new Point(194, 130);
            textRentBill.Name = "textRentBill";
            textRentBill.Size = new Size(110, 29);
            textRentBill.TabIndex = 23;
            textRentBill.KeyPress += textRentBill_KeyPress;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(228, 160, 183);
            panel18.Location = new Point(194, 115);
            panel18.Name = "panel18";
            panel18.Size = new Size(110, 5);
            panel18.TabIndex = 22;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(514, 193);
            label15.Name = "label15";
            label15.Size = new Size(117, 37);
            label15.TabIndex = 20;
            label15.Text = "Change:";
            // 
            // labelChange
            // 
            labelChange.Anchor = AnchorStyles.Top;
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelChange.ForeColor = Color.White;
            labelChange.Location = new Point(668, 180);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(0, 54);
            labelChange.TabIndex = 19;
            labelChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(513, 114);
            label13.Name = "label13";
            label13.Size = new Size(83, 37);
            label13.TabIndex = 17;
            label13.Text = "Cash:";
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Top;
            panel17.BackColor = Color.FromArgb(228, 160, 183);
            panel17.Location = new Point(652, 146);
            panel17.Name = "panel17";
            panel17.Size = new Size(333, 5);
            panel17.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = Color.FromArgb(225, 138, 170);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(652, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 36);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.Top;
            panel16.BackColor = Color.FromArgb(228, 160, 183);
            panel16.Location = new Point(38, 216);
            panel16.Name = "panel16";
            panel16.Size = new Size(353, 10);
            panel16.TabIndex = 14;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(513, 37);
            label11.Name = "label11";
            label11.Size = new Size(133, 37);
            label11.TabIndex = 14;
            label11.Text = "Discount:";
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Top;
            panel15.BackColor = Color.FromArgb(228, 160, 183);
            panel15.Location = new Point(652, 75);
            panel15.Name = "panel15";
            panel15.Size = new Size(333, 5);
            panel15.TabIndex = 13;
            // 
            // textSearchName
            // 
            textSearchName.Anchor = AnchorStyles.Top;
            textSearchName.BackColor = Color.FromArgb(225, 138, 170);
            textSearchName.BorderStyle = BorderStyle.None;
            textSearchName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchName.Location = new Point(652, 38);
            textSearchName.Name = "textSearchName";
            textSearchName.Size = new Size(333, 36);
            textSearchName.TabIndex = 12;
            textSearchName.KeyPress += textSearchName_KeyPress;
            // 
            // textTotal
            // 
            textTotal.Anchor = AnchorStyles.Top;
            textTotal.AutoSize = true;
            textTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textTotal.ForeColor = Color.White;
            textTotal.Location = new Point(194, 238);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(0, 32);
            textTotal.TabIndex = 11;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(38, 238);
            label10.Name = "label10";
            label10.Size = new Size(66, 30);
            label10.TabIndex = 10;
            label10.Text = "Total:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(38, 177);
            label8.Name = "label8";
            label8.Size = new Size(121, 30);
            label8.TabIndex = 8;
            label8.Text = "Electric bill";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 130);
            label6.Name = "label6";
            label6.Size = new Size(101, 30);
            label6.TabIndex = 6;
            label6.Text = "Rent Bill:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 84);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 4;
            label4.Text = "Rent Type:";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(194, 37);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 30);
            labelName.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 2;
            label1.Text = "Tenant Name:";
            label1.Click += label1_Click_1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(228, 160, 183);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 10);
            panel12.Name = "panel12";
            panel12.Size = new Size(1035, 10);
            panel12.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(225, 138, 170);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(1035, 10);
            panel11.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Controls.Add(dataSearchList);
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 274);
            panel3.TabIndex = 5;
            // 
            // dataSearchList
            // 
            dataSearchList.AllowUserToResizeColumns = false;
            dataSearchList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            dataSearchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearchList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataSearchList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataSearchList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataSearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataSearchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataSearchList.DefaultCellStyle = dataGridViewCellStyle3;
            dataSearchList.Dock = DockStyle.Fill;
            dataSearchList.GridColor = Color.Black;
            dataSearchList.Location = new Point(29, 69);
            dataSearchList.Name = "dataSearchList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataSearchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataSearchList.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Pink;
            dataSearchList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataSearchList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSearchList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataSearchList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataSearchList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataSearchList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataSearchList.RowTemplate.Height = 25;
            dataSearchList.ScrollBars = ScrollBars.Vertical;
            dataSearchList.ShowCellToolTips = false;
            dataSearchList.ShowEditingIcon = false;
            dataSearchList.ShowRowErrors = false;
            dataSearchList.Size = new Size(980, 205);
            dataSearchList.TabIndex = 12;
            dataSearchList.CellClick += dataSearchList_CellClick;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(225, 138, 170);
            panel13.Controls.Add(panel7);
            panel13.Controls.Add(textSearchTennant);
            panel13.Controls.Add(iconButton1);
            panel13.Controls.Add(label12);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(29, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(980, 69);
            panel13.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(228, 160, 183);
            panel7.Location = new Point(165, 51);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 5);
            panel7.TabIndex = 6;
            // 
            // textSearchTennant
            // 
            textSearchTennant.BackColor = Color.FromArgb(225, 138, 170);
            textSearchTennant.BorderStyle = BorderStyle.None;
            textSearchTennant.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchTennant.Location = new Point(165, 20);
            textSearchTennant.Name = "textSearchTennant";
            textSearchTennant.Size = new Size(234, 29);
            textSearchTennant.TabIndex = 4;
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImageLayout = ImageLayout.Center;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(398, 20);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(108, 36);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Search";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 20);
            label12.Name = "label12";
            label12.Size = new Size(163, 30);
            label12.TabIndex = 5;
            label12.Text = "Tennant Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 138, 170);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(29, 274);
            panel1.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom;
            panel9.BackColor = Color.FromArgb(225, 138, 170);
            panel9.Location = new Point(0, 264);
            panel9.Name = "panel9";
            panel9.Size = new Size(1003, 10);
            panel9.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(225, 138, 170);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1009, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(101, 274);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1035, 10);
            panel5.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 630);
            panel8.TabIndex = 5;
            // 
            // FormBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 630);
            Controls.Add(panel2);
            Name = "FormBills";
            Text = "FormBills";
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataSearchList).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel8;
        private Panel panel10;
        private Panel panel6;
        private Panel panel1;
        private Panel panel9;
        private Panel panel4;
        private Panel panel14;
        private Panel panel12;
        private Panel panel11;
        private Label label1;
        private Label textTotal;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label labelName;
        private Label label11;
        private Panel panel15;
        private TextBox textSearchName;
        private Panel panel13;
        private Label label15;
        private Label labelChange;
        private Label label13;
        private Panel panel17;
        private TextBox textBox2;
        private Panel panel16;
        private Panel panel7;
        private TextBox textSearchTennant;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label12;
        private DataGridView dataSearchList;
        private ComboBox comboBox1;
        private Panel panel20;
        private TextBox textBox4;
        private Panel panel19;
        private TextBox textRentBill;
        private Panel panel18;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}