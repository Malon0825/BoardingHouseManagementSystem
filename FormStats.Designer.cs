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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel13 = new Panel();
            label4 = new Label();
            lableTotalBill = new Label();
            label1 = new Label();
            lableRentBill = new Label();
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
            panel13.BackColor = Color.FromArgb(238, 186, 178);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(lableTotalBill);
            panel13.Controls.Add(label1);
            panel13.Controls.Add(lableRentBill);
            panel13.Controls.Add(dataGridView2);
            panel13.Controls.Add(panel3);
            panel13.Controls.Add(panel2);
            panel13.Controls.Add(panel1);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(1476, 775);
            panel13.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(859, 635);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(287, 54);
            label4.TabIndex = 22;
            label4.Text = "Total Payment:";
            // 
            // lableTotalBill
            // 
            lableTotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lableTotalBill.AutoSize = true;
            lableTotalBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableTotalBill.ForeColor = Color.White;
            lableTotalBill.Location = new Point(1174, 635);
            lableTotalBill.Margin = new Padding(4, 0, 4, 0);
            lableTotalBill.Name = "lableTotalBill";
            lableTotalBill.Size = new Size(67, 54);
            lableTotalBill.TabIndex = 21;
            lableTotalBill.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 635);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 54);
            label1.TabIndex = 20;
            label1.Text = "Rent Total:";
            label1.Click += label1_Click;
            // 
            // lableRentBill
            // 
            lableRentBill.AutoSize = true;
            lableRentBill.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableRentBill.ForeColor = Color.White;
            lableRentBill.Location = new Point(424, 635);
            lableRentBill.Margin = new Padding(4, 0, 4, 0);
            lableRentBill.Name = "lableRentBill";
            lableRentBill.Size = new Size(67, 54);
            lableRentBill.TabIndex = 19;
            lableRentBill.Text = "00";
            lableRentBill.Click += lableRentBill_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(245, 243, 231);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Dock = DockStyle.Top;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new Point(43, 105);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Pink;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(245, 243, 231);
            dataGridView2.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 212, 191);
            dataGridView2.RowTemplate.Height = 35;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.ShowCellToolTips = false;
            dataGridView2.ShowEditingIcon = false;
            dataGridView2.ShowRowErrors = false;
            dataGridView2.Size = new Size(1390, 468);
            dataGridView2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(238, 186, 178);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1433, 105);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(43, 670);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 186, 178);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 105);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(43, 670);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 186, 178);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconButton12);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 105);
            panel1.TabIndex = 13;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(167, 20);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(227, 54);
            lblDate.TabIndex = 20;
            lblDate.Text = "05/01/2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 54);
            label2.TabIndex = 19;
            label2.Text = "Date:";
            // 
            // iconButton12
            // 
            iconButton12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton12.BackgroundImageLayout = ImageLayout.Center;
            iconButton12.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton12.FlatAppearance.BorderSize = 0;
            iconButton12.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton12.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton12.FlatStyle = FlatStyle.Flat;
            iconButton12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton12.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconButton12.IconColor = Color.Black;
            iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton12.IconSize = 30;
            iconButton12.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton12.Location = new Point(1276, 23);
            iconButton12.Margin = new Padding(4, 5, 4, 5);
            iconButton12.Name = "iconButton12";
            iconButton12.Size = new Size(179, 60);
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
            iconButton3.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(887, 23);
            iconButton3.Margin = new Padding(4, 5, 4, 5);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(187, 60);
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
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(1083, 23);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(186, 60);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Current";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 775);
            Controls.Add(panel13);
            Margin = new Padding(4, 5, 4, 5);
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
        private FontAwesome.Sharp.IconButton iconButton12;
        private Label lblDate;
        private Label label2;
    }
}