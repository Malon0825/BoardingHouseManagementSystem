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

namespace ManagementSystem
{
    public partial class EditRoom : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public EditRoom()
        {
            InitializeComponent();
        }
        private void EditRoom_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string roomName = textAddName.Text;
            string roomLocation = textAddLocation.Text;
            string roomDescription = textAddDescription.Text;

            if (!string.IsNullOrWhiteSpace(roomName) && !string.IsNullOrWhiteSpace(roomLocation) && !string.IsNullOrWhiteSpace(roomDescription))
            {
                try
                {
                    string query = "INSERT INTO `rooms` (`ID`, `RoomNumber`, `RoomLocation`, `RoomDescription`) VALUES(NULL, @roomName, @roomLocation, @roomDescription)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@roomName", roomName);
                    command.Parameters.AddWithValue("@roomLocation", roomLocation);
                    command.Parameters.AddWithValue("@roomDescription", roomDescription);

                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Handle the exception here
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    {
                        MessageBox.Show("Successful!!" + Environment.NewLine + "The " + roomName + " has been added.");
                    }
                    textAddName.Clear();
                    textAddLocation.Clear();
                    textAddDescription.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding a room.");
            }

            connection.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGoback_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
