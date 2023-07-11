namespace ManagementSystem
{
    partial class EditRoom
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
            panel8 = new Panel();
            cbRoomType = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            textAddDescription = new TextBox();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel11 = new Panel();
            textAddLocation = new TextBox();
            label11 = new Label();
            panel10 = new Panel();
            textAddName = new TextBox();
            label8 = new Label();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(238, 186, 178);
            panel8.Controls.Add(cbRoomType);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(panel1);
            panel8.Controls.Add(textAddDescription);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(iconButton4);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(textAddLocation);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textAddName);
            panel8.Controls.Add(label8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(744, 407);
            panel8.TabIndex = 4;
            // 
            // cbRoomType
            // 
            cbRoomType.Anchor = AnchorStyles.Top;
            cbRoomType.BackColor = Color.FromArgb(238, 186, 178);
            cbRoomType.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(269, 88);
            cbRoomType.Margin = new Padding(4, 5, 4, 5);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(333, 53);
            cbRoomType.TabIndex = 31;
            cbRoomType.SelectedIndexChanged += cbRoomType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 30;
            label3.Text = "Room Type:";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(245, 243, 231);
            panel1.Location = new Point(269, 283);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 8);
            panel1.TabIndex = 19;
            // 
            // textAddDescription
            // 
            textAddDescription.Anchor = AnchorStyles.Top;
            textAddDescription.BackColor = Color.FromArgb(238, 186, 178);
            textAddDescription.BorderStyle = BorderStyle.None;
            textAddDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textAddDescription.Location = new Point(269, 232);
            textAddDescription.Margin = new Padding(4, 5, 4, 5);
            textAddDescription.Name = "textAddDescription";
            textAddDescription.Size = new Size(334, 38);
            textAddDescription.TabIndex = 18;
            textAddDescription.TextChanged += textAddDescription_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 232);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 17;
            label1.Text = "Room Description:";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top;
            iconButton1.BackColor = Color.FromArgb(238, 186, 178);
            iconButton1.BackgroundImageLayout = ImageLayout.Center;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(93, 325);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(171, 60);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Go Back";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top;
            iconButton4.BackColor = Color.FromArgb(238, 186, 178);
            iconButton4.BackgroundImageLayout = ImageLayout.Center;
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(351, 325);
            iconButton4.Margin = new Padding(4, 5, 4, 5);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(139, 60);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click_1;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top;
            panel11.BackColor = Color.FromArgb(245, 243, 231);
            panel11.Location = new Point(269, 213);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(334, 8);
            panel11.TabIndex = 11;
            panel11.Paint += panel11_Paint;
            // 
            // textAddLocation
            // 
            textAddLocation.Anchor = AnchorStyles.Top;
            textAddLocation.BackColor = Color.FromArgb(238, 186, 178);
            textAddLocation.BorderStyle = BorderStyle.None;
            textAddLocation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textAddLocation.Location = new Point(269, 162);
            textAddLocation.Margin = new Padding(4, 5, 4, 5);
            textAddLocation.Name = "textAddLocation";
            textAddLocation.Size = new Size(334, 38);
            textAddLocation.TabIndex = 10;
            textAddLocation.TextChanged += textAddLocation_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(37, 162);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(183, 32);
            label11.TabIndex = 9;
            label11.Text = "Room Location:";
            label11.Click += label11_Click;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackColor = Color.FromArgb(245, 243, 231);
            panel10.Location = new Point(269, 72);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(334, 8);
            panel10.TabIndex = 8;
            panel10.Paint += panel10_Paint;
            // 
            // textAddName
            // 
            textAddName.Anchor = AnchorStyles.Top;
            textAddName.BackColor = Color.FromArgb(238, 186, 178);
            textAddName.BorderStyle = BorderStyle.None;
            textAddName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textAddName.Location = new Point(269, 20);
            textAddName.Margin = new Padding(4, 5, 4, 5);
            textAddName.Name = "textAddName";
            textAddName.Size = new Size(334, 38);
            textAddName.TabIndex = 7;
            textAddName.TextChanged += textAddName_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(37, 20);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(180, 32);
            label8.TabIndex = 5;
            label8.Text = "Room Number:";
            label8.Click += label8_Click;
            // 
            // EditRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 407);
            Controls.Add(panel8);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditRoom";
            Text = "Form2";
            Load += EditRoom_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel11;
        private TextBox textAddLocation;
        private Label label11;
        private Panel panel10;
        private TextBox textAddName;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private TextBox textAddDescription;
        private Label label1;
        private ComboBox cbRoomType;
        private Label label3;
    }
}