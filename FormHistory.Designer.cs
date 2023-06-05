namespace ManagementSystem
{
    partial class FormHistory
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
            panel3 = new Panel();
            panel11 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            label4 = new Label();
            lableTotalTent = new Label();
            label1 = new Label();
            lableTotalBed = new Label();
            label3 = new Label();
            lableTotalRoom = new Label();
            panel13 = new Panel();
            panel7 = new Panel();
            textSearchTennant = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            panel4 = new Panel();
            panel8 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 160, 183);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 856);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(11, 13);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1220, 843);
            panel3.TabIndex = 9;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(225, 138, 170);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(33, 402);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1149, 13);
            panel11.TabIndex = 15;
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
            dataGridView2.BackgroundColor = Color.FromArgb(228, 160, 183);
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
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new Point(33, 415);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
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
            dataGridView2.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataGridView2.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView2.RowTemplate.Height = 35;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.ShowCellToolTips = false;
            dataGridView2.ShowEditingIcon = false;
            dataGridView2.ShowRowErrors = false;
            dataGridView2.Size = new Size(1149, 279);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Pink;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(33, 92);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.Pink;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1149, 602);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(225, 138, 170);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(lableTotalTent);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(lableTotalBed);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(lableTotalRoom);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(33, 694);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1149, 149);
            panel6.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(831, 52);
            label4.Name = "label4";
            label4.Size = new Size(251, 46);
            label4.TabIndex = 15;
            label4.Text = "Total Tennants:";
            // 
            // lableTotalTent
            // 
            lableTotalTent.Anchor = AnchorStyles.Top;
            lableTotalTent.AutoSize = true;
            lableTotalTent.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableTotalTent.ForeColor = Color.White;
            lableTotalTent.Location = new Point(1053, 52);
            lableTotalTent.Name = "lableTotalTent";
            lableTotalTent.Size = new Size(58, 46);
            lableTotalTent.TabIndex = 14;
            lableTotalTent.Text = "00";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(455, 52);
            label1.Name = "label1";
            label1.Size = new Size(186, 46);
            label1.TabIndex = 13;
            label1.Text = "Total Beds:";
            label1.Click += label1_Click;
            // 
            // lableTotalBed
            // 
            lableTotalBed.Anchor = AnchorStyles.Top;
            lableTotalBed.AutoSize = true;
            lableTotalBed.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableTotalBed.ForeColor = Color.White;
            lableTotalBed.Location = new Point(619, 52);
            lableTotalBed.Name = "lableTotalBed";
            lableTotalBed.Size = new Size(58, 46);
            lableTotalBed.TabIndex = 12;
            lableTotalBed.Text = "00";
            lableTotalBed.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 52);
            label3.Name = "label3";
            label3.Size = new Size(217, 46);
            label3.TabIndex = 11;
            label3.Text = "Total Rooms:";
            // 
            // lableTotalRoom
            // 
            lableTotalRoom.Anchor = AnchorStyles.Top;
            lableTotalRoom.AutoSize = true;
            lableTotalRoom.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lableTotalRoom.ForeColor = Color.White;
            lableTotalRoom.Location = new Point(206, 52);
            lableTotalRoom.Name = "lableTotalRoom";
            lableTotalRoom.Size = new Size(58, 46);
            lableTotalRoom.TabIndex = 10;
            lableTotalRoom.Text = "00";
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(225, 138, 170);
            panel13.Controls.Add(panel7);
            panel13.Controls.Add(textSearchTennant);
            panel13.Controls.Add(iconButton1);
            panel13.Controls.Add(label12);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(33, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(1149, 92);
            panel13.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(228, 160, 183);
            panel7.Location = new Point(189, 68);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 7);
            panel7.TabIndex = 6;
            // 
            // textSearchTennant
            // 
            textSearchTennant.BackColor = Color.FromArgb(225, 138, 170);
            textSearchTennant.BorderStyle = BorderStyle.None;
            textSearchTennant.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchTennant.Location = new Point(189, 27);
            textSearchTennant.Margin = new Padding(3, 4, 3, 4);
            textSearchTennant.Name = "textSearchTennant";
            textSearchTennant.Size = new Size(267, 36);
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
            iconButton1.Location = new Point(455, 27);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(123, 48);
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
            label12.Location = new Point(7, 27);
            label12.Name = "label12";
            label12.Size = new Size(202, 37);
            label12.TabIndex = 5;
            label12.Text = "Tennant Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 138, 170);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(33, 843);
            panel2.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom;
            panel9.BackColor = Color.FromArgb(225, 138, 170);
            panel9.Location = new Point(496, 1061);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1146, 13);
            panel9.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(225, 138, 170);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1182, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(38, 843);
            panel4.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 13);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(11, 843);
            panel8.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1231, 13);
            panel5.TabIndex = 7;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 856);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHistory";
            Text = "FormHome";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel8;
        private Panel panel3;
        private Panel panel13;
        private Panel panel7;
        private TextBox textSearchTennant;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label12;
        private Panel panel2;
        private Panel panel9;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Panel panel11;
        private Label label4;
        private Label lableTotalTent;
        private Label label1;
        private Label lableTotalBed;
        private Label label3;
        private Label lableTotalRoom;
        private DataGridView dataGridView2;
    }
}