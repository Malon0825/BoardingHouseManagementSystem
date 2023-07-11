namespace ManagementSystem
{
    partial class FormReciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReciept));
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelReceipt = new Panel();
            panel3 = new Panel();
            label25 = new Label();
            lblChange = new Label();
            label20 = new Label();
            label24 = new Label();
            lblCash = new Label();
            label18 = new Label();
            label22 = new Label();
            label21 = new Label();
            label10 = new Label();
            lblRentType = new Label();
            label12 = new Label();
            lblRentBill = new Label();
            label14 = new Label();
            lblElectricBill = new Label();
            label23 = new Label();
            lblTotalBill = new Label();
            label16 = new Label();
            label9 = new Label();
            label13 = new Label();
            label26 = new Label();
            label28 = new Label();
            label34 = new Label();
            label36 = new Label();
            lblDate = new Label();
            lblName = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panelReceipt.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(48, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(274, 45);
            label2.TabIndex = 5;
            label2.Text = "Boarding House";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(48, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 65);
            label1.TabIndex = 4;
            label1.Text = "DOLOROSA";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(974, 42);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(206, 65);
            label7.TabIndex = 10;
            label7.Text = "RECEIPT";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.FormClosed += printPreviewDialog1_FormClosed;
            // 
            // panelReceipt
            // 
            panelReceipt.Controls.Add(panel3);
            panelReceipt.Controls.Add(lblDate);
            panelReceipt.Controls.Add(lblName);
            panelReceipt.Controls.Add(label8);
            panelReceipt.Controls.Add(label6);
            panelReceipt.Controls.Add(label5);
            panelReceipt.Controls.Add(label4);
            panelReceipt.Controls.Add(label3);
            panelReceipt.Controls.Add(label1);
            panelReceipt.Controls.Add(label2);
            panelReceipt.Controls.Add(label7);
            panelReceipt.Dock = DockStyle.Top;
            panelReceipt.Location = new Point(0, 0);
            panelReceipt.Margin = new Padding(4);
            panelReceipt.Name = "panelReceipt";
            panelReceipt.Size = new Size(1240, 788);
            panelReceipt.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label25);
            panel3.Controls.Add(lblChange);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(lblCash);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblRentType);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(lblRentBill);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(lblElectricBill);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(lblTotalBill);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label26);
            panel3.Controls.Add(label28);
            panel3.Controls.Add(label34);
            panel3.Controls.Add(label36);
            panel3.Location = new Point(48, 406);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1141, 296);
            panel3.TabIndex = 29;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(924, 224);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(39, 45);
            label25.TabIndex = 49;
            label25.Text = "₱";
            // 
            // lblChange
            // 
            lblChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(981, 224);
            lblChange.Margin = new Padding(4, 0, 4, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(71, 45);
            lblChange.TabIndex = 48;
            lblChange.Text = "500";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(780, 224);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(139, 45);
            label20.TabIndex = 47;
            label20.Text = "Change:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(180, 224);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(39, 45);
            label24.TabIndex = 46;
            label24.Text = "₱";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCash.ForeColor = Color.Black;
            lblCash.Location = new Point(229, 224);
            lblCash.Margin = new Padding(4, 0, 4, 0);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(88, 45);
            lblCash.TabIndex = 45;
            lblCash.Text = "4000";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(79, 224);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(98, 45);
            label18.TabIndex = 44;
            label18.Text = "Cash:";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(652, 79);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(33, 38);
            label22.TabIndex = 43;
            label22.Text = "₱";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(345, 79);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(33, 38);
            label21.TabIndex = 42;
            label21.Text = "₱";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(71, 36);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 38);
            label10.TabIndex = 36;
            label10.Text = "Rent Type";
            // 
            // lblRentType
            // 
            lblRentType.AutoSize = true;
            lblRentType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblRentType.ForeColor = Color.Black;
            lblRentType.Location = new Point(71, 79);
            lblRentType.Margin = new Padding(4, 0, 4, 0);
            lblRentType.Name = "lblRentType";
            lblRentType.Size = new Size(89, 38);
            lblRentType.TabIndex = 37;
            lblRentType.Text = "Room";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(348, 36);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(120, 38);
            label12.TabIndex = 38;
            label12.Text = "Rent Bill";
            // 
            // lblRentBill
            // 
            lblRentBill.Anchor = AnchorStyles.Top;
            lblRentBill.AutoSize = true;
            lblRentBill.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblRentBill.ForeColor = Color.Black;
            lblRentBill.Location = new Point(388, 79);
            lblRentBill.Margin = new Padding(4, 0, 4, 0);
            lblRentBill.Name = "lblRentBill";
            lblRentBill.Size = new Size(77, 38);
            lblRentBill.TabIndex = 39;
            lblRentBill.Text = "3000";
            lblRentBill.Click += lblRentBill_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(652, 36);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(115, 38);
            label14.TabIndex = 40;
            label14.Text = "Deposit";
            // 
            // lblElectricBill
            // 
            lblElectricBill.Anchor = AnchorStyles.Top;
            lblElectricBill.AutoSize = true;
            lblElectricBill.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblElectricBill.ForeColor = Color.Black;
            lblElectricBill.Location = new Point(695, 79);
            lblElectricBill.Margin = new Padding(4, 0, 4, 0);
            lblElectricBill.Name = "lblElectricBill";
            lblElectricBill.Size = new Size(62, 38);
            lblElectricBill.TabIndex = 41;
            lblElectricBill.Text = "500";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(930, 79);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(33, 38);
            label23.TabIndex = 35;
            label23.Text = "₱";
            // 
            // lblTotalBill
            // 
            lblTotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalBill.AutoSize = true;
            lblTotalBill.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalBill.ForeColor = Color.Black;
            lblTotalBill.Location = new Point(972, 79);
            lblTotalBill.Margin = new Padding(4, 0, 4, 0);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(77, 38);
            lblTotalBill.TabIndex = 34;
            lblTotalBill.Text = "3500";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(925, 36);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(124, 38);
            label16.TabIndex = 33;
            label16.Text = "Total Bill";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1638, 220);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(39, 45);
            label9.TabIndex = 32;
            label9.Text = "₱";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(1640, 79);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(33, 38);
            label13.TabIndex = 30;
            label13.Text = "₱";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(1668, 220);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(71, 45);
            label26.TabIndex = 27;
            label26.Text = "500";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(1510, 220);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(139, 45);
            label28.TabIndex = 26;
            label28.Text = "Change:";
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label34.ForeColor = Color.Black;
            label34.Location = new Point(1668, 79);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(77, 38);
            label34.TabIndex = 23;
            label34.Text = "3500";
            // 
            // label36
            // 
            label36.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label36.ForeColor = Color.Black;
            label36.Location = new Point(1635, 36);
            label36.Margin = new Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new Size(124, 38);
            label36.TabIndex = 22;
            label36.Text = "Total Bill";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(1004, 330);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(171, 38);
            lblDate.TabIndex = 21;
            lblDate.Text = "June 1, 2023";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(158, 330);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(228, 38);
            lblName.TabIndex = 20;
            lblName.Text = "Balmond Monbal";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(798, 330);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(185, 38);
            label8.TabIndex = 19;
            label8.Text = "Receipt Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(48, 330);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 38);
            label6.TabIndex = 18;
            label6.Text = "Bill To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(48, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(280, 38);
            label5.TabIndex = 17;
            label5.Text = "Koronadal City (9506)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(48, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 38);
            label4.TabIndex = 16;
            label4.Text = "Brgy. Zone III";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(48, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(240, 38);
            label3.TabIndex = 15;
            label3.Text = "Hechanova Street,";
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.BackgroundImageLayout = ImageLayout.Center;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(974, 795);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(208, 66);
            iconButton2.TabIndex = 31;
            iconButton2.Text = "Print";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // FormReciept
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1240, 878);
            Controls.Add(iconButton2);
            Controls.Add(panelReceipt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormReciept";
            Text = "FormReciept";
            panelReceipt.ResumeLayout(false);
            panelReceipt.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panelReceipt;
        private Panel panel3;
        private Label label25;
        private Label lblChange;
        private Label label20;
        private Label label24;
        private Label lblCash;
        private Label label18;
        private Label label22;
        private Label label21;
        private Label label10;
        private Label lblRentType;
        private Label label12;
        private Label lblRentBill;
        private Label label14;
        private Label lblElectricBill;
        private Label label23;
        private Label lblTotalBill;
        private Label label16;
        private Label label9;
        private Label label13;
        private Label label26;
        private Label label28;
        private Label label34;
        private Label label36;
        private Label lblDate;
        private Label lblName;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}