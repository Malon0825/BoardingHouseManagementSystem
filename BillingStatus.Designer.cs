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
            label1 = new Label();
            panel17 = new Panel();
            txtCash = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            panel1 = new Panel();
            textDeposit = new TextBox();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(238, 186, 178);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(textDeposit);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel17);
            panel5.Controls.Add(txtCash);
            panel5.Controls.Add(iconButton1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(430, 287);
            panel5.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 45);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 35;
            label1.Text = "Cash:";
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel17.BackColor = Color.FromArgb(245, 243, 231);
            panel17.Location = new Point(176, 76);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(157, 7);
            panel17.TabIndex = 34;
            // 
            // txtCash
            // 
            txtCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCash.BackColor = Color.FromArgb(238, 186, 178);
            txtCash.BorderStyle = BorderStyle.None;
            txtCash.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtCash.Location = new Point(176, 31);
            txtCash.Margin = new Padding(3, 4, 3, 4);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(157, 45);
            txtCash.TabIndex = 33;
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImageLayout = ImageLayout.Center;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(154, 205);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(123, 48);
            iconButton1.TabIndex = 32;
            iconButton1.Text = "Done";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 122);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 38;
            label2.Text = "Deposit:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(245, 243, 231);
            panel1.Location = new Point(176, 154);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 7);
            panel1.TabIndex = 37;
            // 
            // textDeposit
            // 
            textDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textDeposit.BackColor = Color.FromArgb(238, 186, 178);
            textDeposit.BorderStyle = BorderStyle.None;
            textDeposit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textDeposit.Location = new Point(176, 109);
            textDeposit.Margin = new Padding(3, 4, 3, 4);
            textDeposit.Name = "textDeposit";
            textDeposit.Size = new Size(157, 45);
            textDeposit.TabIndex = 36;
            // 
            // BillingStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 287);
            Controls.Add(panel5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BillingStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillingStatus";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Panel panel17;
        private TextBox txtCash;
        private Label label2;
        private Panel panel1;
        private TextBox textDeposit;
    }
}