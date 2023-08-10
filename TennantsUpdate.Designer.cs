namespace ManagementSystem
{
    partial class TennantsUpdate
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
            label8 = new Label();
            textTennantName = new TextBox();
            panel10 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label2 = new Label();
            cbRoomName = new ComboBox();
            cbBedName = new ComboBox();
            panel8 = new Panel();
            panel2 = new Panel();
            depositTextBox = new TextBox();
            label4 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            textTennantID = new TextBox();
            label1 = new Label();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(39, 57);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 5;
            label8.Text = "Name:";
            // 
            // textTennantName
            // 
            textTennantName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTennantName.BackColor = Color.FromArgb(238, 186, 178);
            textTennantName.BorderStyle = BorderStyle.None;
            textTennantName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textTennantName.Location = new Point(119, 57);
            textTennantName.Name = "textTennantName";
            textTennantName.Size = new Size(357, 25);
            textTennantName.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.FromArgb(245, 243, 231);
            panel10.Location = new Point(119, 88);
            panel10.Name = "panel10";
            panel10.Size = new Size(357, 5);
            panel10.TabIndex = 8;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            iconButton1.Location = new Point(119, 236);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(120, 36);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Go Back";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 144);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 23;
            label3.Text = "Room:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 186);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 26;
            label2.Text = "Bed:";
            label2.Click += label2_Click;
            // 
            // cbRoomName
            // 
            cbRoomName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbRoomName.BackColor = Color.FromArgb(238, 186, 178);
            cbRoomName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoomName.FormattingEnabled = true;
            cbRoomName.Location = new Point(119, 141);
            cbRoomName.Name = "cbRoomName";
            cbRoomName.Size = new Size(357, 33);
            cbRoomName.TabIndex = 29;
            cbRoomName.SelectedIndexChanged += cbRoomName_SelectedIndexChanged;
            cbRoomName.DropDownClosed += cbRoomName_DropDownClosed;
            // 
            // cbBedName
            // 
            cbBedName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBedName.BackColor = Color.FromArgb(238, 186, 178);
            cbBedName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbBedName.FormattingEnabled = true;
            cbBedName.Location = new Point(119, 183);
            cbBedName.Name = "cbBedName";
            cbBedName.Size = new Size(357, 33);
            cbBedName.TabIndex = 30;
            cbBedName.SelectedIndexChanged += cbBedName_SelectedIndexChanged;
            cbBedName.Enter += cbBedName_Enter;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(238, 186, 178);
            panel8.Controls.Add(panel2);
            panel8.Controls.Add(depositTextBox);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(iconButton4);
            panel8.Controls.Add(panel1);
            panel8.Controls.Add(textTennantID);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(cbBedName);
            panel8.Controls.Add(cbRoomName);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textTennantName);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(527, 284);
            panel8.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(245, 243, 231);
            panel2.Location = new Point(119, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 5);
            panel2.TabIndex = 37;
            // 
            // depositTextBox
            // 
            depositTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            depositTextBox.BackColor = Color.FromArgb(238, 186, 178);
            depositTextBox.BorderStyle = BorderStyle.None;
            depositTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            depositTextBox.Location = new Point(119, 99);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.Size = new Size(357, 25);
            depositTextBox.TabIndex = 36;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 99);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 35;
            label4.Text = "Deposit:";
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            iconButton4.BackColor = Color.FromArgb(238, 186, 178);
            iconButton4.BackgroundImageLayout = ImageLayout.Center;
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(275, 236);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(114, 36);
            iconButton4.TabIndex = 34;
            iconButton4.Text = "Update";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(245, 243, 231);
            panel1.Location = new Point(119, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 5);
            panel1.TabIndex = 33;
            // 
            // textTennantID
            // 
            textTennantID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textTennantID.BackColor = Color.FromArgb(238, 186, 178);
            textTennantID.BorderStyle = BorderStyle.None;
            textTennantID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textTennantID.Location = new Point(119, 12);
            textTennantID.Name = "textTennantID";
            textTennantID.Size = new Size(357, 25);
            textTennantID.TabIndex = 32;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 12);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 31;
            label1.Text = "ID:";
            // 
            // TennantsUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 284);
            Controls.Add(panel8);
            Name = "TennantsUpdate";
            Text = "TennantsUpdate";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private TextBox textTennantName;
        private Panel panel10;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private Label label2;
        private ComboBox cbRoomName;
        private ComboBox cbBedName;
        private Panel panel8;
        private Panel panel1;
        private TextBox textTennantID;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel2;
        private TextBox depositTextBox;
        private Label label4;
    }
}