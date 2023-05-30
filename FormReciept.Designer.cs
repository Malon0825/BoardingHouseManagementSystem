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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            lblName = new Label();
            lblDate = new Label();
            lblRentType = new Label();
            label10 = new Label();
            lblRentBill = new Label();
            label12 = new Label();
            lblElectricBill = new Label();
            label14 = new Label();
            lblTotalBill = new Label();
            label16 = new Label();
            lblCash = new Label();
            label18 = new Label();
            lblChange = new Label();
            label20 = new Label();
            panel1 = new Panel();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 89);
            label2.Name = "label2";
            label2.Size = new Size(188, 30);
            label2.TabIndex = 5;
            label2.Text = "Boarding House";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(70, 44);
            label1.Name = "label1";
            label1.Size = new Size(197, 45);
            label1.TabIndex = 4;
            label1.Text = "DOLOROSA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(75, 142);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 6;
            label3.Text = "Hechanova Street,";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(75, 167);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 7;
            label4.Text = "Brgy. Zone III";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(75, 192);
            label5.Name = "label5";
            label5.Size = new Size(193, 25);
            label5.TabIndex = 8;
            label5.Text = "Koronadal City (9506)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(651, 44);
            label7.Name = "label7";
            label7.Size = new Size(140, 45);
            label7.TabIndex = 10;
            label7.Text = "RECEIPT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(75, 267);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 11;
            label6.Text = "Bill To:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(551, 267);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 12;
            label8.Text = "Receipt Date:";
            label8.Click += label8_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(138, 267);
            lblName.Name = "lblName";
            lblName.Size = new Size(157, 25);
            lblName.TabIndex = 13;
            lblName.Text = "Balmond Monbal";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(676, 267);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(115, 25);
            lblDate.TabIndex = 14;
            lblDate.Text = "June 1, 2023";
            lblDate.Click += label10_Click;
            // 
            // lblRentType
            // 
            lblRentType.AutoSize = true;
            lblRentType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblRentType.ForeColor = Color.Black;
            lblRentType.Location = new Point(48, 47);
            lblRentType.Name = "lblRentType";
            lblRentType.Size = new Size(60, 25);
            lblRentType.TabIndex = 17;
            lblRentType.Text = "Room";
            lblRentType.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(48, 22);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 16;
            label10.Text = "Rent Type";
            // 
            // lblRentBill
            // 
            lblRentBill.Anchor = AnchorStyles.Top;
            lblRentBill.AutoSize = true;
            lblRentBill.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblRentBill.ForeColor = Color.Black;
            lblRentBill.Location = new Point(255, 47);
            lblRentBill.Name = "lblRentBill";
            lblRentBill.Size = new Size(52, 25);
            lblRentBill.TabIndex = 19;
            lblRentBill.Text = "3000";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(240, 22);
            label12.Name = "label12";
            label12.Size = new Size(82, 25);
            label12.TabIndex = 18;
            label12.Text = "Rent Bill";
            // 
            // lblElectricBill
            // 
            lblElectricBill.Anchor = AnchorStyles.Top;
            lblElectricBill.AutoSize = true;
            lblElectricBill.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblElectricBill.ForeColor = Color.Black;
            lblElectricBill.Location = new Point(417, 47);
            lblElectricBill.Name = "lblElectricBill";
            lblElectricBill.Size = new Size(42, 25);
            lblElectricBill.TabIndex = 21;
            lblElectricBill.Text = "500";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(399, 22);
            label14.Name = "label14";
            label14.Size = new Size(105, 25);
            label14.TabIndex = 20;
            label14.Text = "Electric Bill";
            // 
            // lblTotalBill
            // 
            lblTotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalBill.AutoSize = true;
            lblTotalBill.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalBill.ForeColor = Color.Black;
            lblTotalBill.Location = new Point(598, 47);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(52, 25);
            lblTotalBill.TabIndex = 23;
            lblTotalBill.Text = "3500";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(575, 22);
            label16.Name = "label16";
            label16.Size = new Size(84, 25);
            label16.TabIndex = 22;
            label16.Text = "Total Bill";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCash.ForeColor = Color.Black;
            lblCash.Location = new Point(141, 132);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(61, 30);
            lblCash.TabIndex = 25;
            lblCash.Text = "4000";
            lblCash.Click += label17_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(50, 132);
            label18.Name = "label18";
            label18.Size = new Size(65, 30);
            label18.TabIndex = 24;
            label18.Text = "Cash:";
            // 
            // lblChange
            // 
            lblChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblChange.ForeColor = Color.Black;
            lblChange.Location = new Point(598, 132);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(49, 30);
            lblChange.TabIndex = 27;
            lblChange.Text = "500";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(487, 132);
            label20.Name = "label20";
            label20.Size = new Size(94, 30);
            label20.TabIndex = 26;
            label20.Text = "Change:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lblChange);
            panel1.Controls.Add(lblRentType);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lblCash);
            panel1.Controls.Add(lblRentBill);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblTotalBill);
            panel1.Controls.Add(lblElectricBill);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(75, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 178);
            panel1.TabIndex = 28;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(577, 132);
            label25.Name = "label25";
            label25.Size = new Size(26, 30);
            label25.TabIndex = 32;
            label25.Text = "₱";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(121, 132);
            label24.Name = "label24";
            label24.Size = new Size(26, 30);
            label24.TabIndex = 31;
            label24.Text = "₱";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(578, 47);
            label23.Name = "label23";
            label23.Size = new Size(23, 25);
            label23.TabIndex = 30;
            label23.Text = "₱";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(399, 47);
            label22.Name = "label22";
            label22.Size = new Size(23, 25);
            label22.TabIndex = 29;
            label22.Text = "₱";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(238, 47);
            label21.Name = "label21";
            label21.Size = new Size(23, 25);
            label21.TabIndex = 28;
            label21.Text = "₱";
            label21.Click += label21_Click;
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
            // 
            // FormReciept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 543);
            Controls.Add(panel1);
            Controls.Add(lblDate);
            Controls.Add(lblName);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormReciept";
            Text = "FormReciept";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label lblName;
        private Label lblDate;
        private Label lblRentType;
        private Label label10;
        private Label lblRentBill;
        private Label label12;
        private Label lblElectricBill;
        private Label label14;
        private Label lblTotalBill;
        private Label label16;
        private Label lblCash;
        private Label label18;
        private Label lblChange;
        private Label label20;
        private Panel panel1;
        private Label label21;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}