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
    public partial class ucVisits : UserControl
    {
        public static string _title;

        public static string _start;
        public static string _end;
        private Color _iconBack;
        public ucVisits()
        {
            InitializeComponent();
            customDesigning();
        }
        private void customDesigning()
        {
        }

        private void ShowSubMenu(Panel subMenu)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ucVisits_Load(object sender, EventArgs e)
        {
    
        
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = value; }
        }
        public string start
        {
            get { return _start; }
            set { _start = value; label4.Text = value;  }
        }

        public string end
        {
            get { return _end; }
            set { _end = value; label2.Text = value; }
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
  
}
