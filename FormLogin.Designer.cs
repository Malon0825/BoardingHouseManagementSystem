namespace ManagementSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelBar = new Panel();
            iconMinimize = new FontAwesome.Sharp.IconButton();
            iconClose = new FontAwesome.Sharp.IconButton();
            panel11 = new Panel();
            iconHide = new FontAwesome.Sharp.IconPictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textPassword = new TextBox();
            panel13 = new Panel();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel10 = new Panel();
            textUsername = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panel12 = new Panel();
            panelBar.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.FromArgb(225, 138, 170);
            panelBar.Controls.Add(iconMinimize);
            panelBar.Controls.Add(iconClose);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(0, 0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(356, 25);
            panelBar.TabIndex = 0;
            panelBar.MouseDown += panelBar_MouseDown;
            // 
            // iconMinimize
            // 
            iconMinimize.Dock = DockStyle.Right;
            iconMinimize.FlatAppearance.BorderSize = 0;
            iconMinimize.FlatStyle = FlatStyle.Flat;
            iconMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconMinimize.IconColor = Color.FromArgb(245, 220, 224);
            iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimize.IconSize = 30;
            iconMinimize.Location = new Point(306, 0);
            iconMinimize.Name = "iconMinimize";
            iconMinimize.Size = new Size(25, 25);
            iconMinimize.TabIndex = 5;
            iconMinimize.UseVisualStyleBackColor = true;
            iconMinimize.Click += iconMinimize_Click;
            // 
            // iconClose
            // 
            iconClose.Dock = DockStyle.Right;
            iconClose.FlatAppearance.BorderSize = 0;
            iconClose.FlatStyle = FlatStyle.Flat;
            iconClose.ForeColor = Color.FromArgb(245, 220, 224);
            iconClose.IconChar = FontAwesome.Sharp.IconChar.X;
            iconClose.IconColor = Color.FromArgb(245, 220, 224);
            iconClose.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconClose.IconSize = 25;
            iconClose.Location = new Point(331, 0);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(25, 25);
            iconClose.TabIndex = 3;
            iconClose.UseVisualStyleBackColor = true;
            iconClose.Click += iconClose_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(228, 160, 183);
            panel11.Controls.Add(iconHide);
            panel11.Controls.Add(iconButton1);
            panel11.Controls.Add(textPassword);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(iconPictureBox5);
            panel11.Controls.Add(panel10);
            panel11.Controls.Add(textUsername);
            panel11.Controls.Add(iconPictureBox4);
            panel11.Controls.Add(panel12);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 25);
            panel11.Name = "panel11";
            panel11.Size = new Size(356, 551);
            panel11.TabIndex = 6;
            // 
            // iconHide
            // 
            iconHide.BackColor = Color.FromArgb(228, 160, 183);
            iconHide.ForeColor = Color.FromArgb(245, 220, 224);
            iconHide.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconHide.IconColor = Color.FromArgb(245, 220, 224);
            iconHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHide.IconSize = 29;
            iconHide.Location = new Point(280, 310);
            iconHide.Name = "iconHide";
            iconHide.Size = new Size(29, 30);
            iconHide.TabIndex = 7;
            iconHide.TabStop = false;
            iconHide.Click += iconHide_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(104, 402);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(137, 45);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Login";
            iconButton1.TextAlign = ContentAlignment.TopCenter;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(228, 160, 183);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.ForeColor = Color.White;
            textPassword.Location = new Point(72, 310);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(214, 30);
            textPassword.TabIndex = 5;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(225, 138, 170);
            panel13.Location = new Point(37, 346);
            panel13.Name = "panel13";
            panel13.Size = new Size(272, 5);
            panel13.TabIndex = 4;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(228, 160, 183);
            iconPictureBox5.ForeColor = Color.FromArgb(245, 220, 224);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox5.IconColor = Color.FromArgb(245, 220, 224);
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 29;
            iconPictureBox5.Location = new Point(37, 310);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(29, 30);
            iconPictureBox5.TabIndex = 4;
            iconPictureBox5.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(225, 138, 170);
            panel10.Location = new Point(37, 249);
            panel10.Name = "panel10";
            panel10.Size = new Size(272, 5);
            panel10.TabIndex = 3;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(228, 160, 183);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textUsername.ForeColor = Color.White;
            textUsername.Location = new Point(72, 213);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(237, 30);
            textUsername.TabIndex = 2;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(228, 160, 183);
            iconPictureBox4.ForeColor = Color.FromArgb(245, 220, 224);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPictureBox4.IconColor = Color.FromArgb(245, 220, 224);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 29;
            iconPictureBox4.Location = new Point(37, 213);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(29, 30);
            iconPictureBox4.TabIndex = 1;
            iconPictureBox4.TabStop = false;
            // 
            // panel12
            // 
            panel12.BackgroundImage = (Image)resources.GetObject("panel12.BackgroundImage");
            panel12.BackgroundImageLayout = ImageLayout.Zoom;
            panel12.ForeColor = Color.Transparent;
            panel12.Location = new Point(63, 34);
            panel12.Name = "panel12";
            panel12.Size = new Size(223, 128);
            panel12.TabIndex = 0;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 576);
            Controls.Add(panel11);
            Controls.Add(panelBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panelBar.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBar;
        private FontAwesome.Sharp.IconButton iconClose;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private Panel panel11;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textPassword;
        private Panel panel13;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Panel panel10;
        private TextBox textUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel panel12;
        private FontAwesome.Sharp.IconPictureBox iconHide;
    }
}