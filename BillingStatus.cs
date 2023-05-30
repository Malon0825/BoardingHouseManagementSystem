using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class BillingStatus : Form
    {
        string bill;
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        DateTime currentDate = DateTime.Now;

        public BillingStatus(string billingID)
        {
            InitializeComponent();

            bill = billingID;
            cbStatus.Items.Add("Paid");
            cbStatus.Items.Add("Unpaid");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string status = cbStatus.Text;
            string formattedDate = currentDate.ToString("MM/dd/yyyy");

            if (!string.IsNullOrWhiteSpace(status))
            {
                try
                {
                    string query = "UPDATE `billing` SET `Date`= @date,`Status`= @status WHERE `BillingId` = @bill";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bill", bill);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@status", status);

                    command.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    // Handle the exception here
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Successful!!");
                    this.Close();
                }
            }
        }
    }
}
