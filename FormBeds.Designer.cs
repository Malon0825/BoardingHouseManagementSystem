namespace ManagementSystem
{
    partial class FormBeds
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            lalebTennantName = new Label();
            dataBedsList = new DataGridView();
            panel11 = new Panel();
            labelBedName = new Label();
            panel10 = new Panel();
            panel8 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            dataSearchList = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            panelEdit = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            panel2 = new Panel();
            textSearchName = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBedsList).BeginInit();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSearchList).BeginInit();
            panelEdit.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 160, 183);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 620);
            panel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(225, 138, 170);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(lalebTennantName);
            panel7.Controls.Add(dataBedsList);
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(535, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(515, 610);
            panel7.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 493);
            label3.Name = "label3";
            label3.Size = new Size(202, 37);
            label3.TabIndex = 9;
            label3.Text = "Tennant Name:";
            label3.Click += label3_Click;
            // 
            // lalebTennantName
            // 
            lalebTennantName.AutoSize = true;
            lalebTennantName.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lalebTennantName.ForeColor = Color.White;
            lalebTennantName.Location = new Point(208, 493);
            lalebTennantName.Name = "lalebTennantName";
            lalebTennantName.Size = new Size(84, 37);
            lalebTennantName.TabIndex = 10;
            lalebTennantName.Text = "None";
            // 
            // dataBedsList
            // 
            dataBedsList.AllowUserToResizeColumns = false;
            dataBedsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            dataBedsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataBedsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataBedsList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataBedsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataBedsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataBedsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataBedsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataBedsList.DefaultCellStyle = dataGridViewCellStyle3;
            dataBedsList.Dock = DockStyle.Top;
            dataBedsList.GridColor = Color.Black;
            dataBedsList.Location = new Point(10, 95);
            dataBedsList.Name = "dataBedsList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataBedsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataBedsList.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Pink;
            dataBedsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataBedsList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataBedsList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataBedsList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataBedsList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataBedsList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataBedsList.RowTemplate.Height = 25;
            dataBedsList.ScrollBars = ScrollBars.Vertical;
            dataBedsList.ShowCellToolTips = false;
            dataBedsList.ShowEditingIcon = false;
            dataBedsList.ShowRowErrors = false;
            dataBedsList.Size = new Size(495, 356);
            dataBedsList.TabIndex = 9;
            dataBedsList.CellClick += dataBedsList_CellClick;
            // 
            // panel11
            // 
            panel11.Controls.Add(labelBedName);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(10, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(495, 95);
            panel11.TabIndex = 7;
            // 
            // labelBedName
            // 
            labelBedName.Anchor = AnchorStyles.Top;
            labelBedName.AutoSize = true;
            labelBedName.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelBedName.ForeColor = Color.White;
            labelBedName.Location = new Point(189, 26);
            labelBedName.Name = "labelBedName";
            labelBedName.Size = new Size(124, 37);
            labelBedName.TabIndex = 6;
            labelBedName.Text = "Beds List";
            labelBedName.Click += labelBedName_Click;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(505, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 610);
            panel10.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 610);
            panel8.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(525, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 610);
            panel6.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(dataSearchList);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panelEdit);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(textSearchName);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 610);
            panel3.TabIndex = 5;
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
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(12, 95);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(132, 36);
            iconButton3.TabIndex = 8;
            iconButton3.Text = "Load All";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // dataSearchList
            // 
            dataSearchList.AllowUserToResizeColumns = false;
            dataSearchList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Pink;
            dataSearchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearchList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataSearchList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataSearchList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataSearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataSearchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataSearchList.DefaultCellStyle = dataGridViewCellStyle8;
            dataSearchList.GridColor = Color.Black;
            dataSearchList.Location = new Point(12, 137);
            dataSearchList.Name = "dataSearchList";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataSearchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataSearchList.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.Pink;
            dataSearchList.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
            dataSearchList.Size = new Size(488, 153);
            dataSearchList.TabIndex = 7;
            dataSearchList.CellClick += dataSearchList_CellClick;
            dataSearchList.CellContentClick += dataSearchList_CellContentClick;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(201, 3);
            label9.Name = "label9";
            label9.Size = new Size(99, 37);
            label9.TabIndex = 6;
            label9.Text = "Search";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(212, 319);
            label10.Name = "label10";
            label10.Size = new Size(64, 37);
            label10.TabIndex = 7;
            label10.Text = "Edit";
            // 
            // panelEdit
            // 
            panelEdit.BackColor = Color.FromArgb(225, 138, 170);
            panelEdit.Controls.Add(iconButton5);
            panelEdit.Controls.Add(iconButton4);
            panelEdit.Location = new Point(0, 353);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(515, 264);
            panelEdit.TabIndex = 3;
            // 
            // iconButton5
            // 
            iconButton5.BackgroundImageLayout = ImageLayout.Center;
            iconButton5.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(267, 105);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(112, 36);
            iconButton5.TabIndex = 16;
            iconButton5.Text = "Delete";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackgroundImageLayout = ImageLayout.Center;
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(134, 105);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(97, 36);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(228, 160, 183);
            panel9.Location = new Point(0, 306);
            panel9.Name = "panel9";
            panel9.Size = new Size(515, 10);
            panel9.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 160, 183);
            panel2.Location = new Point(170, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 5);
            panel2.TabIndex = 2;
            // 
            // textSearchName
            // 
            textSearchName.BackColor = Color.FromArgb(225, 138, 170);
            textSearchName.BorderStyle = BorderStyle.None;
            textSearchName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchName.Location = new Point(170, 51);
            textSearchName.Name = "textSearchName";
            textSearchName.Size = new Size(234, 29);
            textSearchName.TabIndex = 0;
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
            iconButton1.Location = new Point(403, 51);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(108, 36);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Search";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(165, 30);
            label1.TabIndex = 1;
            label1.Text = "Room Number:";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1040, 10);
            panel5.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 620);
            panel4.TabIndex = 5;
            // 
            // FormBeds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 620);
            Controls.Add(panel1);
            Name = "FormBeds";
            Text = "FormBeds";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBedsList).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSearchList).EndInit();
            panelEdit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private Panel panel3;
        private Panel panel7;
        private Label labelBedName;
        private FontAwesome.Sharp.IconButton iconButton3;
        private DataGridView dataSearchList;
        private Label label9;
        private Label label10;
        private Panel panelEdit;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel9;
        private Panel panel2;
        private TextBox textSearchName;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel11;
        private Panel panel10;
        private Panel panel8;
        private DataGridView dataBedsList;
        private Label label3;
        private Label lalebTennantName;
    }
}