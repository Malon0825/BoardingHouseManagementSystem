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
    public partial class UpdateRoom : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public UpdateRoom()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string roomName = textUpdateName.Text;
            string roomLocation = textUpdateLocation.Text;
            string roomDescription = textUpdateDescription.Text;
            int roomId;

            if (int.TryParse(textId.Text, out roomId))
            {
                try
                {
                    string query = "UPDATE `rooms` SET ";
                    List<string> updates = new List<string>();
                    if (!string.IsNullOrWhiteSpace(roomName))
                    {
                        updates.Add("`RoomNumber` = @roomName");
                    }
                    if (!string.IsNullOrWhiteSpace(roomLocation))
                    {
                        updates.Add("`RoomLocation` = @roomLocation");
                    }
                    if (!string.IsNullOrWhiteSpace(roomDescription))
                    {
                        updates.Add("`RoomDescription` = @roomDescription");
                    }
                    query += string.Join(", ", updates) + " WHERE `ID` = @roomId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@roomName", roomName);
                    command.Parameters.AddWithValue("@roomLocation", roomLocation);
                    command.Parameters.AddWithValue("@roomDescription", roomDescription);
                    command.Parameters.AddWithValue("@roomId", roomId);

                    command.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    // Handle the exception here
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Successful!!" + Environment.NewLine + "The room information has been updated.");
                }


            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }

            connection.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
