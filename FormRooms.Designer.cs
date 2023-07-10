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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel7 = new Panel();
            panel12 = new Panel();
            labelGender = new Label();
            label5 = new Label();
            lalebTennantName = new Label();
            label2 = new Label();
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
            panel9 = new Panel();
            dataSearchList = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            panelEdit = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            textSearchName = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel12.SuspendLayout();
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
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1460, 1050);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(225, 138, 170);
            panel7.Controls.Add(panel12);
            panel7.Controls.Add(dataTennantsList);
            panel7.Controls.Add(dataBedsList);
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(827, 17);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(633, 1033);
            panel7.TabIndex = 8;
            // 
            // panel12
            // 
            panel12.Controls.Add(labelGender);
            panel12.Controls.Add(label5);
            panel12.Controls.Add(lalebTennantName);
            panel12.Controls.Add(label2);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(33, 846);
            panel12.Margin = new Padding(4, 5, 4, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(567, 187);
            panel12.TabIndex = 16;
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top;
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelGender.ForeColor = Color.White;
            labelGender.Location = new Point(140, 98);
            labelGender.Margin = new Padding(4, 0, 4, 0);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(100, 45);
            labelGender.TabIndex = 9;
            labelGender.Text = "None";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(8, 98);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 45);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            // 
            // lalebTennantName
            // 
            lalebTennantName.Anchor = AnchorStyles.Top;
            lalebTennantName.AutoSize = true;
            lalebTennantName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lalebTennantName.ForeColor = Color.White;
            lalebTennantName.Location = new Point(140, 29);
            lalebTennantName.Margin = new Padding(4, 0, 4, 0);
            lalebTennantName.Name = "lalebTennantName";
            lalebTennantName.Size = new Size(100, 45);
            lalebTennantName.TabIndex = 7;
            lalebTennantName.Text = "None";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(4, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 45);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // dataTennantsList
            // 
            dataTennantsList.AllowUserToAddRows = false;
            dataTennantsList.AllowUserToDeleteRows = false;
            dataTennantsList.AllowUserToResizeColumns = false;
            dataTennantsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.Pink;
            dataTennantsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataTennantsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTennantsList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataTennantsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataTennantsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.ControlText;
            dataTennantsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataTennantsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dataTennantsList.DefaultCellStyle = dataGridViewCellStyle18;
            dataTennantsList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataTennantsList.GridColor = Color.Black;
            dataTennantsList.Location = new Point(33, 1410);
            dataTennantsList.Margin = new Padding(4, 5, 4, 5);
            dataTennantsList.Name = "dataTennantsList";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataTennantsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataTennantsList.RowHeadersVisible = false;
            dataTennantsList.RowHeadersWidth = 62;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = Color.Pink;
            dataTennantsList.RowsDefaultCellStyle = dataGridViewCellStyle20;
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
            dataTennantsList.Size = new Size(567, 0);
            dataTennantsList.TabIndex = 17;
            // 
            // dataBedsList
            // 
            dataBedsList.AllowUserToAddRows = false;
            dataBedsList.AllowUserToDeleteRows = false;
            dataBedsList.AllowUserToResizeColumns = false;
            dataBedsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = Color.Pink;
            dataBedsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataBedsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataBedsList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataBedsList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataBedsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataBedsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.ControlText;
            dataBedsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dataBedsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dataBedsList.DefaultCellStyle = dataGridViewCellStyle23;
            dataBedsList.Dock = DockStyle.Fill;
            dataBedsList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataBedsList.GridColor = Color.Black;
            dataBedsList.Location = new Point(33, 187);
            dataBedsList.Margin = new Padding(4, 5, 4, 5);
            dataBedsList.Name = "dataBedsList";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataBedsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataBedsList.RowHeadersVisible = false;
            dataBedsList.RowHeadersWidth = 62;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle25.ForeColor = Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = Color.Pink;
            dataBedsList.RowsDefaultCellStyle = dataGridViewCellStyle25;
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
            dataBedsList.Size = new Size(567, 846);
            dataBedsList.TabIndex = 16;
            dataBedsList.CellClick += dataBedsList_CellClick;
            // 
            // panel11
            // 
            panel11.Controls.Add(labelRoomName);
            panel11.Controls.Add(buttonDescription);
            panel11.Controls.Add(buttonLocation);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(33, 0);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(567, 187);
            panel11.TabIndex = 15;
            // 
            // labelRoomName
            // 
            labelRoomName.Anchor = AnchorStyles.Top;
            labelRoomName.AutoSize = true;
            labelRoomName.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoomName.ForeColor = Color.White;
            labelRoomName.Location = new Point(140, 8);
            labelRoomName.Margin = new Padding(4, 0, 4, 0);
            labelRoomName.Name = "labelRoomName";
            labelRoomName.Size = new Size(290, 54);
            labelRoomName.TabIndex = 6;
            labelRoomName.Text = "Room Number";
            // 
            // buttonDescription
            // 
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
            buttonDescription.Location = new Point(64, 108);
            buttonDescription.Margin = new Padding(4, 5, 4, 5);
            buttonDescription.Name = "buttonDescription";
            buttonDescription.Size = new Size(239, 80);
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
            buttonLocation.Location = new Point(311, 108);
            buttonLocation.Margin = new Padding(4, 5, 4, 5);
            buttonLocation.Name = "buttonLocation";
            buttonLocation.Size = new Size(171, 80);
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
            panel10.Location = new Point(600, 0);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(33, 1033);
            panel10.TabIndex = 14;
            panel10.Paint += panel10_Paint;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(33, 1033);
            panel8.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(228, 160, 183);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(803, 17);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(24, 1033);
            panel6.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(dataSearchList);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panelEdit);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(textSearchName);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(14, 17);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(789, 1033);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(228, 160, 183);
            panel9.Location = new Point(0, 382);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(1659, 17);
            panel9.TabIndex = 4;
            // 
            // dataSearchList
            // 
            dataSearchList.AllowUserToAddRows = false;
            dataSearchList.AllowUserToDeleteRows = false;
            dataSearchList.AllowUserToResizeColumns = false;
            dataSearchList.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle26.ForeColor = Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = Color.Pink;
            dataSearchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            dataSearchList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearchList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataSearchList.BackgroundColor = Color.FromArgb(228, 160, 183);
            dataSearchList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataSearchList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle27.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.ControlText;
            dataSearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataSearchList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
            dataSearchList.DefaultCellStyle = dataGridViewCellStyle28;
            dataSearchList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataSearchList.GridColor = Color.Black;
            dataSearchList.Location = new Point(26, 148);
            dataSearchList.Margin = new Padding(4, 5, 4, 5);
            dataSearchList.Name = "dataSearchList";
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataSearchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataSearchList.RowHeadersVisible = false;
            dataSearchList.RowHeadersWidth = 62;
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = Color.Pink;
            dataSearchList.RowsDefaultCellStyle = dataGridViewCellStyle30;
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
            dataSearchList.Size = new Size(733, 223);
            dataSearchList.TabIndex = 7;
            dataSearchList.CellClick += dataSearchList_CellClick;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(299, 8);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(144, 54);
            label9.TabIndex = 6;
            label9.Text = "Search";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(349, 403);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 48);
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
            panelEdit.Location = new Point(0, 447);
            panelEdit.Margin = new Padding(4, 5, 4, 5);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(906, 750);
            panelEdit.TabIndex = 3;
            // 
            // iconButton5
            // 
            iconButton5.Anchor = AnchorStyles.Top;
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
            iconButton5.Location = new Point(544, 83);
            iconButton5.Margin = new Padding(4, 5, 4, 5);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(166, 90);
            iconButton5.TabIndex = 16;
            iconButton5.Text = "Delete";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top;
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
            iconButton4.Location = new Point(100, 83);
            iconButton4.Margin = new Padding(4, 5, 4, 5);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(127, 90);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top;
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
            iconButton2.Location = new Point(299, 83);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(181, 90);
            iconButton2.TabIndex = 7;
            iconButton2.Text = "Update";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.FromArgb(228, 160, 183);
            panel2.Location = new Point(267, 125);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 13);
            panel2.TabIndex = 2;
            // 
            // textSearchName
            // 
            textSearchName.Anchor = AnchorStyles.Top;
            textSearchName.BackColor = Color.FromArgb(225, 138, 170);
            textSearchName.BorderStyle = BorderStyle.None;
            textSearchName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchName.Location = new Point(267, 67);
            textSearchName.Margin = new Padding(4, 5, 4, 5);
            textSearchName.Name = "textSearchName";
            textSearchName.Size = new Size(359, 43);
            textSearchName.TabIndex = 0;
            textSearchName.TextChanged += textBox1_TextChanged;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top;
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
            iconButton1.Location = new Point(634, 47);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(231, 90);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Search";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 45);
            label1.TabIndex = 1;
            label1.Text = "Room Number:";
            label1.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(228, 160, 183);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(14, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1446, 17);
            panel5.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(228, 160, 183);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 1050);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 1050);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRooms";
            Text = "FormRooms";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
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
        private Panel panel12;
        private Label label2;
        private Label labelGender;
        private Label label5;
        private Label lalebTennantName;
    }
}