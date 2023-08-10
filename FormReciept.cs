using System;
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
        DateTime currentDate = DateTime.Now;


        public FormReciept(string name, string rentType, int? rentBill, int totalBill, int? deposit, int cash, int change, int? balance)
        {
            InitializeComponent();
            string formattedDate = currentDate.ToString("MM/dd/yyyy");

            lblDate.Text = formattedDate;
            lblName.Text = name;
            lblRentType.Text = rentType;
            lblRentBill.Text = rentBill.ToString();
            lblTotalBill.Text = totalBill.ToString();
            lblDeposit.Text = deposit.ToString();
            lblCash.Text = cash.ToString();
            lblChange.Text = change.ToString();
            labelBalance.Text = balance.ToString();

            //if (deposit != 0)
            //{


            //}
            //else
            //{
            //    lblName.Text = name;
            //    lblRentType.Text = rentType;
            //    lblRentBill.Text = rentBill.ToString();
            //    lblElectricBill.Text = deposit.ToString();
            //    lblTotalBill.Text = totalBill.ToString();
            //    lblCash.Text = cash.ToString();
            //    lblChange.Text = change.ToString();
            //}
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

        private void iconButton1_Click(object sender, EventArgs e)
        {


        }

        private void printPreviewDialog1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Size size = panelReceipt.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height);
            panelReceipt.DrawToBitmap(bitmap, new Rectangle(0, 0, size.Width, size.Height));

            if (PrinterSettings.InstalledPrinters.Count == 0)
            {
                MessageBox.Show("No printers were detected. Please make sure a printer is installed and try again.");
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void lblRentBill_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
