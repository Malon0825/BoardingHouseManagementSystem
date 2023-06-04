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
            panel17 = new Panel();
            txtCash = new TextBox();
            label1 = new Label();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 138, 170);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel17);
            panel5.Controls.Add(txtCash);
            panel5.Controls.Add(iconButton1);
            panel5.Controls.Add(cbStatus);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(376, 215);
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
            iconButton1.Location = new Point(135, 154);
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
            cbStatus.Location = new Point(154, 80);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(137, 33);
            cbStatus.TabIndex = 31;
            cbStatus.SelectedIndexChanged += cbRoomName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 83);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 30;
            label3.Text = "Status:";
            label3.Click += label3_Click;
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel17.BackColor = Color.FromArgb(228, 160, 183);
            panel17.Location = new Point(154, 57);
            panel17.Name = "panel17";
            panel17.Size = new Size(137, 5);
            panel17.TabIndex = 34;
            // 
            // txtCash
            // 
            txtCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCash.BackColor = Color.FromArgb(225, 138, 170);
            txtCash.BorderStyle = BorderStyle.None;
            txtCash.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtCash.Location = new Point(154, 23);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(137, 36);
            txtCash.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 34);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 35;
            label1.Text = "Cash:";
            // 
            // BillingStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 215);
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
        private Label label1;
        private Panel panel17;
        private TextBox txtCash;
    }
}