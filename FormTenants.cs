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
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class FormTenants : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public FormTenants()
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
            }
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

        public class SearchRoom
        {
            public int ID { get; set; }
            public string TennantName { get; set; }
        }

        public class Room
        {
            public string RoomName { get; set; }
        }

        public class Bed
        {
            public string BedName { get; set; }
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

            string searchTerm = textSearchName.Text;
            List<SearchRoom> rooms = getSearchRooms(searchTerm);
            dataSearchList.DataSource = rooms;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TennantsAdd(this));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TennantsUpdate(this));
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TennantsDelete(this));
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
                    // Execute the query and load the data into a DataTable
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataSearchList.DataSource = dataTable;
                }
            }
        }

        private void dataSearchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowCliked = dataGridView.CurrentRow.Index;
            String tennantID = dataGridView.Rows[rowCliked].Cells[0].Value.ToString();

            FormTennantView formTennantView = new FormTennantView(tennantID);
            formTennantView.Show();

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

            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("ID");
            dataTable2.Columns.Add("TennantName");
            dataTable2.Columns.Add("TennantAge");
            dataTable2.Columns.Add("TennantEmail");
            dataTable2.Columns.Add("TennantAddress");

            foreach (Tennant tennant in tennants)
            {
                DataRow row = dataTable2.NewRow();
                row["ID"] = tennant.ID;
                row["TennantName"] = tennant.TennantName;
                row["TennantAge"] = tennant.TennantAge;
                row["TennantEmail"] = tennant.TennantEmail;
                row["TennantAddress"] = tennant.TennantAddress;

                dataTable2.Rows.Add(row);

                int room_id = tennant.rooms_ID;
                int bed_id = tennant.beds_ID;

                List<Room> getRoom()
                {
                    List<Room> returnThese = new List<Room>();

                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM rooms WHERE ID = @id", connection);
                    command.Parameters.AddWithValue("id", room_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room r = new Room
                            {
                                RoomName = reader.GetString(1),
                            };
                            returnThese.Add(r);
                        }
                    }
                    connection.Close();
                    return returnThese;
                }
                List<Room> room = getRoom();

                foreach (Room r in room)
                {
                    labelRoom.Text = r.RoomName;
                }

                List<Bed> getBed()
                {
                    List<Bed> returnThese = new List<Bed>();

                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM beds WHERE ID = @id", connection);
                    command.Parameters.AddWithValue("id", bed_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bed t = new Bed
                            {
                                BedName = reader.GetString(1),
                            };
                            returnThese.Add(t);
                        }
                    }
                    connection.Close();
                    return returnThese;
                }
                List<Bed> bed = getBed();

                foreach (Bed b in bed)
                {
                    labelBed.Text = b.BedName;
                }

                dataBedsList.DataSource = dataTable2;

            }
        }

        private void labelRoom_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void labelBed_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
