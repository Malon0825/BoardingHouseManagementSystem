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

namespace ManagementSystem
{
    public partial class BedsAdd : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";

        public class Room
        {
            public int ID { get; set; }
            public string RoomNumber { get; set; }

        }

        private List<Room> GetAllRooms()
        {

            List<Room> returnThese = new List<Room>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ID, RoomNumber FROM rooms", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Room b = new Room
                    {
                        ID = reader.GetInt32(0),
                        RoomNumber = reader.GetString(1),

                    };

                    returnThese.Add(b);

                }

            }

            connection.Close();
            return returnThese;

        }

        public BedsAdd()
        {
            InitializeComponent();

            List<Room> rooms = GetAllRooms();

            foreach (Room room in rooms)
            {
                cbRoomName.DataSource = rooms;
                cbRoomName.DisplayMember = "RoomNumber";
                cbRoomName.ValueMember = "ID";
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string bedName = textAddBedName.Text;
            string roomname = cbRoomName.Text;
            int selectedRoomID = (int)cbRoomName.SelectedValue;
            int occupancy = 0;

            if (!string.IsNullOrWhiteSpace(bedName) && !string.IsNullOrWhiteSpace(roomname))
            {
                try
                {
                    string query = "INSERT INTO `beds` (`ID`, `BedName`, `rooms_ID`, `Occupancy`) VALUES(NULL, @bedName, @roomID, @occupancy)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@bedName", bedName);
                    command.Parameters.AddWithValue("@occupancy", occupancy);
                    command.Parameters.AddWithValue("@roomID", selectedRoomID);

                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Handle the exception here
                    MessageBox.Show(ex.Message);
                }
                finally
                {            
                    MessageBox.Show("Successful!!" + Environment.NewLine + "The " + bedName + " has been added.");
                    textAddBedName.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding a room.");
            }

            connection.Close();
        }

        private void cbRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
