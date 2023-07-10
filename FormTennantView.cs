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
    public partial class FormTennantView : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public FormTennantView(string tennantId)
        {
            InitializeComponent();

            List<Bills> getAllBills()
            {
                List<Bills> returnThese = new List<Bills>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM billing WHERE tennants_ID = @id", connection);
                command.Parameters.AddWithValue("id", tennantId);

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void FormTennantView_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView2 = (DataGridView)sender;

            int rowCliked = dataGridView2.CurrentRow.Index;
            String billingID = dataGridView2.Rows[rowCliked].Cells[0].Value.ToString();

            BillingStatus billVal = new BillingStatus(billingID, this);
            billVal.Show();
        }
    }
}
