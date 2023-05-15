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
    public partial class TennantsDelete : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=management_system;";
        public TennantsDelete()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            int Id;

            if (int.TryParse(textId.Text, out Id))
            {
                try
                {
                    string query = "DELETE FROM `tennants` WHERE `ID` = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Id", Id);

                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Handle the exception here
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Successful!!" + Environment.NewLine + "The tennant has been deleted.");
                }
                textId.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid room ID.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
