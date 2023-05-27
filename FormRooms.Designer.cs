namespace ManagementSystem
{
    partial class FormRooms
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel7 = new Panel();
            dataTennantsList = new DataGridView();
            dataBedsList = new DataGridView();
            panel11 = new Panel();
            labelRoomName = new Label();
            buttonDescription = new FontAwesome.Sharp.IconButton();
            buttonLocation = new FontAwesome.Sharp.IconButton();
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
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            panel2 = new Panel();
            textSearchName = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTennantsList).BeginInit();
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
            panel1.Size = new Size(1066, 627);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(225, 138, 170);
            panel7.Controls.Add(dataTennantsList);
            panel7.Controls.Add(dataBedsList);
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(538, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(528, 617);
            panel7.TabIndex = 8;
            // 
            // dataTennantsList
            // 
            dataTennantsList.AllowUserToAddRows = false;
            dataTennantsList.AllowUserToDeleteRows = false;
            dataTennantsList.AllowUserToResizeColumns = false;
            dataTennantsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            dataTennantsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataTennantsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTennantsList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataTennantsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataTennantsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataTennantsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataTennantsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataTennantsList.DefaultCellStyle = dataGridViewCellStyle3;
            dataTennantsList.Dock = DockStyle.Fill;
            dataTennantsList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataTennantsList.GridColor = Color.Black;
            dataTennantsList.Location = new Point(10, 450);
            dataTennantsList.Name = "dataTennantsList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataTennantsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataTennantsList.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Pink;
            dataTennantsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataTennantsList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataTennantsList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataTennantsList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataTennantsList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataTennantsList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataTennantsList.RowTemplate.Height = 35;
            dataTennantsList.ScrollBars = ScrollBars.Vertical;
            dataTennantsList.ShowCellToolTips = false;
            dataTennantsList.ShowEditingIcon = false;
            dataTennantsList.ShowRowErrors = false;
            dataTennantsList.Size = new Size(508, 167);
            dataTennantsList.TabIndex = 17;
            // 
            // dataBedsList
            // 
            dataBedsList.AllowUserToAddRows = false;
            dataBedsList.AllowUserToDeleteRows = false;
            dataBedsList.AllowUserToResizeColumns = false;
            dataBedsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Pink;
            dataBedsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataBedsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataBedsList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataBedsList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataBedsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataBedsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataBedsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataBedsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataBedsList.DefaultCellStyle = dataGridViewCellStyle8;
            dataBedsList.Dock = DockStyle.Top;
            dataBedsList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataBedsList.GridColor = Color.Black;
            dataBedsList.Location = new Point(10, 95);
            dataBedsList.Name = "dataBedsList";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataBedsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataBedsList.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.Pink;
            dataBedsList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataBedsList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataBedsList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataBedsList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataBedsList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataBedsList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataBedsList.RowTemplate.Height = 35;
            dataBedsList.ScrollBars = ScrollBars.Vertical;
            dataBedsList.ShowCellToolTips = false;
            dataBedsList.ShowEditingIcon = false;
            dataBedsList.ShowRowErrors = false;
            dataBedsList.Size = new Size(508, 355);
            dataBedsList.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.Controls.Add(labelRoomName);
            panel11.Controls.Add(buttonDescription);
            panel11.Controls.Add(buttonLocation);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(10, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(508, 95);
            panel11.TabIndex = 15;
            // 
            // labelRoomName
            // 
            labelRoomName.Anchor = AnchorStyles.Top;
            labelRoomName.AutoSize = true;
            labelRoomName.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoomName.ForeColor = Color.White;
            labelRoomName.Location = new Point(155, 3);
            labelRoomName.Name = "labelRoomName";
            labelRoomName.Size = new Size(197, 37);
            labelRoomName.TabIndex = 6;
            labelRoomName.Text = "Room Number";
            // 
            // buttonDescription
            // 
            buttonDescription.Anchor = AnchorStyles.Top;
            buttonDescription.BackgroundImageLayout = ImageLayout.Center;
            buttonDescription.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            buttonDescription.FlatAppearance.BorderSize = 0;
            buttonDescription.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            buttonDescription.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            buttonDescription.FlatStyle = FlatStyle.Flat;
            buttonDescription.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDescription.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            buttonDescription.IconColor = Color.Black;
            buttonDescription.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonDescription.IconSize = 25;
            buttonDescription.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDescription.Location = new Point(108, 43);
            buttonDescription.Name = "buttonDescription";
            buttonDescription.Size = new Size(149, 32);
            buttonDescription.TabIndex = 9;
            buttonDescription.Text = "Description";
            buttonDescription.TextAlign = ContentAlignment.MiddleLeft;
            buttonDescription.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDescription.UseVisualStyleBackColor = true;
            buttonDescription.Click += buttonDescription_Click_1;
            // 
            // buttonLocation
            // 
            buttonLocation.Anchor = AnchorStyles.Top;
            buttonLocation.BackgroundImageLayout = ImageLayout.Center;
            buttonLocation.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            buttonLocation.FlatAppearance.BorderSize = 0;
            buttonLocation.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            buttonLocation.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            buttonLocation.FlatStyle = FlatStyle.Flat;
            buttonLocation.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLocation.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            buttonLocation.IconColor = Color.Black;
            buttonLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonLocation.IconSize = 25;
            buttonLocation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLocation.Location = new Point(263, 43);
            buttonLocation.Name = "buttonLocation";
            buttonLocation.Size = new Size(118, 32);
            buttonLocation.TabIndex = 10;
            buttonLocation.Text = "Location";
            buttonLocation.TextAlign = ContentAlignment.MiddleLeft;
            buttonLocation.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLocation.UseVisualStyleBackColor = true;
            buttonLocation.Click += buttonLocation_Click_1;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(518, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 617);
            panel10.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 617);
            panel8.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(528, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 617);
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
            panel3.Size = new Size(518, 617);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
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
            dataSearchList.AllowUserToAddRows = false;
            dataSearchList.AllowUserToDeleteRows = false;
            dataSearchList.AllowUserToResizeColumns = false;
            dataSearchList.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.Pink;
            dataSearchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearchList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataSearchList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataSearchList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataSearchList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.ControlText;
            dataSearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataSearchList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataSearchList.DefaultCellStyle = dataGridViewCellStyle13;
            dataSearchList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataSearchList.GridColor = Color.Black;
            dataSearchList.Location = new Point(12, 137);
            dataSearchList.Name = "dataSearchList";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataSearchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataSearchList.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.Pink;
            dataSearchList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataSearchList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSearchList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(228, 160, 183);
            dataSearchList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataSearchList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataSearchList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataSearchList.RowTemplate.Height = 35;
            dataSearchList.RowTemplate.Resizable = DataGridViewTriState.True;
            dataSearchList.ScrollBars = ScrollBars.Vertical;
            dataSearchList.ShowCellToolTips = false;
            dataSearchList.ShowEditingIcon = false;
            dataSearchList.ShowRowErrors = false;
            dataSearchList.Size = new Size(488, 153);
            dataSearchList.TabIndex = 7;
            dataSearchList.CellClick += dataSearchList_CellClick;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(214, 3);
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
            label10.Location = new Point(225, 319);
            label10.Name = "label10";
            label10.Size = new Size(64, 37);
            label10.TabIndex = 7;
            label10.Text = "Edit";
            label10.Click += label10_Click;
            // 
            // panelEdit
            // 
            panelEdit.BackColor = Color.FromArgb(225, 138, 170);
            panelEdit.Controls.Add(iconButton5);
            panelEdit.Controls.Add(iconButton4);
            panelEdit.Controls.Add(iconButton2);
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
            iconButton5.Location = new Point(354, 105);
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
            iconButton4.Location = new Point(45, 105);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(97, 36);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackgroundImageLayout = ImageLayout.Center;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(186, 105);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(125, 36);
            iconButton2.TabIndex = 7;
            iconButton2.Text = "Update";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(228, 160, 183);
            panel9.Location = new Point(0, 306);
            panel9.Name = "panel9";
            panel9.Size = new Size(522, 10);
            panel9.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 160, 183);
            panel2.Location = new Point(172, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 5);
            panel2.TabIndex = 2;
            // 
            // textSearchName
            // 
            textSearchName.BackColor = Color.FromArgb(225, 138, 170);
            textSearchName.BorderStyle = BorderStyle.None;
            textSearchName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchName.Location = new Point(172, 51);
            textSearchName.Name = "textSearchName";
            textSearchName.Size = new Size(234, 29);
            textSearchName.TabIndex = 0;
            textSearchName.TextChanged += textBox1_TextChanged;
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
            iconButton1.Location = new Point(405, 51);
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
            label1.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1056, 10);
            panel5.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 627);
            panel4.TabIndex = 5;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // FormRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 627);
            Controls.Add(panel1);
            Name = "FormRooms";
            Text = "FormRooms";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataTennantsList).EndInit();
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
        private Label label1;
        private TextBox textSearchName;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panelEdit;
        private Panel panel9;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridView dataSearchList;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label10;
        private Panel panel8;
        private Panel panel11;
        private Label labelRoomName;
        private FontAwesome.Sharp.IconButton buttonDescription;
        private FontAwesome.Sharp.IconButton buttonLocation;
        private Panel panel10;
        private DataGridView dataBedsList;
        private DataGridView dataTennantsList;
    }
}