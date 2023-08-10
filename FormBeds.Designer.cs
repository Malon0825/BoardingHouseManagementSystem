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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            panel9 = new Panel();
            dataSearchList = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            panelEdit = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            textSearchName = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSearchList).BeginInit();
            panelEdit.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 160, 183);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 826);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(238, 186, 178);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(dataSearchList);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panelEdit);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(textSearchName);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(11, 14);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1189, 812);
            panel3.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.FromArgb(245, 243, 231);
            panel9.Location = new Point(0, 300);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1197, 14);
            panel9.TabIndex = 4;
            // 
            // dataSearchList
            // 
            dataSearchList.AllowUserToAddRows = false;
            dataSearchList.AllowUserToDeleteRows = false;
            dataSearchList.AllowUserToResizeColumns = false;
            dataSearchList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Pink;
            dataSearchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataSearchList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearchList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataSearchList.BackgroundColor = Color.FromArgb(245, 243, 231);
            dataSearchList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataSearchList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataSearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataSearchList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataSearchList.DefaultCellStyle = dataGridViewCellStyle8;
            dataSearchList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataSearchList.GridColor = Color.Black;
            dataSearchList.Location = new Point(14, 126);
            dataSearchList.Margin = new Padding(3, 4, 3, 4);
            dataSearchList.Name = "dataSearchList";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataSearchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataSearchList.RowHeadersVisible = false;
            dataSearchList.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.Pink;
            dataSearchList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataSearchList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSearchList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(245, 243, 231);
            dataSearchList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataSearchList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataSearchList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 212, 191);
            dataSearchList.RowTemplate.Height = 35;
            dataSearchList.RowTemplate.Resizable = DataGridViewTriState.True;
            dataSearchList.ScrollBars = ScrollBars.Vertical;
            dataSearchList.ShowCellToolTips = false;
            dataSearchList.ShowEditingIcon = false;
            dataSearchList.ShowRowErrors = false;
            dataSearchList.Size = new Size(1156, 166);
            dataSearchList.TabIndex = 9;
            dataSearchList.CellClick += dataSearchList_CellClick_1;
            dataSearchList.CellContentClick += dataSearchList_CellContentClick_1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(530, 4);
            label9.Name = "label9";
            label9.Size = new Size(124, 46);
            label9.TabIndex = 6;
            label9.Text = "Search";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(554, 318);
            label10.Name = "label10";
            label10.Size = new Size(71, 41);
            label10.TabIndex = 7;
            label10.Text = "Edit";
            label10.Click += label10_Click;
            // 
            // panelEdit
            // 
            panelEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEdit.BackColor = Color.FromArgb(238, 186, 178);
            panelEdit.Controls.Add(iconButton5);
            panelEdit.Controls.Add(iconButton4);
            panelEdit.Location = new Point(0, 360);
            panelEdit.Margin = new Padding(3, 4, 3, 4);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(1189, 453);
            panelEdit.TabIndex = 3;
            panelEdit.Paint += panelEdit_Paint;
            // 
            // iconButton5
            // 
            iconButton5.BackgroundImageLayout = ImageLayout.Center;
            iconButton5.FlatAppearance.BorderColor = Color.FromArgb(231, 203, 169);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 203, 169);
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(615, 190);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(128, 48);
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
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(231, 203, 169);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 203, 169);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(463, 190);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(111, 48);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 243, 231);
            panel2.Location = new Point(217, 109);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 6);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // textSearchName
            // 
            textSearchName.BackColor = Color.FromArgb(238, 186, 178);
            textSearchName.BorderStyle = BorderStyle.None;
            textSearchName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchName.Location = new Point(217, 67);
            textSearchName.Margin = new Padding(3, 4, 3, 4);
            textSearchName.Name = "textSearchName";
            textSearchName.Size = new Size(267, 36);
            textSearchName.TabIndex = 0;
            textSearchName.TextChanged += textSearchName_TextChanged;
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImageLayout = ImageLayout.Center;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(231, 203, 169);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 203, 169);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(484, 67);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(144, 48);
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
            label1.Location = new Point(14, 68);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 1;
            label1.Text = "Bed Name:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(245, 243, 231);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(11, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1189, 14);
            panel5.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 243, 231);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 826);
            panel4.TabIndex = 5;
            // 
            // FormBeds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 826);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBeds";
            Text = "FormBeds";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSearchList).EndInit();
            panelEdit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
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
        private DataGridView dataSearchList;
    }
}