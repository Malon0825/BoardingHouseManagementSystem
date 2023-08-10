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
            comboBoxGender = new ComboBox();
            cbBedName = new ComboBox();
            cbRoomName = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            textaddress = new TextBox();
            label4 = new Label();
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
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(238, 186, 178);
            panel8.Controls.Add(comboBoxGender);
            panel8.Controls.Add(cbBedName);
            panel8.Controls.Add(cbRoomName);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(panel4);
            panel8.Controls.Add(textaddress);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(iconButton4);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(textage);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textname);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(600, 386);
            panel8.TabIndex = 5;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.FromArgb(238, 186, 178);
            comboBoxGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(355, 60);
            comboBoxGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(197, 39);
            comboBoxGender.TabIndex = 31;
            // 
            // cbBedName
            // 
            cbBedName.BackColor = Color.FromArgb(238, 186, 178);
            cbBedName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbBedName.FormattingEnabled = true;
            cbBedName.Location = new Point(145, 224);
            cbBedName.Margin = new Padding(3, 4, 3, 4);
            cbBedName.Name = "cbBedName";
            cbBedName.Size = new Size(407, 39);
            cbBedName.TabIndex = 30;
            cbBedName.SelectedIndexChanged += cbBedName_SelectedIndexChanged;
            cbBedName.Enter += cbBedName_Enter;
            // 
            // cbRoomName
            // 
            cbRoomName.BackColor = Color.FromArgb(238, 186, 178);
            cbRoomName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoomName.FormattingEnabled = true;
            cbRoomName.Location = new Point(145, 168);
            cbRoomName.Margin = new Padding(3, 4, 3, 4);
            cbRoomName.Name = "cbRoomName";
            cbRoomName.Size = new Size(407, 39);
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
            label2.Location = new Point(45, 228);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 26;
            label2.Text = "Bed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 172);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 23;
            label3.Text = "Room:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 243, 231);
            panel4.Location = new Point(145, 158);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 6);
            panel4.TabIndex = 22;
            // 
            // textaddress
            // 
            textaddress.BackColor = Color.FromArgb(238, 186, 178);
            textaddress.BorderStyle = BorderStyle.None;
            textaddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textaddress.Location = new Point(145, 116);
            textaddress.Margin = new Padding(3, 4, 3, 4);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(408, 32);
            textaddress.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 116);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 20;
            label4.Text = "Deposit:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(256, 60);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 17;
            label1.Text = "Gender:";
            // 
            // iconButton1
            // 
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
            iconButton1.Location = new Point(133, 294);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(152, 48);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Go Back";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton4
            // 
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
            iconButton4.Location = new Point(319, 294);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(136, 48);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(245, 243, 231);
            panel11.Location = new Point(145, 102);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(91, 6);
            panel11.TabIndex = 11;
            // 
            // textage
            // 
            textage.BackColor = Color.FromArgb(238, 186, 178);
            textage.BorderStyle = BorderStyle.None;
            textage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textage.Location = new Point(145, 60);
            textage.Margin = new Padding(3, 4, 3, 4);
            textage.Name = "textage";
            textage.Size = new Size(91, 32);
            textage.TabIndex = 10;
            textage.TextChanged += textage_TextChanged;
            textage.KeyPress += textage_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(45, 60);
            label11.Name = "label11";
            label11.Size = new Size(63, 32);
            label11.TabIndex = 9;
            label11.Text = "Age:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(245, 243, 231);
            panel10.Location = new Point(145, 46);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(408, 6);
            panel10.TabIndex = 8;
            // 
            // textname
            // 
            textname.BackColor = Color.FromArgb(238, 186, 178);
            textname.BorderStyle = BorderStyle.None;
            textname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textname.Location = new Point(145, 4);
            textname.Margin = new Padding(3, 4, 3, 4);
            textname.Name = "textname";
            textname.Size = new Size(408, 32);
            textname.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(45, 4);
            label8.Name = "label8";
            label8.Size = new Size(85, 32);
            label8.TabIndex = 5;
            label8.Text = "Name:";
            // 
            // TennantsAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 386);
            Controls.Add(panel8);
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox comboBoxGender;
    }
}