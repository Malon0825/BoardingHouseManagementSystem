using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace ManagementSystem
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            UpdateRegion();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSideMenu.Controls.Add(leftBorderBtn);

            OpenChildForm(new FormHistory());

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void UpdateRegion()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(204, 212, 191);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.Black;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.Black;


            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(238, 186, 178);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHomeBg.Controls.Add(childForm);
            panelHomeBg.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(238, 186, 178));
            OpenChildForm(new FormHistory());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(238, 186, 178));
            OpenChildForm(new FormRooms());
        }

        private void bedBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(238, 186, 178));
            OpenChildForm(new FormBeds());
        }

        private void tenantBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(238, 186, 178));
            OpenChildForm(new FormTenants());
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(238, 186, 178));
            OpenChildForm(new FormBills());
        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Remove transparent border in maximized state
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHomeBg_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(238, 186, 178));
            OpenChildForm(new FormHistory());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            new FormStats().Show();
        }

        private void panelHomeBg_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}