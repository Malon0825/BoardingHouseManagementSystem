namespace ManagementSystem
{
    partial class TennantsDelete
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
            panel1 = new Panel();
            textId = new TextBox();
            label1 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(225, 138, 170);
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(panel1);
            panel8.Controls.Add(textId);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(iconButton4);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(528, 271);
            panel8.TabIndex = 19;
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
            iconButton1.Location = new Point(93, 179);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(120, 36);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "Go Back";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 160, 183);
            panel1.Location = new Point(209, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 5);
            panel1.TabIndex = 19;
            // 
            // textId
            // 
            textId.BackColor = Color.FromArgb(225, 138, 170);
            textId.BorderStyle = BorderStyle.None;
            textId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(209, 101);
            textId.Name = "textId";
            textId.Size = new Size(234, 29);
            textId.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 101);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 17;
            label1.Text = "Tennant ID:";
            label1.Click += label1_Click;
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
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(283, 179);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(114, 36);
            iconButton4.TabIndex = 16;
            iconButton4.Text = "Delete";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // TennantsDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 271);
            Controls.Add(panel8);
            Name = "TennantsDelete";
            Text = "TennantsDelete";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private TextBox textId;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}