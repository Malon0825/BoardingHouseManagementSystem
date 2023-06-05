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
using static ManagementSystem.FormBeds;
using static ManagementSystem.FormRooms;

namespace ManagementSystem
{
    public partial class FormBeds : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public FormBeds()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();
                string query = "SELECT ID, RoomNumber, RoomType FROM rooms";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query and load the data into a DataTable
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataSearchList.DataSource = dataTable;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public class SearchRoom
        {
            public int ID { get; set; }
            public string RoomNumber { get; set; }
            public string RoomType { get; set; }

        }

        public class Bed
        {
            public int ID { get; set; }
            public string BedName { get; set; }
            public string Occupancy { get; set; }
        }

        public class Tennant
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
                command.CommandText = "Select ID, RoomNumber, RoomType FROM rooms WHERE RoomNumber LIKE @search";
                command.Parameters.AddWithValue("@search", searchWildPhrase);
                command.Connection = connection;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SearchRoom room = new SearchRoom
                        {
                            ID = reader.GetInt32(0),
                            RoomNumber = reader.GetString(1),
                            RoomType = reader.GetString(2),
                        };

                        returnThese.Add(room);

                    }

                }

                connection.Close();
                return returnThese;
            }

            string searchTerm = textSearchName.Text;
            List<SearchRoom> rooms = getSearchRooms(searchTerm);
            dataSearchList.DataSource = rooms;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
        public void UpdateDataGridViewFunc()
        {
            // Code to update the DataGridView
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();
                string query = "SELECT ID, RoomNumber, RoomType FROM rooms";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query and load the data into a DataTable
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataSearchList.DataSource = dataTable;
                    textSearchName.Clear();
                }
            }
        }

        private void dataSearchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSearchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelBedName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataBedsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            panelEdit.Controls.Add(childForm);
            panelEdit.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BedsAdd(this));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BedsUpdate(this));
        }

        private void dataSearchList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowCliked = dataGridView.CurrentRow.Index;
            String roomid = dataGridView.Rows[rowCliked].Cells[0].Value.ToString();

            List<Bed> getAllBeds()
            {
                List<Bed> returnThese = new List<Bed>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM beds WHERE rooms_ID = @roomid", connection);
                command.Parameters.AddWithValue("roomid", roomid);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bed b = new Bed
                        {
                            ID = reader.GetInt32(0),
                            BedName = reader.GetString(1),
                            Occupancy = reader.GetString(2),

                        };

                        returnThese.Add(b);

                    }

                }

                connection.Close();
                return returnThese;
            }

            List<Bed> beds = getAllBeds();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("BedName");
            dataTable.Columns.Add("Occupancy");

            foreach (Bed bed in beds)
            {
                DataRow row = dataTable.NewRow();

                var occ = bed.Occupancy;

                if (occ == "True")
                {
                    row["ID"] = bed.ID;
                    row["BedName"] = bed.BedName;
                    row["Occupancy"] = "Occupied";
                }
                else
                {
                    row["ID"] = bed.ID;
                    row["BedName"] = bed.BedName;
                    row["Occupancy"] = "Vacant";
                }


                dataTable.Rows.Add(row);
            }

            dataBedsList.DataSource = dataTable;
        }

        private void dataBedsList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowCliked = dataGridView.CurrentRow.Index;
            object cellValue = dataGridView.Rows[rowCliked].Cells[2].Value;
            string occupancy = cellValue == null ? "" : cellValue.ToString();
            if (occupancy == "Occupied")
            {

                String bedid = dataGridView.Rows[rowCliked].Cells[0].Value.ToString();

                List<Tennant> getAllTennants()
                {
                    List<Tennant> returnThese = new List<Tennant>();

                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM tennants WHERE beds_ID = @bedid", connection);
                    command.Parameters.AddWithValue("bedid", bedid);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tennant b = new Tennant
                            {
                                ID = reader.GetInt32(0),
                                TennantName = reader.GetString(1),

                            };

                            returnThese.Add(b);

                        }

                    }

                    connection.Close();
                    return returnThese;
                }
                List<Tennant> tennants = getAllTennants();
                foreach (Tennant tennant in tennants)
                {
                    lalebTennantName.Text = tennant.TennantName;
                }
            }
            else
            {
                lalebTennantName.Text = "Vacant Bed";
            }
        }
    }
}
