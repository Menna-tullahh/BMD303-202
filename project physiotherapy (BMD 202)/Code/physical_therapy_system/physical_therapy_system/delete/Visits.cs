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
    public partial class Visits : Form
    {
        public Visits()
        {
            InitializeComponent();
            customDesigning();
        }

        private void customDesigning()
        {
            panel1.Visible = false;
        }    
        private void HideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;

        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;



            }

        }

        private void Visits_Load(object sender, EventArgs e)
        {

        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel1);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
