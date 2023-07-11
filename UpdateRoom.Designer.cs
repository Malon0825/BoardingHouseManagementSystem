namespace ManagementSystem
{
    partial class UpdateRoom
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
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            textId = new TextBox();
            label1 = new Label();
            panel12 = new Panel();
            textUpdateDescription = new TextBox();
            label12 = new Label();
            panel11 = new Panel();
            textUpdateLocation = new TextBox();
            label11 = new Label();
            panel10 = new Panel();
            textUpdateName = new TextBox();
            label8 = new Label();
            panel8.SuspendLayout();
            SuspendLayout();
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
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(436, 323);
            iconButton4.Margin = new Padding(4, 5, 4, 5);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(163, 60);
            iconButton4.TabIndex = 16;
            iconButton4.Text = "Update";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(238, 186, 178);
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(panel1);
            panel8.Controls.Add(textId);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(iconButton4);
            panel8.Controls.Add(panel12);
            panel8.Controls.Add(textUpdateDescription);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(textUpdateLocation);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textUpdateName);
            panel8.Controls.Add(label8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(771, 448);
            panel8.TabIndex = 17;
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
            iconButton1.Location = new Point(149, 323);
            iconButton1.Margin = new Padding(4, 5, 4, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(171, 60);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "Go Back";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(245, 243, 231);
            panel1.Location = new Point(336, 72);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 8);
            panel1.TabIndex = 19;
            // 
            // textId
            // 
            textId.Anchor = AnchorStyles.Top;
            textId.BackColor = Color.FromArgb(238, 186, 178);
            textId.BorderStyle = BorderStyle.None;
            textId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(336, 20);
            textId.Margin = new Padding(4, 5, 4, 5);
            textId.Name = "textId";
            textId.Size = new Size(334, 38);
            textId.TabIndex = 18;
            textId.TextChanged += textId_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 38);
            label1.TabIndex = 17;
            label1.Text = "Room ID:";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top;
            panel12.BackColor = Color.FromArgb(245, 243, 231);
            panel12.Location = new Point(336, 283);
            panel12.Margin = new Padding(4, 5, 4, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(334, 8);
            panel12.TabIndex = 14;
            // 
            // textUpdateDescription
            // 
            textUpdateDescription.Anchor = AnchorStyles.Top;
            textUpdateDescription.BackColor = Color.FromArgb(238, 186, 178);
            textUpdateDescription.BorderStyle = BorderStyle.None;
            textUpdateDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textUpdateDescription.Location = new Point(336, 232);
            textUpdateDescription.Margin = new Padding(4, 5, 4, 5);
            textUpdateDescription.Name = "textUpdateDescription";
            textUpdateDescription.Size = new Size(334, 38);
            textUpdateDescription.TabIndex = 13;
            textUpdateDescription.TextChanged += textUpdateDescription_TextChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(47, 232);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(251, 38);
            label12.TabIndex = 12;
            label12.Text = "Room Description:";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top;
            panel11.BackColor = Color.FromArgb(245, 243, 231);
            panel11.Location = new Point(336, 213);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(334, 8);
            panel11.TabIndex = 11;
            // 
            // textUpdateLocation
            // 
            textUpdateLocation.Anchor = AnchorStyles.Top;
            textUpdateLocation.BackColor = Color.FromArgb(238, 186, 178);
            textUpdateLocation.BorderStyle = BorderStyle.None;
            textUpdateLocation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textUpdateLocation.Location = new Point(336, 162);
            textUpdateLocation.Margin = new Padding(4, 5, 4, 5);
            textUpdateLocation.Name = "textUpdateLocation";
            textUpdateLocation.Size = new Size(334, 38);
            textUpdateLocation.TabIndex = 10;
            textUpdateLocation.TextChanged += textUpdateLocation_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(51, 162);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(216, 38);
            label11.TabIndex = 9;
            label11.Text = "Room Location:";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackColor = Color.FromArgb(245, 243, 231);
            panel10.Location = new Point(336, 143);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(334, 8);
            panel10.TabIndex = 8;
            // 
            // textUpdateName
            // 
            textUpdateName.Anchor = AnchorStyles.Top;
            textUpdateName.BackColor = Color.FromArgb(238, 186, 178);
            textUpdateName.BorderStyle = BorderStyle.None;
            textUpdateName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textUpdateName.Location = new Point(336, 92);
            textUpdateName.Margin = new Padding(4, 5, 4, 5);
            textUpdateName.Name = "textUpdateName";
            textUpdateName.Size = new Size(334, 38);
            textUpdateName.TabIndex = 7;
            textUpdateName.TextChanged += textUpdateName_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(51, 92);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(212, 38);
            label8.TabIndex = 5;
            label8.Text = "Room Number:";
            // 
            // UpdateRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 448);
            Controls.Add(panel8);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UpdateRoom";
            Text = "UpdateRoom";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel8;
        private Panel panel12;
        private TextBox textUpdateDescription;
        private Label label12;
        private Panel panel11;
        private TextBox textUpdateLocation;
        private Label label11;
        private Panel panel10;
        private TextBox textUpdateName;
        private Label label8;
        private Panel panel1;
        private TextBox textId;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}