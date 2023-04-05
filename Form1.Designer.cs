namespace ManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            panel4 = new Panel();
            billBtn = new FontAwesome.Sharp.IconButton();
            tenantBtn = new FontAwesome.Sharp.IconButton();
            bedBtn = new FontAwesome.Sharp.IconButton();
            roomBtn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            iconMinimize = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconClose = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelHomeBg = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(225, 138, 170);
            panelSideMenu.Controls.Add(panel4);
            panelSideMenu.Controls.Add(billBtn);
            panelSideMenu.Controls.Add(tenantBtn);
            panelSideMenu.Controls.Add(bedBtn);
            panelSideMenu.Controls.Add(roomBtn);
            panelSideMenu.Controls.Add(homeBtn);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(243, 761);
            panelSideMenu.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 430);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 331);
            panel4.TabIndex = 10;
            // 
            // billBtn
            // 
            billBtn.Dock = DockStyle.Top;
            billBtn.FlatAppearance.BorderSize = 0;
            billBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 160, 183);
            billBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 97, 120);
            billBtn.FlatStyle = FlatStyle.Flat;
            billBtn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            billBtn.ForeColor = Color.FromArgb(245, 220, 224);
            billBtn.IconChar = FontAwesome.Sharp.IconChar.Coins;
            billBtn.IconColor = Color.White;
            billBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            billBtn.IconSize = 35;
            billBtn.ImageAlign = ContentAlignment.MiddleLeft;
            billBtn.Location = new Point(0, 374);
            billBtn.Name = "billBtn";
            billBtn.Padding = new Padding(10, 0, 20, 0);
            billBtn.Size = new Size(243, 56);
            billBtn.TabIndex = 9;
            billBtn.Text = "Bills";
            billBtn.TextAlign = ContentAlignment.MiddleLeft;
            billBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            billBtn.UseVisualStyleBackColor = true;
            billBtn.Click += billBtn_Click;
            // 
            // tenantBtn
            // 
            tenantBtn.Dock = DockStyle.Top;
            tenantBtn.FlatAppearance.BorderSize = 0;
            tenantBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 160, 183);
            tenantBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 97, 120);
            tenantBtn.FlatStyle = FlatStyle.Flat;
            tenantBtn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tenantBtn.ForeColor = Color.FromArgb(245, 220, 224);
            tenantBtn.IconChar = FontAwesome.Sharp.IconChar.PersonShelter;
            tenantBtn.IconColor = Color.White;
            tenantBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tenantBtn.IconSize = 35;
            tenantBtn.ImageAlign = ContentAlignment.MiddleLeft;
            tenantBtn.Location = new Point(0, 318);
            tenantBtn.Name = "tenantBtn";
            tenantBtn.Padding = new Padding(10, 0, 20, 0);
            tenantBtn.Size = new Size(243, 56);
            tenantBtn.TabIndex = 8;
            tenantBtn.Text = "Tenants";
            tenantBtn.TextAlign = ContentAlignment.MiddleLeft;
            tenantBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            tenantBtn.UseVisualStyleBackColor = true;
            tenantBtn.Click += tenantBtn_Click;
            // 
            // bedBtn
            // 
            bedBtn.Dock = DockStyle.Top;
            bedBtn.FlatAppearance.BorderSize = 0;
            bedBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 160, 183);
            bedBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 97, 120);
            bedBtn.FlatStyle = FlatStyle.Flat;
            bedBtn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bedBtn.ForeColor = Color.FromArgb(245, 220, 224);
            bedBtn.IconChar = FontAwesome.Sharp.IconChar.Bed;
            bedBtn.IconColor = Color.White;
            bedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bedBtn.IconSize = 35;
            bedBtn.ImageAlign = ContentAlignment.MiddleLeft;
            bedBtn.Location = new Point(0, 262);
            bedBtn.Name = "bedBtn";
            bedBtn.Padding = new Padding(10, 0, 20, 0);
            bedBtn.Size = new Size(243, 56);
            bedBtn.TabIndex = 7;
            bedBtn.Text = "Beds";
            bedBtn.TextAlign = ContentAlignment.MiddleLeft;
            bedBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            bedBtn.UseVisualStyleBackColor = true;
            bedBtn.Click += bedBtn_Click;
            // 
            // roomBtn
            // 
            roomBtn.Dock = DockStyle.Top;
            roomBtn.FlatAppearance.BorderSize = 0;
            roomBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 160, 183);
            roomBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 97, 120);
            roomBtn.FlatStyle = FlatStyle.Flat;
            roomBtn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            roomBtn.ForeColor = Color.FromArgb(245, 220, 224);
            roomBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            roomBtn.IconColor = Color.White;
            roomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            roomBtn.IconSize = 35;
            roomBtn.ImageAlign = ContentAlignment.MiddleLeft;
            roomBtn.Location = new Point(0, 206);
            roomBtn.Name = "roomBtn";
            roomBtn.Padding = new Padding(10, 0, 20, 0);
            roomBtn.Size = new Size(243, 56);
            roomBtn.TabIndex = 6;
            roomBtn.Text = "Rooms";
            roomBtn.TextAlign = ContentAlignment.MiddleLeft;
            roomBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            roomBtn.UseVisualStyleBackColor = true;
            roomBtn.Click += roomBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Dock = DockStyle.Top;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 160, 183);
            homeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(158, 97, 120);
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.ForeColor = Color.FromArgb(245, 220, 224);
            homeBtn.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            homeBtn.IconColor = Color.White;
            homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeBtn.IconSize = 35;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 150);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(10, 0, 20, 0);
            homeBtn.Size = new Size(243, 56);
            homeBtn.TabIndex = 5;
            homeBtn.Text = "Home";
            homeBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(panel5);
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(243, 150);
            panelLogo.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(0, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(41, 56);
            panel5.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 55);
            label2.Name = "label2";
            label2.Size = new Size(188, 30);
            label2.TabIndex = 3;
            label2.Text = "Boarding House";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 45);
            label1.TabIndex = 2;
            label1.Text = "DOLOROSA";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 138, 170);
            panel1.Controls.Add(iconMinimize);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(iconClose);
            panel1.Controls.Add(lblTitleChildForm);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(243, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 50);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
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
            iconMinimize.Location = new Point(960, 0);
            iconMinimize.Name = "iconMinimize";
            iconMinimize.Size = new Size(25, 50);
            iconMinimize.TabIndex = 4;
            iconMinimize.UseVisualStyleBackColor = true;
            iconMinimize.Click += iconMinimize_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Square;
            iconButton1.IconColor = Color.FromArgb(245, 220, 224);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(985, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(31, 50);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_1;
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
            iconClose.Location = new Point(1016, 0);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(25, 50);
            iconClose.TabIndex = 2;
            iconClose.UseVisualStyleBackColor = true;
            iconClose.Click += iconClose_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.FromArgb(245, 220, 224);
            lblTitleChildForm.Location = new Point(42, 10);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(73, 30);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.Click += lblTitleChildForm_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(225, 138, 170);
            iconCurrentChildForm.ForeColor = Color.FromArgb(245, 220, 224);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            iconCurrentChildForm.IconColor = Color.FromArgb(245, 220, 224);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 37;
            iconCurrentChildForm.Location = new Point(3, 8);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(37, 42);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelHomeBg
            // 
            panelHomeBg.BackColor = Color.FromArgb(228, 160, 183);
            panelHomeBg.Dock = DockStyle.Fill;
            panelHomeBg.Location = new Point(243, 50);
            panelHomeBg.Name = "panelHomeBg";
            panelHomeBg.Size = new Size(1041, 711);
            panelHomeBg.TabIndex = 2;
            panelHomeBg.Layout += panelHomeBg_Layout;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(158, 97, 120);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(243, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 5);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(158, 97, 120);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(243, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 706);
            panel3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 220, 224);
            ClientSize = new Size(1284, 761);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelHomeBg);
            Controls.Add(panel1);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton billBtn;
        private FontAwesome.Sharp.IconButton tenantBtn;
        private FontAwesome.Sharp.IconButton bedBtn;
        private FontAwesome.Sharp.IconButton roomBtn;
        private Panel panel1;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconClose;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private Panel panelHomeBg;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}