﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class FormReciept : Form
    {
        Bitmap bitmap;
        public FormReciept(string name, string rentType, int? rentBill, int? electricBill, int totalBill, int cash, int change)
        {
            InitializeComponent();

            lblName.Text = name;
            lblRentType.Text = rentType;
            lblRentBill.Text = rentBill.ToString();
            lblElectricBill.Text = electricBill.ToString();
            lblTotalBill.Text = totalBill.ToString();
            lblCash.Text = cash.ToString();
            lblChange.Text = change.ToString();

            //Size size = this.ClientSize;
            //bitmap = new Bitmap(size.Width, size.Height);
            //using (Graphics graphics = Graphics.FromImage(bitmap))
            //{
            //    Point point = PointToScreen(this.Location);
            //    graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            //}

            //if (PrinterSettings.InstalledPrinters.Count == 0)
            //{
            //    MessageBox.Show("No printers were detected. Please make sure a printer is installed and try again.");
            //}
            //else
            //{
            //    printPreviewDialog1.Document = printDocument1;
            //    printPreviewDialog1.ShowDialog();
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
