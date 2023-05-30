namespace ManagementSystem
{
    partial class TennantsAdd
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
            cbBedName = new ComboBox();
            cbRoomName = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            textaddress = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            textemail = new TextBox();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel11 = new Panel();
            textage = new TextBox();
            label11 = new Label();
            panel10 = new Panel();
            textname = new TextBox();
            label8 = new Label();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(225, 138, 170);
            panel8.Controls.Add(cbBedName);
            panel8.Controls.Add(cbRoomName);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(panel4);
            panel8.Controls.Add(textaddress);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(panel1);
            panel8.Controls.Add(textemail);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(iconButton4);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(textage);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textname);
            panel8.Controls.Add(label8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(525, 290);
            panel8.TabIndex = 5;
            // 
            // cbBedName
            // 
            cbBedName.BackColor = Color.FromArgb(225, 138, 170);
            cbBedName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbBedName.FormattingEnabled = true;
            cbBedName.Location = new Point(119, 168);
            cbBedName.Name = "cbBedName";
            cbBedName.Size = new Size(357, 33);
            cbBedName.TabIndex = 30;
            cbBedName.SelectedIndexChanged += cbBedName_SelectedIndexChanged;
            cbBedName.Enter += cbBedName_Enter;
            // 
            // cbRoomName
            // 
            cbRoomName.BackColor = Color.FromArgb(225, 138, 170);
            cbRoomName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoomName.FormattingEnabled = true;
            cbRoomName.Location = new Point(119, 126);
            cbRoomName.Name = "cbRoomName";
            cbRoomName.Size = new Size(357, 33);
            cbRoomName.TabIndex = 29;
            cbRoomName.SelectedIndexChanged += cbRoomName_SelectedIndexChanged;
            cbRoomName.TextUpdate += cbRoomName_TextUpdate;
            cbRoomName.DropDownClosed += cbRoomName_DropDownClosed;
            cbRoomName.Enter += cbRoomName_Enter;
            cbRoomName.Leave += cbRoomName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 171);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 26;
            label2.Text = "Bed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 129);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 23;
            label3.Text = "Room:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(228, 160, 183);
            panel4.Location = new Point(119, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(357, 5);
            panel4.TabIndex = 22;
            // 
            // textaddress
            // 
            textaddress.BackColor = Color.FromArgb(225, 138, 170);
            textaddress.BorderStyle = BorderStyle.None;
            textaddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textaddress.Location = new Point(119, 87);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(357, 25);
            textaddress.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 87);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 20;
            label4.Text = "Address:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 160, 183);
            panel1.Location = new Point(281, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 5);
            panel1.TabIndex = 19;
            // 
            // textemail
            // 
            textemail.BackColor = Color.FromArgb(225, 138, 170);
            textemail.BorderStyle = BorderStyle.None;
            textemail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textemail.Location = new Point(281, 45);
            textemail.Name = "textemail";
            textemail.Size = new Size(195, 25);
            textemail.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(216, 45);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 17;
            label1.Text = "Email:";
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
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(119, 213);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(120, 36);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Go Back";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
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
            iconButton4.Location = new Point(281, 213);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(97, 36);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(228, 160, 183);
            panel11.Location = new Point(119, 76);
            panel11.Name = "panel11";
            panel11.Size = new Size(80, 5);
            panel11.TabIndex = 11;
            // 
            // textage
            // 
            textage.BackColor = Color.FromArgb(225, 138, 170);
            textage.BorderStyle = BorderStyle.None;
            textage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textage.Location = new Point(119, 45);
            textage.Name = "textage";
            textage.Size = new Size(80, 25);
            textage.TabIndex = 10;
            textage.TextChanged += textage_TextChanged;
            textage.KeyPress += textage_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(39, 45);
            label11.Name = "label11";
            label11.Size = new Size(51, 25);
            label11.TabIndex = 9;
            label11.Text = "Age:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(228, 160, 183);
            panel10.Location = new Point(119, 34);
            panel10.Name = "panel10";
            panel10.Size = new Size(357, 5);
            panel10.TabIndex = 8;
            // 
            // textname
            // 
            textname.BackColor = Color.FromArgb(225, 138, 170);
            textname.BorderStyle = BorderStyle.None;
            textname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textname.Location = new Point(119, 3);
            textname.Name = "textname";
            textname.Size = new Size(357, 25);
            textname.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(39, 3);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 5;
            label8.Text = "Name:";
            // 
            // TennantsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 290);
            Controls.Add(panel8);
            Name = "TennantsAdd";
            Text = "TennantsAdd";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private TextBox textaddress;
        private Label label4;
        private Panel panel1;
        private TextBox textemail;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel11;
        private TextBox textage;
        private Label label11;
        private Panel panel10;
        private TextBox textname;
        private Label label8;
        private ComboBox cbBedName;
        private ComboBox cbRoomName;
    }
}