﻿namespace ManagementSystem
{
    partial class BedsUpdate
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
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel10 = new Panel();
            textBedID = new TextBox();
            label8 = new Label();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(225, 138, 170);
            panel8.Controls.Add(iconButton2);
            panel8.Controls.Add(iconButton1);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(textBedID);
            panel8.Controls.Add(label8);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(547, 283);
            panel8.TabIndex = 5;
            panel8.Paint += panel8_Paint;
            // 
            // iconButton2
            // 
            iconButton2.BackgroundImageLayout = ImageLayout.Center;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 34, 42);
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 160, 183);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(278, 200);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(114, 36);
            iconButton2.TabIndex = 17;
            iconButton2.Text = "Delete";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
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
            iconButton1.Location = new Point(109, 200);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(120, 36);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Go Back";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(228, 160, 183);
            panel10.Location = new Point(215, 130);
            panel10.Name = "panel10";
            panel10.Size = new Size(234, 5);
            panel10.TabIndex = 8;
            // 
            // textBedID
            // 
            textBedID.BackColor = Color.FromArgb(225, 138, 170);
            textBedID.BorderStyle = BorderStyle.None;
            textBedID.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBedID.Location = new Point(215, 99);
            textBedID.Name = "textBedID";
            textBedID.Size = new Size(234, 29);
            textBedID.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(109, 99);
            label8.Name = "label8";
            label8.Size = new Size(84, 30);
            label8.TabIndex = 5;
            label8.Text = "Bed ID:";
            // 
            // BedsUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 283);
            Controls.Add(panel8);
            Name = "BedsUpdate";
            Text = "BedsUpdate";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel10;
        private TextBox textBedID;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}