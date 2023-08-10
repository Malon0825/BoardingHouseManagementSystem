﻿using MySql.Data.MySqlClient;
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

        int billTenantId;

        string tennantName;
        int? deposit;
        int tenantId;

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        DateTime currentDate = DateTime.Now;

        public BillingStatus(string billingID, FormHistory frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;

            bill = billingID;


        }

        public BillingStatus(string billingID, FormTennantView formTennantView)
        {
            InitializeComponent();
            bill = billingID;
            this.formTennantView = formTennantView;

        }

        private FormHistory frm1;
        private string? billingID;
        private FormTennantView formTennantView;

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

            string query2 = "UPDATE `tennants` SET `Deposit` = @deposit WHERE ID = @tenantID";

            string cash = txtCash.Text;
            string useDeposit = textDeposit.Text;
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            string status = "Paid";

            List<Bills> getAllBills()
            {
                List<Bills> returnThese = new List<Bills>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM billing WHERE BillingId = @id", connection);
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
                billTotal = bill.Total;
                billBalanced = bill.Balanced;
                billDueDate = bill.DueDate;
                billDate = bill.Date;
                billStatus = bill.Status;
                billTenantId = bill.TennantId;



            }

            if (!string.IsNullOrWhiteSpace(cash) && string.IsNullOrWhiteSpace(useDeposit))
            {


                int cashInt = int.Parse(cash);

                int balanceInt = billBalanced ?? 0;

                int change = cashInt - balanceInt;

                if (change >= 0)
                {

                    //MessageBox.Show("Clicked!");

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
                                    ID = reader.GetInt32(0),
                                    TennantName = reader.GetString(1),
                                    TennantAge = reader.GetInt32(2),
                                    TennantEmail = reader.GetString(3),
                                    Deposit = reader.GetInt32(4),
                                    rooms_ID = reader.GetInt32(5),
                                    beds_ID = reader.GetInt32(6),

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
                        deposit = t.Deposit;

                    }

                    try
                    {
                        string query = "UPDATE `billing` SET `Balance`= @balance, `Date`= @date,`Status`= @status WHERE `BillingId` = @bill";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@bill", bill);
                        command.Parameters.AddWithValue("@balance", null);
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
                        FormReciept formReciept = new FormReciept(tennantName, billrentType, billRentBill, billTotal, deposit, cashInt, change, balanceInt);
                        formReciept.Show();

                        //this.frm1.UpdateDataGridViewFunc();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient amount.");
                }


            }
            else if (string.IsNullOrWhiteSpace(cash) && !string.IsNullOrWhiteSpace(useDeposit))
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
                                ID = reader.GetInt32(0),
                                TennantName = reader.GetString(1),
                                TennantAge = reader.GetInt32(2),
                                TennantEmail = reader.GetString(3),
                                Deposit = reader.GetInt32(4),
                                rooms_ID = reader.GetInt32(5),
                                beds_ID = reader.GetInt32(6),

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
                    tenantId = t.ID;
                    tennantName = t.TennantName;
                    deposit = t.Deposit;

                }


                int depositInt = int.Parse(useDeposit);

                int depositNullInt = deposit ?? 0;
                int balanceInt = billBalanced ?? 0;

                int change = depositInt - balanceInt;
                int newDeposit = depositNullInt - depositInt;


                if (change >= 0 && depositNullInt >= depositInt)
                {

                    //MessageBox.Show("Clicked!");


                    try
                    {
                        string query = "UPDATE `billing` SET `Balance`= @balance, `Date`= @date,`Status`= @status WHERE `BillingId` = @bill";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@bill", bill);
                        command.Parameters.AddWithValue("@balance", null);
                        command.Parameters.AddWithValue("@date", formattedDate);
                        command.Parameters.AddWithValue("@status", status);

                        command.ExecuteNonQuery();

                        MySqlCommand command2 = new MySqlCommand(query2, connection);

                        command2.Parameters.AddWithValue("@deposit", newDeposit);
                        command2.Parameters.AddWithValue("@tenantID", tenantId);

                        command2.ExecuteNonQuery();

                    }
                    catch (MySqlException ex)
                    {
                        // Handle the exception here
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        FormReciept formReciept = new FormReciept(tennantName, billrentType, billRentBill, billTotal, deposit, depositInt, change, balanceInt);
                        formReciept.Show();

                        //this.frm1.UpdateDataGridViewFunc();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please check the remaining deposit or the amount entered.");
                }
            }
            else if (!string.IsNullOrWhiteSpace(cash) && !string.IsNullOrWhiteSpace(useDeposit))
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
                                ID = reader.GetInt32(0),
                                TennantName = reader.GetString(1),
                                TennantAge = reader.GetInt32(2),
                                TennantEmail = reader.GetString(3),
                                Deposit = reader.GetInt32(4),
                                rooms_ID = reader.GetInt32(5),
                                beds_ID = reader.GetInt32(6),

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
                    tenantId = t.ID;
                    tennantName = t.TennantName;
                    deposit = t.Deposit;

                }

                int cashInt = int.Parse(cash);
                int depositInt = int.Parse(useDeposit);

                int depositNullInt = deposit ?? 0;
                int balanceInt = billBalanced ?? 0;

                int totalCash = cashInt + depositInt;

                int change = totalCash - balanceInt;
                int newDeposit = depositNullInt - depositInt;

                if (change >= 0 && depositNullInt >= depositInt)
                {
                    try
                    {
                        string query = "UPDATE `billing` SET `Balance`= @balance, `Date`= @date,`Status`= @status WHERE `BillingId` = @bill";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@bill", bill);
                        command.Parameters.AddWithValue("@balance", null);
                        command.Parameters.AddWithValue("@date", formattedDate);
                        command.Parameters.AddWithValue("@status", status);

                        command.ExecuteNonQuery();

                        MySqlCommand command2 = new MySqlCommand(query2, connection);

                        command2.Parameters.AddWithValue("@deposit", newDeposit);
                        command2.Parameters.AddWithValue("@tenantID", tenantId);

                        command2.ExecuteNonQuery();

                    }
                    catch (MySqlException ex)
                    {
                            // Handle the exception here
                            Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                            FormReciept formReciept = new FormReciept(tennantName, billrentType, billRentBill, billTotal, deposit, totalCash, change, balanceInt);
                            formReciept.Show();

                            //this.frm1.UpdateDataGridViewFunc();

                            this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please check the remaining deposit or the amount entered.");
                }
              
            }
            else
            {
                MessageBox.Show("Check the field if empty.");
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
            public int? Deposit { get; set; }
            public string DueDate { get; set; }
            public string? Date { get; set; }
            public string Status { get; set; }
            public int TennantId { get; set; }

        }
        internal class Tennant
        {
            public int ID { get; set; }
            public string TennantName { get; set; }
            public int TennantAge { get; set; }
            public string TennantEmail { get; set; }
            public int Deposit { get; set; }
            public int rooms_ID { get; set; }
            public int beds_ID { get; set; }

        }

    }
}
