using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxSelectionCount = 7;
            monthCalendar1.SelectionStart = DateTime.Today;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            switch (monthCalendar1.SelectionStart.Month)
            {
                case 3:
                case 4:
                case 5:
                    this.BackColor = Color.LightGreen;
                    break;
                case 6:
                case 7:
                case 8:
                    this.BackColor = Color.LightBlue;
                    break;
                case 9:
                case 10:
                case 11:
                    this.BackColor = Color.Orange;
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime d_s = monthCalendar1.SelectionStart;
            DateTime d_e = monthCalendar1.SelectionEnd;
            TimeSpan ts = d_e - d_s;
            int days = ts.Days + 1;
            int rentAmt;
            switch (days)
            {
                case 1:
                    rentAmt = 10;
                    break;
                case 2:
                case 3:
                    rentAmt = 8;
                    break;
                default:
                    rentAmt = 6;
                    break;
            }
            label3.Text = days.ToString() + "天的租金為" + (days * rentAmt).ToString() + "元";
        }
    }
}
