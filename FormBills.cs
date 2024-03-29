﻿using MySql.Data.MySqlClient;
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
        string query = "INSERT INTO `billing` (`BillingId`, `RentType`, `ElectricBill`, `Rent`, `Total`, `Deposit`, `Balance`, `DueDate`, `Date`, `tennants_ID`, `Status`) " +
                        "VALUES(NULL, @rentType, @electricBill, @rentBills, @total, @deposit, @balance, @dueDate, @date, @tentId, @status)";
        DateTime currentDate = DateTime.Now;
        string tentId;
        string rentType;
        string electricBill;
        string rentBill;
        int total;
        int depositHolder;
        string tennantName;
        int cashInt;
        int change;

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
            string cash = textBox2.Text;
            string totalVal = textTotal.Text;
            string deposit = textBoxDeposit.Text;
            rentType = comboBox1.Text;
            tennantName = labelName.Text;

            if (!string.IsNullOrEmpty(rentType) && !string.IsNullOrEmpty(tennantName))
            {
                if (!string.IsNullOrEmpty(totalVal))
                {
                    int intTotalValue = int.Parse(totalVal);
                    if (intTotalValue != 0)
                    {
                        if (!string.IsNullOrEmpty(cash))
                        {
                            if (!string.IsNullOrEmpty(deposit))
                            {
                                cashInt = int.Parse(cash);
                                int newDeposit = int.Parse(deposit);

                                change = cashInt - total;

                                int newTotal = total + newDeposit;
                                int newChange = cashInt - newTotal;

                                if (change <= 0)
                                {
                                    labelChange.Text = change.ToString();
                                    int balanced = change * -1;
                                    string bal = balanced.ToString();
                                    addTennantBillBalance(int.Parse(bal));
                                }
                                else
                                {
                                    labelChange.Text = newChange.ToString();

                                    if (!string.IsNullOrEmpty(deposit))
                                    {
                                        addTennantBill(int.Parse(deposit));
                                    }
                                    else
                                    {
                                        addTennantBill(0);
                                    }


                                }
                            }
                            else
                            {
                                cashInt = int.Parse(cash);

                                change = cashInt - total;

                                if (change < 0)
                                {
                                    labelChange.Text = change.ToString();
                                    int balanced = change * -1;
                                    string bal = balanced.ToString();
                                    addTennantBillBalance(int.Parse(bal));
                                }
                                else
                                {
                                    labelChange.Text = change.ToString();

                                    if (!string.IsNullOrEmpty(deposit))
                                    {
                                        addTennantBill(int.Parse(deposit));
                                    }
                                    else
                                    {
                                        addTennantBill(0);
                                    }


                                }
                            }


                        }
                        else
                        {
                            addTennantBillUnpaid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input the bills first!!");
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
        private void addTennantBill(int deposit)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            string monthYearDate = currentDate.ToString("MM/01/yyyy");
            int electricBillInt;
            int rentBillInt;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                rentBill = textRentBill.Text;

                if (string.IsNullOrEmpty(rentBill) && !string.IsNullOrEmpty(electricBill))
                {
                    electricBillInt = int.Parse(electricBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", electricBillInt);
                    command.Parameters.AddWithValue("@rentBills", null);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@deposit", deposit);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Paid");

                    command.ExecuteNonQuery();

                    FormReciept formReciept = new FormReciept(tennantName, rentType, null, electricBillInt, total, deposit, cashInt, change);
                    formReciept.Show();

                }
                else if (string.IsNullOrEmpty(electricBill) && !string.IsNullOrEmpty(rentBill))
                {
                    rentBillInt = int.Parse(rentBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", null);
                    command.Parameters.AddWithValue("@rentBills", rentBillInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@deposit", deposit);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Paid");

                    command.ExecuteNonQuery();

                    FormReciept formReciept = new FormReciept(tennantName, rentType, rentBillInt, null, total, deposit, cashInt, change);
                    formReciept.Show();


                }
                else if (!string.IsNullOrEmpty(electricBill) && !string.IsNullOrEmpty(rentBill))
                {
                    rentBillInt = int.Parse(rentBill);
                    electricBillInt = int.Parse(electricBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", electricBillInt);
                    command.Parameters.AddWithValue("@rentBills", rentBillInt);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@deposit", deposit);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", formattedDate);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Paid");

                    command.ExecuteNonQuery();

                    FormReciept formReciept = new FormReciept(tennantName, rentType, rentBillInt, electricBillInt, total, deposit, cashInt, change);
                    formReciept.Show();
                }
                else
                {
                    MessageBox.Show("Please click save button first.");
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
                textBox4.Clear();
                comboBox1.Items.Clear();
                textBox2.Clear();
                comboBox1.Items.Add("Bed");
                comboBox1.Items.Add("Room");
            }
            connection.Close();
        }

        private void addTennantBillUnpaid()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string monthYearDate = currentDate.ToString("MM/01/yyyy");
            int electricBillInt;
            int rentBillInt;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                rentBill = textRentBill.Text;

                if (string.IsNullOrEmpty(rentBill) && !string.IsNullOrEmpty(electricBill))
                {
                    electricBillInt = int.Parse(electricBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", electricBillInt);
                    command.Parameters.AddWithValue("@rentBills", null);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@deposit", depositHolder);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", null);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

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
                    command.Parameters.AddWithValue("@deposit", depositHolder);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", null);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

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
                    command.Parameters.AddWithValue("@deposit", depositHolder);
                    command.Parameters.AddWithValue("@balance", null);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", null);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

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
                MessageBox.Show("Unpaid payment has been added.");
                textRentBill.Clear();
                textBox4.Clear();
                comboBox1.Items.Clear();
                textBox2.Clear();
                comboBox1.Items.Add("Bed");
                comboBox1.Items.Add("Room");
            }
            connection.Close();
        }
        private void addTennantBillBalance(int change)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string monthYearDate = currentDate.ToString("MM/01/yyyy");
            int electricBillInt;
            int rentBillInt;

            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                rentBill = textRentBill.Text;

                if (string.IsNullOrEmpty(rentBill) && !string.IsNullOrEmpty(electricBill))
                {
                    electricBillInt = int.Parse(electricBill);

                    int tentIdInt = int.Parse(tentId);

                    command.Parameters.AddWithValue("@rentType", rentType);
                    command.Parameters.AddWithValue("@electricBill", electricBillInt);
                    command.Parameters.AddWithValue("@rentBills", null);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@deposit", depositHolder);
                    command.Parameters.AddWithValue("@balance", change);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", null);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

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
                    command.Parameters.AddWithValue("@deposit", depositHolder);
                    command.Parameters.AddWithValue("@balance", change);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", null);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

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
                    command.Parameters.AddWithValue("@deposit", depositHolder);
                    command.Parameters.AddWithValue("@balance", change);
                    command.Parameters.AddWithValue("@dueDate", monthYearDate);
                    command.Parameters.AddWithValue("@date", null);
                    command.Parameters.AddWithValue("@tentId", tentIdInt);
                    command.Parameters.AddWithValue("@status", "Unpaid");

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
                MessageBox.Show("With balanced payment has been added.");
                textRentBill.Clear();
                textBox4.Clear();
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
            else if(!string.IsNullOrEmpty(electricBill) && !string.IsNullOrEmpty(rentBill))
            {
                int rentBillInt = int.Parse(rentBill);
                int electricBillInt = int.Parse(electricBill);

                total = rentBillInt + electricBillInt;

                textTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please input the bills first.");
            }
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

        private void textRentBill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
