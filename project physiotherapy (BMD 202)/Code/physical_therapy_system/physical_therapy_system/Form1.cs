using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Diagnostics;

namespace physical_therapy_system
{

    public partial class Form1 : Form
    {

        bool drag = false;
        Point start_point = new Point(0, 0);
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        /* private static extern IntPtr CreateRoundRectRgn
             (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nButtomRect,
             int nWidthEllipse,
             int nHeightEllipse
             );*/
        //for the usercontrols (dashboard and rest pages)
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return pnlFormLoader; }
            set { pnlFormLoader = value; }
        }
        public Label Title
        {
            get { return lblTitle; }
            set { lblTitle = value; }
        }

        /*public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }*/



        public Form1()
        {

            InitializeComponent();
            this.ControlBox = false;

            //logIn nn = new logIn();
            //nn.Show();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(43, 53, 69);



           


        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnBack.Visible = false;
            _obj = this;
            ucDashboard d1 = new ucDashboard();
            d1.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(d1);

            label1.Text = logIn.username;
            label2.Text = logIn.role;


            }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(43, 53, 69);

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            ucDashboard d1 = new ucDashboard();
            d1.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(d1);

            /*lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard FrmDashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();*/


        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            btnCalendar.BackColor = Color.FromArgb(43, 53, 69);


            lblTitle.Text = "Calendar";
            this.pnlFormLoader.Controls.Clear();
            ucCalendar b2 = new ucCalendar();
            b2.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(b2);


        }


        private void btnPatients_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPatients.Height;
            pnlNav.Top = btnPatients.Top;
            btnPatients.BackColor = Color.FromArgb(43, 53, 69);

            lblTitle.Text = "Patients";
            this.pnlFormLoader.Controls.Clear();
            ucPatients h3 = new ucPatients();
            h3.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(h3);

        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(43, 53, 69);

            Application.Restart();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(21, 33, 50);

        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(21, 33, 50);

        }

     
        private void btnPatients_Leave(object sender, EventArgs e)
        {
            btnPatients.BackColor = Color.FromArgb(21, 33, 50);

        }


        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(21, 33, 50);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Movable_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }

        }

        private void Movable_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);


        }

        private void Movable_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }

        }

        private void Movable_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
