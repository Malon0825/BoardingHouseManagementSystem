using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Policy;

namespace ManagementSystem
{
    public partial class FormBills : Form
    {

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        DateTime currentDate = DateTime.Now;
        string tentId;
        string rentType;
        string electricBill;
        string rentBill;
        int total;



        public FormBills()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();
                string query = "SELECT ID, TennantName FROM tennants";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query and load the data into a DataTable
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataSearchList.DataSource = dataTable;
                }
                comboBox1.Items.Add("Bed");
                comboBox1.Items.Add("Room");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelBedName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public class SearchRoom
        {
            public int ID { get; set; }
            public string TennantName { get; set; }
        }

        internal class Tennant
        {
            public int ID { get; set; }
            public string TennantName { get; set; }
            public int TennantAge { get; set; }
            public string TennantEmail { get; set; }
            public string TennantAddress { get; set; }
            public int rooms_ID { get; set; }
            public int beds_ID { get; set; }

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
            dataSearchList.DataSource = rooms;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRentBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void textSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string discount = textSearchName.Text;
            string cash = textBox2.Text;
            string totalVal = textTotal.Text;
            rentType = comboBox1.Text;
            string tennantName = labelName.Text;

            if (!string.IsNullOrEmpty(rentType) && !string.IsNullOrEmpty(tennantName))
            {
                if (!string.IsNullOrEmpty(totalVal))
                {
                    if (string.IsNullOrEmpty(discount) && !string.IsNullOrEmpty(cash))
                    {
                        int cashInt = int.Parse(cash);

                        int change = cashInt - total;

                        if (change < 0)
                        {
                            labelChange.Text = change.ToString();
                            MessageBox.Show("Insufficient cash amount");
                        }
                        else
                        {
                            labelChange.Text = change.ToString();
                            addTennantBill();
                        }

                    }
                    else if (!string.IsNullOrEmpty(discount) && string.IsNullOrEmpty(cash))
                    {
                        MessageBox.Show("Please input the cash amount!!");
                    }
                    else if (!string.IsNullOrEmpty(discount) && !string.IsNullOrEmpty(cash))
                    {
                        int discountInt = int.Parse(discount);
                        int cashInt = int.Parse(cash);

                        int discountedBill = total - discountInt;

                        int change = cashInt - discountedBill;

                        if (change < 0)
                        {
                            labelChange.Text = change.ToString();
                            MessageBox.Show("Insufficient cash amount");
                        }
                        else
                        {
                            labelChange.Text = change.ToString();
                            addTennantBill();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check the cash amount if correct!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input the bills first!!");
                }
            }
            else
            {
                MessageBox.Show("Please check the tennant and rent type to continue.");
            }





        }
        private void addTennantBill()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            int electricBillInt;
            int rentBillInt;

            try
            {
                string query = "INSERT INTO `billing` (`BillingId`, `RentType`, `ElectricBill`, `Rent`, `Total`, `Date`, `tennants_ID`) " +
                    "VALUES(NULL, @rentType, @electricBill, @rentBills, @total, @date, @tentId)";

                MySqlCommand command = new MySqlCommand(query, connection);



                if (string.IsNullOrEmpty(rentBill) && !string.IsNullOrEmpty(electricBill))
                {
                    electricBillInt = int.Parse(electricBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", electricBillInt);
                    command.Parameters.AddWithValue("@rentBills", null);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);

                    command.ExecuteNonQuery();



                }
                else if (string.IsNullOrEmpty(electricBill) && !string.IsNullOrEmpty(rentBill))
                {
                    rentBillInt = int.Parse(rentBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", null);
                    command.Parameters.AddWithValue("@rentBills", rentBillInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);

                    command.ExecuteNonQuery();


                }
                else
                {
                    rentBillInt = int.Parse(rentBill);
                    electricBillInt = int.Parse(electricBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", electricBillInt);
                    command.Parameters.AddWithValue("@rentBills", rentBillInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);

                    command.ExecuteNonQuery();

                }

            }
            catch (MySqlException ex)
            {
                // Handle the exception here
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Successful!!");
                textRentBill.Clear();
                textBox4.Clear();
                comboBox1.Items.Clear();
                textSearchName.Clear();
                textBox2.Clear();
                comboBox1.Items.Add("Bed");
                comboBox1.Items.Add("Room");
            }
            connection.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataSearchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowCliked = dataGridView.CurrentRow.Index;
            String tennantID = dataGridView.Rows[rowCliked].Cells[0].Value.ToString();

            List<Tennant> getAllTennants()
            {
                List<Tennant> returnThese = new List<Tennant>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM tennants WHERE ID = @id", connection);
                command.Parameters.AddWithValue("id", tennantID);

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
                            TennantAddress = reader.GetString(4),
                            rooms_ID = reader.GetInt32(5),
                            beds_ID = reader.GetInt32(6),


                        };

                        returnThese.Add(t);

                    }

                }

                connection.Close();
                return returnThese;
            }

            List<Tennant> tennants = getAllTennants();

            foreach (Tennant tennant in tennants)
            {
                tentId = tennant.ID.ToString();
                labelName.Text = tennant.TennantName;

            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            rentBill = textRentBill.Text;
            electricBill = textBox4.Text;

            if (string.IsNullOrEmpty(rentBill) && !string.IsNullOrEmpty(electricBill))
            {
                int electricBillInt = int.Parse(electricBill);

                total = electricBillInt;

                textTotal.Text = total.ToString();

            }
            else if (string.IsNullOrEmpty(electricBill) && !string.IsNullOrEmpty(rentBill))
            {
                int rentBillInt = int.Parse(rentBill);

                total = rentBillInt;

                textTotal.Text = total.ToString();
            }
            else
            {
                int rentBillInt = int.Parse(rentBill);
                int electricBillInt = int.Parse(electricBill);

                total = rentBillInt + electricBillInt;

                textTotal.Text = total.ToString();
            }
        }
    }
}
