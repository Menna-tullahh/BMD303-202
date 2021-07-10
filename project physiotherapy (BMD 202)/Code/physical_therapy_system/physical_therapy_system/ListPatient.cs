using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace physical_therapy_system
{
    public partial class ListPatient : UserControl
    {

        private string _title;
        private string _ID;

        public static string _message;
        private Color _iconBack;

        public ListPatient()
        {
            InitializeComponent();
            
        }

        private void ListPatient_Load(object sender, EventArgs e)
        {

            
        }

        #region Properties

        
        [Category("custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; IblTitle.Text = value; }
        }
        public string patientID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        [Category("custom Props")]

        public string Message
        {
            get { return _message; }
            set { _message = value; IblMessage.Text = value; }
        }

        public Color BgColor
        {
            get { return _iconBack; }
            set { _iconBack = value; panel1.BackColor= value; }
        }

        private Image _icon;
        [Category("custom Props")]

        public Image Myproperty
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }




        #endregion

        private void ListPatient_Leave(object sender, EventArgs e)
        {

        }

        private void ListPatient_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(21, 33, 50);
        }

        private void ListPatient_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 53, 69);

        }

        private void ListPatient_Click(object sender, EventArgs e)
        {

        }


        private void IblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
