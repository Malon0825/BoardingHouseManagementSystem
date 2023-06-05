using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class BillingStatus : Form
    {
        string bill;
        int billId;
        string billrentType;
        int? billRentBill;
        int? billElectricBill;
        int billTotal;
        int? billBalanced;
        string billDueDate;
        string billDate;
        string billStatus;
        string tennantName;
        int billTenantId;

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        DateTime currentDate = DateTime.Now;

        public BillingStatus(string billingID, FormHistory frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;

            bill = billingID;
            cbStatus.Items.Add("Paid");
            cbStatus.Items.Add("Unpaid");


        }
        private FormHistory frm1;

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
            string cash = txtCash.Text;
            string formattedDate = currentDate.ToString("MM/dd/yyyy");

            List<Bills> getAllBills()
            {
                List<Bills> returnThese = new List<Bills>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM billing WHERE `BillingId` = @id", connection);
                command.Parameters.AddWithValue("id", bill);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bills t = new Bills
                        {
                            BillingID = reader.GetInt32(0),
                            RentType = reader.GetString(1),
                            RentBill = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                            ElectricBill = reader.IsDBNull(2) ? null : reader.GetInt32(2),
                            Total = reader.GetInt32(4),
                            Balanced = reader.IsDBNull(5) ? null : reader.GetInt32(5),
                            DueDate = reader.GetString(6),
                            Date = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Status = reader.GetString(8),
                            TennantId = reader.GetInt32(9),

                        };

                        returnThese.Add(t);

                    }

                }

                connection.Close();
                return returnThese;
            }

            List<Bills> bills = getAllBills();

            foreach (Bills bill in bills)
            {
                billId = bill.BillingID;
                billrentType = bill.RentType;
                billRentBill = bill.RentBill;
                billElectricBill = bill.ElectricBill;
                billTotal = bill.Total;
                billBalanced = bill.Balanced;
                billDueDate = bill.DueDate;
                billDate = bill.Date;
                billStatus = bill.Status;
                billTenantId = bill.TennantId;

            }

            if (!string.IsNullOrWhiteSpace(status) && !string.IsNullOrWhiteSpace(cash))
            {
                if(billBalanced == null)
                {
                    int cashInt = int.Parse(cash);
                    int change = cashInt - billTotal;

                    if (change >= 0)
                    {
                        List<Tennant> getTennant()
                        {
                            List<Tennant> returnThese = new List<Tennant>();

                            MySqlConnection connection = new MySqlConnection(connectionString);
                            connection.Open();

                            MySqlCommand command = new MySqlCommand("SELECT * FROM tennants WHERE `ID` = @id", connection);
                            command.Parameters.AddWithValue("id", billTenantId);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Tennant t = new Tennant
                                    {
                                        TennantName = reader.GetString(1),

                                    };

                                    returnThese.Add(t);

                                }

                            }

                            connection.Close();
                            return returnThese;
                        }
                        List<Tennant> tennant = getTennant();

                        foreach (Tennant t in tennant)
                        {
                            tennantName = t.TennantName;

                        }

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
                            FormReciept formReciept = new FormReciept(tennantName, billrentType, billRentBill, billElectricBill, billTotal, cashInt, change);
                            formReciept.Show();
                            this.frm1.UpdateDataGridViewFunc();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough cash!");
                    }
                }
                else
                {
                    int cashInt = int.Parse(cash);
                    string balancedBill = billBalanced.ToString();
                    int intBalancedBill = int.Parse(balancedBill);

                    int initialPay = billTotal - intBalancedBill;

                    int totalPay = initialPay + cashInt;

                    int change = totalPay - billTotal;

                    if (change >= 0)
                    {
                        List<Tennant> getTennant()
                        {
                            List<Tennant> returnThese = new List<Tennant>();

                            MySqlConnection connection = new MySqlConnection(connectionString);
                            connection.Open();

                            MySqlCommand command = new MySqlCommand("SELECT * FROM tennants WHERE `ID` = @id", connection);
                            command.Parameters.AddWithValue("id", billTenantId);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Tennant t = new Tennant
                                    {
                                        TennantName = reader.GetString(1),

                                    };

                                    returnThese.Add(t);

                                }

                            }

                            connection.Close();
                            return returnThese;
                        }
                        List<Tennant> tennant = getTennant();

                        foreach (Tennant t in tennant)
                        {
                            tennantName = t.TennantName;

                        }

                        try
                        {
                            string query = "UPDATE `billing` SET `Balance`= @balance, `Date`= @date,`Status`= @status WHERE `BillingId` = @bill";

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@balance", null);
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
                            FormReciept formReciept = new FormReciept(tennantName, billrentType, billRentBill, billElectricBill, billTotal, totalPay, change);
                            formReciept.Show();
                            this.frm1.UpdateDataGridViewFunc();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough cash!");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Check the fields if empty.");
            }
        }
        internal class Bills
        {
            public int BillingID { get; set; }
            public string RentType { get; set; }
            public int? RentBill { get; set; }
            public int? ElectricBill { get; set; }
            public int Total { get; set; }
            public int? Balanced { get; set; }
            public string DueDate { get; set; }
            public string? Date { get; set; }
            public string Status { get; set; }
            public int TennantId { get; set; }

        }
        internal class Tennant
        {
            public string TennantName { get; set; }
        }

    }
}
