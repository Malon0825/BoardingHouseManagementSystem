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
using System.Windows.Input;

namespace ManagementSystem
{
    public partial class FormBills : Form
    {

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";

        DateTime currentDate = DateTime.Now;
        string tentId;
        string rentType;
        int rentInt;
        int total;
        string tennantName;
        int cashInt;
        int changeInt;
        int? deposit;
        int newDeposit;

        int balance = 0;

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
            public int? Deposit { get; set; }
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
                command.CommandText = "Select * FROM tennants WHERE TennantName LIKE @search";
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
            string rent = textRentBill.Text;
            string cash = textBox2.Text;
            string depositLocal = textBoxDeposit.Text;
            int depositNullInt = deposit ?? 0;

            rentType = comboBox1.Text;
            tennantName = labelName.Text;

            

            if (!string.IsNullOrEmpty(rentType) && tennantName != "None" && !string.IsNullOrEmpty(rent))
            {
                rentInt = int.Parse(rent);
                total = rentInt;

                if (string.IsNullOrEmpty(depositLocal) && !string.IsNullOrEmpty(cash))
                {
                    cashInt = int.Parse(cash);
                    changeInt = cashInt - rentInt;
                    AddTennantBill(changeInt);
                }
                else if (!string.IsNullOrEmpty(depositLocal) && string.IsNullOrEmpty(cash))
                {                   
                    int depositInt = int.Parse(depositLocal);
                    int newDepositLocal = depositNullInt - depositInt;

                    if (depositNullInt >= depositInt)
                    {
                        if (newDepositLocal < 0)
                        {
                            MessageBox.Show("Insufficient deposit amount.");
                        } 
                        else
                        {
                            newDeposit = newDepositLocal;
                            cashInt = depositInt;
                            changeInt = cashInt - rentInt;
                            AddDepositTennantBill(changeInt);
                        }
                    }




                }
                else if (!string.IsNullOrEmpty(depositLocal) && !string.IsNullOrEmpty(cash))
                {
                    int depositInt = int.Parse(depositLocal);
                    int newDepositLocal = depositNullInt - depositInt;
                    if (depositNullInt >= depositInt)
                    {
                        if (newDepositLocal < 0)
                        {
                            MessageBox.Show("Insufficient deposit amount.");
                        }
                        else
                        {
                            int newCashInt = int.Parse(cash);
                            cashInt = depositInt + newCashInt;
                            changeInt = cashInt - rentInt;
                            AddDepositTennantBill(changeInt);
                        }

                    }

                }
                else
                {
                    MessageBox.Show("No cash available.");
                }
            }
            else
            {
                MessageBox.Show("Please check the fields to continue.");
            }


        }

        string query = "INSERT INTO `billing` (`BillingId`, `RentType`, `ElectricBill`, `Rent`, `Total`, `Balance`, `DueDate`, `Date`, `Status`, `tennants_ID`) " +
                "VALUES(NULL, @rentType, NULL, @rentBills, @total, @balance, @dueDate, @date, @status, @tentId)";

        string query2 = "UPDATE `tennants` SET `Deposit` = @deposit WHERE ID = @tenantID";

        private void AddTennantBill(int change)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            string monthYearDate = currentDate.ToString("MM/01/yyyy");

            try
            {

                if (changeInt >= 0)
                {
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@rentBills", rentInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Paid");

                    command.ExecuteNonQuery();

                    labelChange.Text = changeInt.ToString();

                    FormReciept formReciept = new FormReciept(tennantName, rentType, rentInt, total, deposit, cashInt, change, balance);
                    formReciept.Show();
                }
                else if (changeInt < 0)
                {
                    MySqlCommand command = new MySqlCommand(query, connection);


                    int positiveChange = changeInt * -1;

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@rentBills", rentInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@balance", positiveChange);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

                    command.ExecuteNonQuery();

                    MessageBox.Show("Balanced payment has been added.");
                }


            }
            catch (MySqlException ex)
            {
                // Handle the exception here
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textRentBill.Clear();
                comboBox1.Items.Clear();
                textBox2.Clear();
                comboBox1.Items.Add("Bed");
                comboBox1.Items.Add("Room");
            }
            connection.Close();
        }

        private void AddDepositTennantBill(int change)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            string monthYearDate = currentDate.ToString("MM/01/yyyy");

            try
            {

                if (changeInt >= 0)
                {
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@rentBills", rentInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Paid");

                    command.ExecuteNonQuery();

                    MySqlCommand command2 = new MySqlCommand(query2, connection);

                    command2.Parameters.AddWithValue("@deposit", newDeposit);
                    command2.Parameters.AddWithValue("@tenantID", tentIdInt);

                    command2.ExecuteNonQuery();

                    labelChange.Text = changeInt.ToString();

                    FormReciept formReciept = new FormReciept(tennantName, rentType, rentInt, total, deposit, cashInt, newDeposit, balance);
                    formReciept.Show();
                }
                else if (changeInt < 0)
                {
                    MySqlCommand command = new MySqlCommand(query, connection);


                    int positiveChange = changeInt * -1;

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@rentBills", rentInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@balance", positiveChange);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

                    command.ExecuteNonQuery();

                    MySqlCommand command2 = new MySqlCommand(query2, connection);

                    command2.Parameters.AddWithValue("@deposit", newDeposit);
                    command2.Parameters.AddWithValue("@tenantID", tentIdInt);

                    command2.ExecuteNonQuery();

                    MessageBox.Show("Balanced payment has been added.");
                }


            }
            catch (MySqlException ex)
            {
                // Handle the exception here
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textRentBill.Clear();
                comboBox1.Items.Clear();
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

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void dataSearchList_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

            List<Tennant> tennants = getAllTennants();

            foreach (Tennant tennant in tennants)
            {
                tentId = tennant.ID.ToString();
                labelName.Text = tennant.TennantName;
                deposit = tennant.Deposit;

            }
        }

        private void textRentBill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
