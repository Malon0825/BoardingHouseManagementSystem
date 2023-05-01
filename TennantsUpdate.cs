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
    public partial class TennantsUpdate : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        int roomID;
        public TennantsUpdate()
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class Bed
        {
            public int ID { get; set; }
            public string BedName { get; set; }
            public bool Occupancy { get; set; }

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
            int occupancy = 0;

            MySqlCommand command = new MySqlCommand("SELECT ID, BedName, Occupancy FROM beds WHERE Occupancy = @occupancy AND rooms_ID = @roomID", connection);

            command.Parameters.AddWithValue("@roomID", roomID);
            command.Parameters.AddWithValue("@occupancy", occupancy);


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Bed t = new Bed
                    {
                        ID = reader.GetInt32(0),
                        BedName = reader.GetString(1),
                        Occupancy = reader.GetBoolean(2),

                    };

                    returnThese.Add(t);

                }

            }

            connection.Close();
            return returnThese;

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void cbRoomName_DropDownClosed(object sender, EventArgs e)
        {
            roomID = (int)cbRoomName.SelectedValue;
            List<Bed> beds = GetAllBed();

            foreach (Bed bed in beds)
            {
                cbBedName.DataSource = beds;
                cbBedName.DisplayMember = "BedName";
                cbBedName.ValueMember = "ID";
            }
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            int selectedBedID = (int)cbBedName.SelectedValue;

            int id;
            string name = textTennantName.Text;
            string bedid = selectedBedID.ToString();
            string roomid = roomID.ToString();
            int occupancy = 1;

            if (int.TryParse(textTennantID.Text, out id))
            {
                try
                {
                    string query = "UPDATE `tennants` SET ";

                    List<string> updates = new List<string>();

                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        updates.Add("`TennantName` = @name");
                    }
                    if (!string.IsNullOrEmpty(roomid))
                    {
                        updates.Add("`rooms_ID` = @roomid");
                    }
                    if (!string.IsNullOrWhiteSpace(bedid))
                    {
                        updates.Add("`beds_ID` = @bedid");
                    }
                    query += string.Join(", ", updates) + " WHERE `ID` = @id";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@roomid", roomid);
                    command.Parameters.AddWithValue("@bedid", bedid);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    string query2 = "UPDATE `beds` SET `Occupancy`= @occupancy WHERE ID = @bedid";
                    MySqlCommand command2 = new MySqlCommand(query2, connection);

                    command2.Parameters.AddWithValue("@bedid", selectedBedID);
                    command2.Parameters.AddWithValue("@occupancy", occupancy);

                    command2.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Handle the exception here
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Successful!!" + Environment.NewLine + "The tennant information has been updated.");
                }


            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }

            connection.Close();
        }
    }
}
