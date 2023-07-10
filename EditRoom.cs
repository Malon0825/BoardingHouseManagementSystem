using ManagementSystem.Resources;
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
    public partial class EditRoom : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public EditRoom(FormRooms frm1)
        {
            InitializeComponent();

            this.frm1 = frm1;

            cbRoomType.Items.Add("Whole Room");
            cbRoomType.Items.Add("Bed Spacer");
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
            string roomType = cbRoomType.Text;
            string roomDescription = textAddDescription.Text;

            if (!string.IsNullOrWhiteSpace(roomName) && !string.IsNullOrWhiteSpace(roomType) && !string.IsNullOrWhiteSpace(roomLocation) && !string.IsNullOrWhiteSpace(roomDescription))
            {
                try
                {
                    string query = "INSERT INTO `rooms` (`ID`, `RoomNumber`, `RoomType`, `RoomLocation`, `RoomDescription`, `RentalFee`) VALUES(NULL, @roomName, @roomType, @roomLocation, @roomDescription, @rentalFee)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@roomName", roomName);
                    command.Parameters.AddWithValue("@roomType", roomType);
                    command.Parameters.AddWithValue("@roomLocation", roomLocation);
                    command.Parameters.AddWithValue("@roomDescription", roomDescription);

                    if(roomType == "Whole Room")
                    {
                        command.Parameters.AddWithValue("@rentalFee", "3500");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@rentalFee", "500");
                    }
                   

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
            this.frm1.UpdateDataGridViewFunc();
            this.Close();
        }
        private FormRooms frm1;

        private void textAddName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void textAddLocation_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textAddDescription_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
