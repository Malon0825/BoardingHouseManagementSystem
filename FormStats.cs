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
using static ManagementSystem.FormRooms;

namespace ManagementSystem
{
    public partial class FormStats : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        DateTime currentDate = DateTime.Now;

        List<int> rentBills = new List<int>();
        List<int> electricBills = new List<int>();
        List<int> totalBills = new List<int>();


        public FormStats()
        {
            InitializeComponent();

            currentDate = DateTime.Now;
            string dateNow = currentDate.ToString("MM/01/yyyy");
            lblDate.Text = dateNow;

            List<Bills> getAllBills()
            {
                List<Bills> returnThese = new List<Bills>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT BillingId, RentType, ElectricBill, " +
                    "Rent, Total, DueDate, Date, Status, tennants_ID FROM billing " +
                    "WHERE `DueDate` = @dueDate AND `Status` = @status", connection);

                command.Parameters.AddWithValue("@dueDate", dateNow);
                command.Parameters.AddWithValue("@status", "Paid");

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bills bills = new Bills
                        {
                            BillingID = reader.GetInt32(0),
                            RentType = reader.GetString(1),
                            ElectricBill = reader.IsDBNull(2) ? null : reader.GetInt32(2),
                            RentBill = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                            Total = reader.GetInt32(4),
                            DueDate = reader.GetString(5),
                            Date = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Status = reader.GetString(7),
                            tennants_ID = reader.GetInt32(8),

                        };

                        returnThese.Add(bills);

                    }

                }

                connection.Close();
                return returnThese;
            }

            List<Bills> bills = getAllBills();

            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("BillingID");
            dataTable2.Columns.Add("RentType");
            dataTable2.Columns.Add("RentBill");
            dataTable2.Columns.Add("ElectricBill");
            dataTable2.Columns.Add("Total");
            dataTable2.Columns.Add("DueDate");
            dataTable2.Columns.Add("Date");
            dataTable2.Columns.Add("Status");

            foreach (Bills bill in bills)
            {
                DataRow row = dataTable2.NewRow();
                var date =
                row["BillingID"] = bill.BillingID;
                row["RentType"] = bill.RentType;
                row["RentBill"] = bill.RentBill;
                row["ElectricBill"] = bill.ElectricBill;
                row["Total"] = bill.Total;
                row["DueDate"] = bill.DueDate;
                row["Date"] = bill.Date;
                row["Status"] = bill.Status;

                if (bill.RentBill.HasValue && bill.ElectricBill.HasValue)
                {
                    int rentBill = bill.RentBill.Value;
                    rentBills.Add(rentBill);

                    int electricBill = bill.ElectricBill.Value;
                    electricBills.Add(electricBill);

                    int totalBill = bill.Total;
                    totalBills.Add(totalBill);
                }
                else if (!bill.RentBill.HasValue && bill.ElectricBill.HasValue)
                {
                    int electricBill = bill.ElectricBill.Value;
                    electricBills.Add(electricBill);

                    int totalBill = bill.Total;
                    totalBills.Add(totalBill);
                }
                else if (bill.RentBill.HasValue && !bill.ElectricBill.HasValue)
                {
                    int rentBill = bill.RentBill.Value;
                    rentBills.Add(rentBill);

                    int totalBill = bill.Total;
                    totalBills.Add(totalBill);
                }
                else
                {
                    // Handle null value here
                }


                dataTable2.Rows.Add(row);
            }

            int totalRentBills = rentBills.Sum();
            lableRentBill.Text = totalRentBills.ToString();

            int totalElectricBills = electricBills.Sum();
            lableElectricBill.Text = totalElectricBills.ToString();

            int overAllBills = totalBills.Sum();
            lableTotalBill.Text = overAllBills.ToString();

            dataGridView2.DataSource = dataTable2;

        }
        internal class Bills
        {
            public int BillingID { get; set; }
            public string RentType { get; set; }
            public int? ElectricBill { get; set; }
            public int? RentBill { get; set; }
            public int Total { get; set; }
            public string DueDate { get; set; }
            public string? Date { get; set; }
            public string Status { get; set; }
            public int tennants_ID { get; set; }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            rentBills.Clear();
            electricBills.Clear();
            totalBills.Clear();

            currentDate = DateTime.Now;
            string dateNow = currentDate.ToString("MM/01/yyyy");
            lblDate.Text = dateNow;

            handleStats(dateNow);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            string dateNow = currentDate.ToString("MM/01/yyyy");
            lblDate.Text = dateNow;

            rentBills.Clear();
            electricBills.Clear();
            totalBills.Clear();

            handleStats(dateNow);

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(+1);
            string dateNow = currentDate.ToString("MM/01/yyyy");
            lblDate.Text = dateNow;

            rentBills.Clear();
            electricBills.Clear();
            totalBills.Clear();

            handleStats(dateNow);
        }
        private void handleStats(string dateNow)
        {
            List<Bills> getAllBills()
            {
                List<Bills> returnThese = new List<Bills>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT BillingId, RentType, ElectricBill, " +
                    "Rent, Total, DueDate, Date, Status, tennants_ID FROM billing " +
                    "WHERE `DueDate` = @dueDate AND `Status` = @status", connection);

                command.Parameters.AddWithValue("@dueDate", dateNow);
                command.Parameters.AddWithValue("@status", "Paid");

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bills bills = new Bills
                        {
                            BillingID = reader.GetInt32(0),
                            RentType = reader.GetString(1),
                            ElectricBill = reader.IsDBNull(2) ? null : reader.GetInt32(2),
                            RentBill = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                            Total = reader.GetInt32(4),
                            DueDate = reader.GetString(5),
                            Date = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Status = reader.GetString(7),
                            tennants_ID = reader.GetInt32(8),

                        };

                        returnThese.Add(bills);

                    }

                }

                connection.Close();
                return returnThese;
            }

            List<Bills> bills = getAllBills();

            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("BillingID");
            dataTable2.Columns.Add("RentType");
            dataTable2.Columns.Add("RentBill");
            dataTable2.Columns.Add("ElectricBill");
            dataTable2.Columns.Add("Total");
            dataTable2.Columns.Add("DueDate");
            dataTable2.Columns.Add("Date");
            dataTable2.Columns.Add("Status");

            foreach (Bills bill in bills)
            {
                DataRow row = dataTable2.NewRow();
                var date =
                row["BillingID"] = bill.BillingID;
                row["RentType"] = bill.RentType;
                row["RentBill"] = bill.RentBill;
                row["ElectricBill"] = bill.ElectricBill;
                row["Total"] = bill.Total;
                row["DueDate"] = bill.DueDate;
                row["Date"] = bill.Date;
                row["Status"] = bill.Status;

                if (bill.RentBill.HasValue && bill.ElectricBill.HasValue)
                {
                    int rentBill = bill.RentBill.Value;
                    rentBills.Add(rentBill);

                    int electricBill = bill.ElectricBill.Value;
                    electricBills.Add(electricBill);

                    int totalBill = bill.Total;
                    totalBills.Add(totalBill);
                }
                else if (!bill.RentBill.HasValue && bill.ElectricBill.HasValue)
                {
                    int electricBill = bill.ElectricBill.Value;
                    electricBills.Add(electricBill);

                    int totalBill = bill.Total;
                    totalBills.Add(totalBill);
                }
                else if (bill.RentBill.HasValue && !bill.ElectricBill.HasValue)
                {
                    int rentBill = bill.RentBill.Value;
                    rentBills.Add(rentBill);

                    int totalBill = bill.Total;
                    totalBills.Add(totalBill);
                }
                else
                {
                    // Handle null value here
                }


                dataTable2.Rows.Add(row);
            }

            int totalRentBills = rentBills.Sum();
            lableRentBill.Text = totalRentBills.ToString();

            int totalElectricBills = electricBills.Sum();
            lableElectricBill.Text = totalElectricBills.ToString();

            int overAllBills = totalBills.Sum();
            lableTotalBill.Text = overAllBills.ToString();

            dataGridView2.DataSource = dataTable2;
        }
    }
}
