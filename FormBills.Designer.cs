namespace ManagementSystem
{
    partial class FormBills
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel3 = new Panel();
            dataSearchList = new DataGridView();
            panel14 = new Panel();
            label2 = new Label();
            panel15 = new Panel();
            textBoxDeposit = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            panel19 = new Panel();
            textRentBill = new TextBox();
            panel18 = new Panel();
            label15 = new Label();
            labelChange = new Label();
            label13 = new Label();
            panel17 = new Panel();
            textBox2 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            labelName = new Label();
            label1 = new Label();
            panel13 = new Panel();
            panel7 = new Panel();
            textSearchTennant = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            panel1 = new Panel();
            panel9 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSearchList).BeginInit();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 160, 183);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1125, 630);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 138, 170);
            panel3.Controls.Add(dataSearchList);
            panel3.Controls.Add(panel14);
            panel3.Controls.Add(panel13);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1115, 620);
            panel3.TabIndex = 5;
            // 
            // dataSearchList
            // 
            dataSearchList.AllowUserToAddRows = false;
            dataSearchList.AllowUserToDeleteRows = false;
            dataSearchList.AllowUserToResizeColumns = false;
            dataSearchList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            dataSearchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSearchList.BackgroundColor = Color.FromArgb(245, 243, 231);
            dataSearchList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataSearchList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataSearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataSearchList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataSearchList.DefaultCellStyle = dataGridViewCellStyle3;
            dataSearchList.Dock = DockStyle.Fill;
            dataSearchList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataSearchList.GridColor = Color.Black;
            dataSearchList.Location = new Point(29, 69);
            dataSearchList.Name = "dataSearchList";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataSearchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataSearchList.RowHeadersVisible = false;
            dataSearchList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(228, 160, 183);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Pink;
            dataSearchList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataSearchList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataSearchList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(245, 243, 231);
            dataSearchList.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataSearchList.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataSearchList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 212, 191);
            dataSearchList.RowTemplate.Height = 35;
            dataSearchList.ScrollBars = ScrollBars.Vertical;
            dataSearchList.ShowCellToolTips = false;
            dataSearchList.ShowEditingIcon = false;
            dataSearchList.ShowRowErrors = false;
            dataSearchList.Size = new Size(1054, 223);
            dataSearchList.TabIndex = 12;
            dataSearchList.CellClick += dataSearchList_CellClick_1;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(238, 186, 178);
            panel14.Controls.Add(label2);
            panel14.Controls.Add(panel15);
            panel14.Controls.Add(textBoxDeposit);
            panel14.Controls.Add(iconButton2);
            panel14.Controls.Add(comboBox1);
            panel14.Controls.Add(panel19);
            panel14.Controls.Add(textRentBill);
            panel14.Controls.Add(panel18);
            panel14.Controls.Add(label15);
            panel14.Controls.Add(labelChange);
            panel14.Controls.Add(label13);
            panel14.Controls.Add(panel17);
            panel14.Controls.Add(textBox2);
            panel14.Controls.Add(label6);
            panel14.Controls.Add(label4);
            panel14.Controls.Add(labelName);
            panel14.Controls.Add(label1);
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(29, 292);
            panel14.Name = "panel14";
            panel14.Size = new Size(1054, 328);
            panel14.TabIndex = 5;
            panel14.Paint += panel14_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(533, 39);
            label2.Name = "label2";
            label2.Size = new Size(118, 37);
            label2.TabIndex = 30;
            label2.Text = "Deposit:";
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel15.BackColor = Color.FromArgb(245, 243, 231);
            panel15.Location = new Point(672, 71);
            panel15.Name = "panel15";
            panel15.Size = new Size(333, 5);
            panel15.TabIndex = 29;
            // 
            // textBoxDeposit
            // 
            textBoxDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxDeposit.BackColor = Color.FromArgb(238, 186, 178);
            textBoxDeposit.BorderStyle = BorderStyle.None;
            textBoxDeposit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDeposit.Location = new Point(672, 37);
            textBoxDeposit.Name = "textBoxDeposit";
            textBoxDeposit.Size = new Size(333, 36);
            textBoxDeposit.TabIndex = 28;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.BackgroundImageLayout = ImageLayout.Center;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(238, 186, 178);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 186, 178);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(829, 179);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(145, 64);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Done";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(238, 186, 178);
            comboBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 38);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(245, 243, 231);
            panel19.Location = new Point(194, 161);
            panel19.Name = "panel19";
            panel19.Size = new Size(110, 5);
            panel19.TabIndex = 24;
            // 
            // textRentBill
            // 
            textRentBill.BackColor = Color.FromArgb(238, 186, 178);
            textRentBill.BorderStyle = BorderStyle.None;
            textRentBill.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textRentBill.Location = new Point(194, 130);
            textRentBill.Name = "textRentBill";
            textRentBill.Size = new Size(110, 29);
            textRentBill.TabIndex = 23;
            textRentBill.TextChanged += textRentBill_TextChanged;
            textRentBill.KeyPress += textRentBill_KeyPress;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(245, 243, 231);
            panel18.Location = new Point(194, 115);
            panel18.Name = "panel18";
            panel18.Size = new Size(110, 5);
            panel18.TabIndex = 22;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(533, 193);
            label15.Name = "label15";
            label15.Size = new Size(117, 37);
            label15.TabIndex = 20;
            label15.Text = "Change:";
            // 
            // labelChange
            // 
            labelChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelChange.ForeColor = Color.White;
            labelChange.Location = new Point(687, 180);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(67, 54);
            labelChange.TabIndex = 19;
            labelChange.Text = "00";
            labelChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(533, 114);
            label13.Name = "label13";
            label13.Size = new Size(83, 37);
            label13.TabIndex = 17;
            label13.Text = "Cash:";
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel17.BackColor = Color.FromArgb(245, 243, 231);
            panel17.Location = new Point(672, 146);
            panel17.Name = "panel17";
            panel17.Size = new Size(333, 5);
            panel17.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(238, 186, 178);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(675, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 36);
            textBox2.TabIndex = 15;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 130);
            label6.Name = "label6";
            label6.Size = new Size(101, 30);
            label6.TabIndex = 6;
            label6.Text = "Rent Bill:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 84);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 4;
            label4.Text = "Rent Type:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(194, 37);
            labelName.Name = "labelName";
            labelName.Size = new Size(68, 30);
            labelName.TabIndex = 3;
            labelName.Text = "None";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 2;
            label1.Text = "Tenant Name:";
            label1.Click += label1_Click_1;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(238, 186, 178);
            panel13.Controls.Add(panel7);
            panel13.Controls.Add(textSearchTennant);
            panel13.Controls.Add(iconButton1);
            panel13.Controls.Add(label12);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(29, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(1054, 69);
            panel13.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(245, 243, 231);
            panel7.Location = new Point(165, 51);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 5);
            panel7.TabIndex = 6;
            // 
            // textSearchTennant
            // 
            textSearchTennant.BackColor = Color.FromArgb(238, 186, 178);
            textSearchTennant.BorderStyle = BorderStyle.None;
            textSearchTennant.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textSearchTennant.Location = new Point(165, 20);
            textSearchTennant.Name = "textSearchTennant";
            textSearchTennant.Size = new Size(234, 29);
            textSearchTennant.TabIndex = 4;
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
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(398, 20);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(123, 36);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Search";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 20);
            label12.Name = "label12";
            label12.Size = new Size(163, 30);
            label12.TabIndex = 5;
            label12.Text = "Tennant Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 186, 178);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(29, 620);
            panel1.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom;
            panel9.BackColor = Color.FromArgb(225, 138, 170);
            panel9.Location = new Point(1, 610);
            panel9.Name = "panel9";
            panel9.Size = new Size(1003, 10);
            panel9.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 186, 178);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1083, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(32, 620);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(245, 243, 231);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1115, 10);
            panel5.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(245, 243, 231);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 630);
            panel8.TabIndex = 5;
            // 
            // FormBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 630);
            Controls.Add(panel2);
            Name = "FormBills";
            Text = "FormBills";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataSearchList).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel8;
        private Panel panel1;
        private Panel panel9;
        private Panel panel4;
        private Panel panel13;
        private Panel panel7;
        private TextBox textSearchTennant;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label12;
        private DataGridView dataSearchList;
        private Panel panel14;
        private Label label2;
        private Panel panel15;
        private TextBox textBoxDeposit;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ComboBox comboBox1;
        private Panel panel19;
        private TextBox textRentBill;
        private Panel panel18;
        private Label label15;
        private Label labelChange;
        private Label label13;
        private Panel panel17;
        private TextBox textBox2;
        private Label label6;
        private Label label4;
        private Label labelName;
        private Label label1;
    }
}