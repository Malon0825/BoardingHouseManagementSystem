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
using static ManagementSystem.BedsAdd;

namespace ManagementSystem
{
    public partial class TennantsAdd : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public TennantsAdd()
        {
            InitializeComponent();
            List<Room> rooms = GetAllRooms();

            foreach (Room room in rooms)
            {
                cbRoomName.DataSource = rooms;
                cbRoomName.DisplayMember = "RoomName";
                cbRoomName.ValueMember = "ID";
            }

        }

        public class Bed
        {
            public int ID { get; set; }
            public string BedName { get; set; }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Room> GetAllRooms()
        {
            List<Room> returnThese = new List<Room>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ID, RoomName FROM rooms", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Room b = new Room
                    {
                        ID = reader.GetInt32(0),
                        RoomName = reader.GetString(1),

                    };

                    returnThese.Add(b);

                }

            }

            connection.Close();
            return returnThese;

        }
        private List<Bed> GetAllBed()
        {
            List<Bed> returnThese = new List<Bed>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ID, BedName FROM beds", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Bed t = new Bed
                    {
                        ID = reader.GetInt32(0),
                        BedName = reader.GetString(1),

                    };

                    returnThese.Add(t);

                }

            }

            connection.Close();
            return returnThese;

        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            //string bedName = textAddBedName.Text;
            //string roomname = cbRoomName.Text;
            //int selectedRoomID = (int)cbRoomName.SelectedValue;
            //int occupancy = 0;

            //if (!string.IsNullOrWhiteSpace(bedName) && !string.IsNullOrWhiteSpace(roomname))
            //{
            //    try
            //    {
            //        string query = "INSERT INTO `beds` (`ID`, `BedName`, `rooms_ID`, `Occupancy`) VALUES(NULL, @bedName, @roomID, @occupancy)";
            //        MySqlCommand command = new MySqlCommand(query, connection);

            //        command.Parameters.AddWithValue("@bedName", bedName);
            //        command.Parameters.AddWithValue("@occupancy", occupancy);
            //        command.Parameters.AddWithValue("@roomID", selectedRoomID);

            //        command.ExecuteNonQuery();
            //    }
            //    catch (MySqlException ex)
            //    {
            //        // Handle the exception here
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        MessageBox.Show("Successful!!" + Environment.NewLine + "The " + bedName + " has been added.");
            //        textAddBedName.Clear();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please fill in all fields before adding a room.");
            //}

            //connection.Close();
        }

        private void cbBedName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Bed> beds = GetAllBed();

            foreach (Bed bed in beds)
            {
                cbBedName.DataSource = beds;
                cbBedName.DisplayMember = "BedName";
                cbBedName.ValueMember = "ID";
            }
        }
    }
}
