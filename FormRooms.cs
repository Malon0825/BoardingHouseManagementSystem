using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class FormRooms : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        string room_location;
        string room_description;
        public FormRooms()
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

        public class Rooms
        {
            public int ID { get; set; }
            public string RoomNumber { get; set; }
            public string RoomLocation { get; set; }
            public string RoomDescription { get; set; }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateRoom());

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public class SearchRoom
        {
            public int ID { get; set; }
            public string RoomNumber { get; set; }
            public string RoomType { get; set; }
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

        private void dataSearchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowCliked = dataGridView.CurrentRow.Index;
            String roomname = dataGridView.Rows[rowCliked].Cells[1].Value.ToString();

            List<Rooms> getAllUsers()
            {
                List<Rooms> returnThese = new List<Rooms>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM rooms WHERE RoomNumber = @roomname", connection);
                command.Parameters.AddWithValue("roomname", roomname);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rooms user = new Rooms
                        {
                            ID = reader.GetInt32(0),
                            RoomNumber = reader.GetString(1),
                            RoomLocation = reader.GetString(2),
                            RoomDescription = reader.GetString(3),

                        };

                        returnThese.Add(user);

                    }

                }

                connection.Close();
                return returnThese;
            }

            List<Rooms> users = getAllUsers();

            foreach (Rooms user in users)
            {
                String room_name = user.RoomNumber;
                room_location = user.RoomLocation;
                room_description = user.RoomDescription;

                labelRoomName.Text = room_name;

            }

            // Get Beds Table
            int rowIDCliked = dataGridView.CurrentRow.Index;
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

            // Get Tennants Table
            List<Tennant> getAllTennants()
            {
                List<Tennant> returnThese = new List<Tennant>();

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM tennants WHERE rooms_ID = @roomid", connection);
                command.Parameters.AddWithValue("roomid", roomid);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tennant t = new Tennant
                        {
                            ID = reader.GetInt32(0),
                            TennantName = reader.GetString(1),

                        };

                        returnThese.Add(t);

                    }

                }

                connection.Close();
                return returnThese;
            }

            List<Tennant> tennants = getAllTennants();

            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("ID");
            dataTable2.Columns.Add("TennantName");

            foreach (Tennant tennant in tennants)
            {
                DataRow row = dataTable2.NewRow();
                row["ID"] = tennant.ID;
                row["TennantName"] = tennant.TennantName;


                dataTable2.Rows.Add(row);
            }

            dataTennantsList.DataSource = dataTable2;
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

        private void buttonDescription_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Location: " + room_location);
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Description: " + room_description);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditRoom());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteRoom());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void iconClose_Click(object sender, EventArgs e)
        {

        }

        private void buttonDescription_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Description: " + room_description);
        }

        private void buttonLocation_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Location: " + room_location);
        }
    }

}

