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
    public partial class DeleteRoom : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public DeleteRoom(FormRooms frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            int roomId;

            if (int.TryParse(textId.Text, out roomId))
            {
                try
                {
                    string query = "DELETE FROM `rooms` WHERE `ID` = @roomId";
                    MySqlCommand command = new MySqlCommand(query, connection);

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
                    MessageBox.Show("Successful!!" + Environment.NewLine + "The room with ID " + roomId + " has been deleted.");
                }
                textId.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid room ID.");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.frm1.UpdateDataGridViewFunc();
            this.Close();
        }
        private FormRooms frm1;
    }
}
