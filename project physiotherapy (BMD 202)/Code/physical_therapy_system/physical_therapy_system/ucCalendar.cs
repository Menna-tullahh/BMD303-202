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
    public partial class ucCalendar : UserControl
    {
        public static string date;
        public ucCalendar()
        {
            InitializeComponent();
        }

        private void btnNextT_Click(object sender, EventArgs e)
        {
            date = monthCalendar1.SelectionRange.Start.ToShortDateString();

            if (!Form1.Instance.pnlFormLoader.Controls.ContainsKey("ucDailyTable"))
            {
                Form1.Instance.lblTitle.Text = "Appointments";
                ucDailyTable nu = new ucDailyTable();
                nu.Dock = DockStyle.Fill;
                Form1.Instance.pnlFormLoader.Controls.Add(nu);
            }
            Form1.Instance.pnlFormLoader.Controls["ucDailyTable"].BringToFront();
            Form1.Instance.pnlFormLoader.Visible = true;
        }

        private void ucCalendar_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
