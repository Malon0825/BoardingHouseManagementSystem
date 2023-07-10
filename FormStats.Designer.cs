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
            panel2 = new Panel();
            panel1 = new Panel();
            lblDate = new Label();
            label2 = new Label();
            iconButton12 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(1033, 465);
            panel13.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(673, 381);
            label4.Name = "label4";
            label4.Size = new Size(197, 37);
            label4.TabIndex = 22;
            label4.Text = "Total Payment:";
            // 
            // lableTotalBill
            // 
            lableTotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lableTotalBill.AutoSize = true;
            lableTotalBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableTotalBill.ForeColor = Color.White;
            lableTotalBill.Location = new Point(893, 381);
            lableTotalBill.Name = "lableTotalBill";
            lableTotalBill.Size = new Size(47, 37);
            lableTotalBill.TabIndex = 21;
            lableTotalBill.Text = "00";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(384, 381);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 20;
            label1.Text = "Rent Total:";
            // 
            // lableRentBill
            // 
            lableRentBill.Anchor = AnchorStyles.Top;
            lableRentBill.AutoSize = true;
            lableRentBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableRentBill.ForeColor = Color.White;
            lableRentBill.Location = new Point(564, 381);
            lableRentBill.Name = "lableRentBill";
            lableRentBill.Size = new Size(47, 37);
            lableRentBill.TabIndex = 19;
            lableRentBill.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 381);
            label3.Name = "label3";
            label3.Size = new Size(178, 37);
            label3.TabIndex = 18;
            label3.Text = "Electric Total:";
            // 
            // lableElectricBill
            // 
            lableElectricBill.AutoSize = true;
            lableElectricBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableElectricBill.ForeColor = Color.White;
            lableElectricBill.Location = new Point(254, 381);
            lableElectricBill.Name = "lableElectricBill";
            lableElectricBill.Size = new Size(47, 37);
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
            dataGridView2.Location = new Point(30, 63);
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
            dataGridView2.Size = new Size(973, 281);
            dataGridView2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1003, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 402);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 138, 170);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 402);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 138, 170);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconButton12);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 63);
            panel1.TabIndex = 13;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(117, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(155, 37);
            lblDate.TabIndex = 20;
            lblDate.Text = "05/01/2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 12);
            label2.Name = "label2";
            label2.Size = new Size(81, 37);
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
            iconButton12.Location = new Point(893, 14);
            iconButton12.Name = "iconButton12";
            iconButton12.Size = new Size(125, 36);
            iconButton12.TabIndex = 10;
            iconButton12.Text = "Forward";
            iconButton12.TextAlign = ContentAlignment.MiddleLeft;
            iconButton12.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton12.UseVisualStyleBackColor = true;
            iconButton12.Click += iconButton12_Click;
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
            iconButton3.Location = new Point(621, 14);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(131, 36);
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
            iconButton1.Location = new Point(758, 14);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(130, 36);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Current";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 465);
            Controls.Add(panel13);
            Name = "FormStats";
            Text = "FormStats";
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel13;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
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