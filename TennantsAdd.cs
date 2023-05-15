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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ManagementSystem
{
    public partial class TennantsAdd : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        int roomID;
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
            public bool Occupancy { get; set; }

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

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string name = textname.Text;
            string age = textage.Text;
            string email = textemail.Text;
            string address = textaddress.Text;
            int occupancy = 1;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(age) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(address))
            {
                int selectedBedID = (int)cbBedName.SelectedValue;
                try
                {
                    string query = "INSERT INTO `tennants` (`ID`, `TennantName`, `TennantAge`, `TennantEmail`, `TennantAddress`, `rooms_ID`, `beds_ID`) " +
                        "VALUES(NULL, @name, @age, @email, @address, @roomid, @bedid)";
                    MySqlCommand command = new MySqlCommand(query, connection);


                    string query2 = "UPDATE `beds` SET `Occupancy`= @occupancy WHERE ID = @bedid";
                    MySqlCommand command2 = new MySqlCommand(query2, connection);

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@roomid", roomID);
                    command.Parameters.AddWithValue("@bedid", selectedBedID);
                    command.Parameters.AddWithValue("@occupancy", occupancy);

                    command2.Parameters.AddWithValue("@bedid", selectedBedID);
                    command2.Parameters.AddWithValue("@occupancy", occupancy);



                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Handle the exception here
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Successful!!" + Environment.NewLine + "New tennant has been added.");
                    textname.Clear();
                    textage.Clear();
                    textemail.Clear();
                    textaddress.Clear();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding a room.");
            }

            connection.Close();
            
        }

        private void cbBedName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRoomName_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is not a number or a control character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Set Handled to true to prevent the character from being entered
                e.Handled = true;
            }
        }
    }
}
