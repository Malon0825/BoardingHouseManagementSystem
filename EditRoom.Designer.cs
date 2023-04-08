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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel11 = new Panel();
            textAddLocation = new TextBox();
            label11 = new Label();
            panel10 = new Panel();
            textAddName = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            textAddDescription = new TextBox();
            label1 = new Label();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(225, 138, 170);
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
            panel8.Name = "panel8";
            panel8.Size = new Size(515, 280);
            panel8.TabIndex = 4;
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
            iconButton1.Location = new Point(109, 200);
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
            iconButton4.Location = new Point(290, 200);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(97, 36);
            iconButton4.TabIndex = 15;
            iconButton4.Text = "Add";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click_1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(228, 160, 183);
            panel11.Location = new Point(235, 128);
            panel11.Name = "panel11";
            panel11.Size = new Size(234, 5);
            panel11.TabIndex = 11;
            // 
            // textAddLocation
            // 
            textAddLocation.BackColor = Color.FromArgb(225, 138, 170);
            textAddLocation.BorderStyle = BorderStyle.None;
            textAddLocation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textAddLocation.Location = new Point(235, 97);
            textAddLocation.Name = "textAddLocation";
            textAddLocation.Size = new Size(234, 29);
            textAddLocation.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(36, 97);
            label11.Name = "label11";
            label11.Size = new Size(167, 30);
            label11.TabIndex = 9;
            label11.Text = "Room Location:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(228, 160, 183);
            panel10.Location = new Point(235, 86);
            panel10.Name = "panel10";
            panel10.Size = new Size(234, 5);
            panel10.TabIndex = 8;
            // 
            // textAddName
            // 
            textAddName.BackColor = Color.FromArgb(225, 138, 170);
            textAddName.BorderStyle = BorderStyle.None;
            textAddName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textAddName.Location = new Point(235, 55);
            textAddName.Name = "textAddName";
            textAddName.Size = new Size(234, 29);
            textAddName.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(36, 55);
            label8.Name = "label8";
            label8.Size = new Size(141, 30);
            label8.TabIndex = 5;
            label8.Text = "Room Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 160, 183);
            panel1.Location = new Point(235, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 5);
            panel1.TabIndex = 19;
            // 
            // textAddDescription
            // 
            textAddDescription.BackColor = Color.FromArgb(225, 138, 170);
            textAddDescription.BorderStyle = BorderStyle.None;
            textAddDescription.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textAddDescription.Location = new Point(235, 139);
            textAddDescription.Name = "textAddDescription";
            textAddDescription.Size = new Size(234, 29);
            textAddDescription.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 139);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 17;
            label1.Text = "Room Description:";
            // 
            // EditRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 280);
            Controls.Add(panel8);
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
    }
}