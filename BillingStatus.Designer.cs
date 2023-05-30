namespace ManagementSystem
{
    partial class BillingStatus
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
            panel5 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            cbStatus = new ComboBox();
            label3 = new Label();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 138, 170);
            panel5.Controls.Add(iconButton1);
            panel5.Controls.Add(cbStatus);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 151);
            panel5.TabIndex = 8;
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
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(88, 103);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(108, 36);
            iconButton1.TabIndex = 32;
            iconButton1.Text = "Done";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.FromArgb(225, 138, 170);
            cbStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(107, 29);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(137, 33);
            cbStatus.TabIndex = 31;
            cbStatus.SelectedIndexChanged += cbRoomName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 32);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 30;
            label3.Text = "Status:";
            label3.Click += label3_Click;
            // 
            // BillingStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 151);
            Controls.Add(panel5);
            Name = "BillingStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillingStatus";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private ComboBox cbStatus;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}