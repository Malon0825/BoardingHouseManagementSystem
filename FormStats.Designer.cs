namespace ManagementSystem
{
    partial class FormStats
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel13 = new Panel();
            label4 = new Label();
            lableTotalBill = new Label();
            label1 = new Label();
            lableRentBill = new Label();
            label3 = new Label();
            lableElectricBill = new Label();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblDate = new Label();
            label2 = new Label();
            iconButton12 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(225, 138, 170);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(lableTotalBill);
            panel13.Controls.Add(label1);
            panel13.Controls.Add(lableRentBill);
            panel13.Controls.Add(label3);
            panel13.Controls.Add(lableElectricBill);
            panel13.Controls.Add(dataGridView2);
            panel13.Controls.Add(panel3);
            panel13.Controls.Add(panel2);
            panel13.Controls.Add(panel1);
            panel13.Controls.Add(iconButton2);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(1181, 620);
            panel13.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(769, 508);
            label4.Name = "label4";
            label4.Size = new Size(246, 46);
            label4.TabIndex = 22;
            label4.Text = "Total Payment:";
            // 
            // lableTotalBill
            // 
            lableTotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lableTotalBill.AutoSize = true;
            lableTotalBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableTotalBill.ForeColor = Color.White;
            lableTotalBill.Location = new Point(1021, 508);
            lableTotalBill.Name = "lableTotalBill";
            lableTotalBill.Size = new Size(58, 46);
            lableTotalBill.TabIndex = 21;
            lableTotalBill.Text = "00";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(439, 508);
            label1.Name = "label1";
            label1.Size = new Size(182, 46);
            label1.TabIndex = 20;
            label1.Text = "Rent Total:";
            // 
            // lableRentBill
            // 
            lableRentBill.Anchor = AnchorStyles.Top;
            lableRentBill.AutoSize = true;
            lableRentBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableRentBill.ForeColor = Color.White;
            lableRentBill.Location = new Point(645, 508);
            lableRentBill.Name = "lableRentBill";
            lableRentBill.Size = new Size(58, 46);
            lableRentBill.TabIndex = 19;
            lableRentBill.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 508);
            label3.Name = "label3";
            label3.Size = new Size(223, 46);
            label3.TabIndex = 18;
            label3.Text = "Electric Total:";
            // 
            // lableElectricBill
            // 
            lableElectricBill.AutoSize = true;
            lableElectricBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableElectricBill.ForeColor = Color.White;
            lableElectricBill.Location = new Point(290, 508);
            lableElectricBill.Name = "lableElectricBill";
            lableElectricBill.Size = new Size(58, 46);
            lableElectricBill.TabIndex = 17;
            lableElectricBill.Text = "00";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Pink;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.Dock = DockStyle.Top;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new Point(34, 84);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.Pink;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataGridView2.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView2.RowTemplate.Height = 35;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.ShowCellToolTips = false;
            dataGridView2.ShowEditingIcon = false;
            dataGridView2.ShowRowErrors = false;
            dataGridView2.Size = new Size(1113, 375);
            dataGridView2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Controls.Add(iconButton7);
            panel3.Controls.Add(iconButton10);
            panel3.Controls.Add(iconButton11);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1147, 84);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(34, 536);
            panel3.TabIndex = 15;
            // 
            // iconButton7
            // 
            iconButton7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton7.BackgroundImageLayout = ImageLayout.Center;
            iconButton7.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton7.IconColor = Color.Black;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 30;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(1975, 27);
            iconButton7.Margin = new Padding(3, 4, 3, 4);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(49, 48);
            iconButton7.TabIndex = 8;
            iconButton7.TextAlign = ContentAlignment.MiddleLeft;
            iconButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton10
            // 
            iconButton10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton10.BackgroundImageLayout = ImageLayout.Center;
            iconButton10.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton10.FlatAppearance.BorderSize = 0;
            iconButton10.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton10.IconColor = Color.Black;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 30;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(378, 16);
            iconButton10.Margin = new Padding(3, 4, 3, 4);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(134, 48);
            iconButton10.TabIndex = 7;
            iconButton10.Text = "Current";
            iconButton10.TextAlign = ContentAlignment.MiddleLeft;
            iconButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton10.UseVisualStyleBackColor = true;
            // 
            // iconButton11
            // 
            iconButton11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton11.BackgroundImageLayout = ImageLayout.Center;
            iconButton11.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton11.FlatAppearance.BorderSize = 0;
            iconButton11.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton11.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton11.FlatStyle = FlatStyle.Flat;
            iconButton11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton11.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton11.IconColor = Color.Black;
            iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton11.IconSize = 30;
            iconButton11.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton11.Location = new Point(974, 16);
            iconButton11.Margin = new Padding(3, 4, 3, 4);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(134, 48);
            iconButton11.TabIndex = 7;
            iconButton11.Text = "Current";
            iconButton11.TextAlign = ContentAlignment.MiddleLeft;
            iconButton11.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton11.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 138, 170);
            panel2.Controls.Add(iconButton4);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(iconButton9);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 84);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(34, 536);
            panel2.TabIndex = 14;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton4.BackgroundImageLayout = ImageLayout.Center;
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(2169, 27);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(49, 48);
            iconButton4.TabIndex = 8;
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            iconButton8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton8.BackgroundImageLayout = ImageLayout.Center;
            iconButton8.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 30;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(573, 16);
            iconButton8.Margin = new Padding(3, 4, 3, 4);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(134, 48);
            iconButton8.TabIndex = 7;
            iconButton8.Text = "Current";
            iconButton8.TextAlign = ContentAlignment.MiddleLeft;
            iconButton8.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton9
            // 
            iconButton9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton9.BackgroundImageLayout = ImageLayout.Center;
            iconButton9.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton9.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton9.IconColor = Color.Black;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.IconSize = 30;
            iconButton9.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton9.Location = new Point(1168, 16);
            iconButton9.Margin = new Padding(3, 4, 3, 4);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(134, 48);
            iconButton9.TabIndex = 7;
            iconButton9.Text = "Current";
            iconButton9.TextAlign = ContentAlignment.MiddleLeft;
            iconButton9.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton9.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 138, 170);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconButton12);
            panel1.Controls.Add(iconButton5);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(iconButton6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 84);
            panel1.TabIndex = 13;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(134, 16);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(195, 46);
            lblDate.TabIndex = 20;
            lblDate.Text = "05/01/2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(100, 46);
            label2.TabIndex = 19;
            label2.Text = "Date:";
            // 
            // iconButton12
            // 
            iconButton12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton12.BackgroundImageLayout = ImageLayout.Center;
            iconButton12.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton12.FlatAppearance.BorderSize = 0;
            iconButton12.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton12.FlatStyle = FlatStyle.Flat;
            iconButton12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton12.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconButton12.IconColor = Color.Black;
            iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton12.IconSize = 30;
            iconButton12.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton12.Location = new Point(1021, 18);
            iconButton12.Margin = new Padding(3, 4, 3, 4);
            iconButton12.Name = "iconButton12";
            iconButton12.Size = new Size(143, 48);
            iconButton12.TabIndex = 10;
            iconButton12.Text = "Forward";
            iconButton12.TextAlign = ContentAlignment.MiddleLeft;
            iconButton12.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton12.UseVisualStyleBackColor = true;
            iconButton12.Click += iconButton12_Click;
            // 
            // iconButton5
            // 
            iconButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton5.BackgroundImageLayout = ImageLayout.Center;
            iconButton5.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(2630, 27);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(49, 48);
            iconButton5.TabIndex = 8;
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton3.BackgroundImageLayout = ImageLayout.Center;
            iconButton3.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(710, 18);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(150, 48);
            iconButton3.TabIndex = 9;
            iconButton3.Text = "Previous";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackgroundImageLayout = ImageLayout.Center;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(866, 18);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(149, 48);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Current";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton6
            // 
            iconButton6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton6.BackgroundImageLayout = ImageLayout.Center;
            iconButton6.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(1629, 16);
            iconButton6.Margin = new Padding(3, 4, 3, 4);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(134, 48);
            iconButton6.TabIndex = 7;
            iconButton6.Text = "Current";
            iconButton6.TextAlign = ContentAlignment.MiddleLeft;
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.BackgroundImageLayout = ImageLayout.Center;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(2035, 27);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(49, 48);
            iconButton2.TabIndex = 8;
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 620);
            Controls.Add(panel13);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStats";
            Text = "FormStats";
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel13;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton11;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton9;
        private DataGridView dataGridView2;
        private Label label4;
        private Label lableTotalBill;
        private Label label1;
        private Label lableRentBill;
        private Label label3;
        private Label lableElectricBill;
        private FontAwesome.Sharp.IconButton iconButton12;
        private Label lblDate;
        private Label label2;
    }
}