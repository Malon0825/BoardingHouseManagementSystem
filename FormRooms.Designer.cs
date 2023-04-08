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
            panel1 = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            textSearch = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
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
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(535, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(531, 617);
            panel7.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(445, 44);
            label7.Name = "label7";
            label7.Size = new Size(38, 25);
            label7.TabIndex = 9;
            label7.Text = "Bill";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(354, 44);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 8;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(279, 44);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 7;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(153, 44);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 6;
            label4.Text = "Tennants";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 44);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 5;
            label3.Text = "Room";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(525, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 617);
            panel6.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textSearch);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 617);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 160, 183);
            panel2.Location = new Point(156, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 5);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "Room List:";
            label2.Click += label2_Click;
            // 
            // textSearch
            // 
            textSearch.BackColor = Color.FromArgb(225, 138, 170);
            textSearch.BorderStyle = BorderStyle.None;
            textSearch.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(156, 24);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(234, 29);
            textSearch.TabIndex = 0;
            textSearch.TextChanged += textBox1_TextChanged;
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
            iconButton1.Location = new Point(389, 24);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(108, 36);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Search";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 1;
            label1.Text = "Room Name:";
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
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textSearch;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel6;
    }
}