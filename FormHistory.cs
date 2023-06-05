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
    public partial class FormHistory : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        DateTime currentDate = DateTime.Now;
        int rowCountRoom;
        int rowCountBed;
        int rowCountTennant;
        public FormHistory()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();
                string query = "SELECT ID, TennantName FROM tennants";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }

                string query1 = "SELECT COUNT(*) FROM rooms";
                MySqlCommand command1 = new MySqlCommand(query1, connection);

                rowCountRoom = Convert.ToInt32(command1.ExecuteScalar());
                lableTotalRoom.Text = rowCountRoom.ToString();

                string query2 = "SELECT COUNT(*) FROM beds";
                MySqlCommand command2 = new MySqlCommand(query2, connection);

                rowCountBed = Convert.ToInt32(command2.ExecuteScalar());
                lableTotalBed.Text = rowCountBed.ToString();

                string query3 = "SELECT COUNT(*) FROM tennants";
                MySqlCommand command3 = new MySqlCommand(query3, connection);

                rowCountTennant = Convert.ToInt32(command3.ExecuteScalar());
                lableTotalTent.Text = rowCountTennant.ToString();
            }
        }
        public class SearchRoom
        {
            public int ID { get; set; }
            public string TennantName { get; set; }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<SearchRoom> getSearchRooms(String searchTerm)
            {
                List<SearchRoom> returnThese = new List<SearchRoom>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                String searchWildPhrase = "%" + searchTerm + "%";

                MySqlCommand command = new MySqlCommand();
                command.CommandText = "Select ID, TennantName FROM tennants WHERE TennantName LIKE @search";
                command.Parameters.AddWithValue("@search", searchWildPhrase);
                command.Connection = connection;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SearchRoom room = new SearchRoom
                        {
                            ID = reader.GetInt32(0),
                            TennantName = reader.GetString(1),
                        };

                        returnThese.Add(room);

                    }

                }

                connection.Close();
                return returnThese;
            }

            string searchTerm = textSearchTennant.Text;
            List<SearchRoom> rooms = getSearchRooms(searchTerm);
            dataGridView1.DataSource = rooms;
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            string formattedDate = currentDate.ToString("MM/dd/yyyy");

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

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView2 = (DataGridView)sender;

            int rowCliked = dataGridView2.CurrentRow.Index;
            String billingID = dataGridView2.Rows[rowCliked].Cells[0].Value.ToString();

            BillingStatus billVal = new BillingStatus(billingID, this);
            billVal.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView1 = (DataGridView)sender;

            int rowCliked = dataGridView1.CurrentRow.Index;
            String billingID = dataGridView1.Rows[rowCliked].Cells[0].Value.ToString();

            List<Bills> getAllBills()
            {
                List<Bills> returnThese = new List<Bills>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM billing WHERE tennants_ID = @id", connection);
                command.Parameters.AddWithValue("id", billingID);

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

                        };

                        returnThese.Add(t);

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
            dataTable2.Columns.Add("Balanced");
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
                row["Balanced"] = bill.Balanced;
                row["DueDate"] = bill.DueDate;
                row["Date"] = bill.Date;
                row["Status"] = bill.Status;

                dataTable2.Rows.Add(row);
            }

            dataGridView2.DataSource = dataTable2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
        public void UpdateDataGridViewFunc()
        {
            // Code to update the DataGridView
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();
                string query = "SELECT ID, TennantName FROM tennants";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                }

            }
        }
    }
}
