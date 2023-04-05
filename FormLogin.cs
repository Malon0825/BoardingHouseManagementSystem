using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class FormLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            textPassword.PasswordChar = '*';
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (textUsername.Text == "user" && textPassword.Text == "password")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you enter is incorrect.");
                textUsername.Clear();
                textPassword.Clear();
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isCensored = true;

        private void iconHide_Click(object sender, EventArgs e)
        {
            if (isCensored)
            {
                textPassword.PasswordChar = '\0';
                isCensored = false;
            }
            else
            {
                textPassword.PasswordChar = '*';
                isCensored = true;
            }
        }
    }
}
