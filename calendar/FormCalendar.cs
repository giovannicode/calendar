using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class FormCalendar : Form
    {
        DateTime date;
        public FormCalendar()
        {
            InitializeComponent();
            monthPanel1_Load1();
        }

        private void monthPanel1_Load(object sender, EventArgs e)
        {
            //this.monthPanel1.getChild().getChild().Text = "Work is";
            this.monthPanel1.getDayButton(2, 5).Text = "What?";
        }

        private void monthPanel1_Load1()
        {   
            date = DateTime.Now.Subtract(TimeSpan.FromDays(DateTime.Now.Day - 1));
            int subtractor =  (int)(date.DayOfWeek);
            date = date.AddDays(-subtractor);
            
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    this.monthPanel1.getDayButton(i, j).Text = date.ToShortDateString();
                    this.monthPanel1.getDayButton(i, j).date = date;
                    date = date.AddDays(1);
                }
            }

            lblMonth.Text = this.monthPanel1.getDayButton(2, 4).date.Month.ToString();
            lblMonth.Text += "    " + this.monthPanel1.getDayButton(2, 4).date.Year.ToString();
        }

        private void btnForw_Click(object sender, EventArgs e)
        {
            date = date.Subtract(TimeSpan.FromDays(date.Day - 1));
            int subtractor = (int)(date.DayOfWeek);
            date = date.AddDays(-subtractor);

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    this.monthPanel1.getDayButton(i, j).Text = date.ToShortDateString();
                    this.monthPanel1.getDayButton(i, j).date = date;
                    date = date.AddDays(1);
                }
            }

            lblMonth.Text = this.monthPanel1.getDayButton(2, 4).date.Month.ToString();
            lblMonth.Text += "    " +  this.monthPanel1.getDayButton(2, 4).date.Year.ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            date = this.monthPanel1.getDayButton(0, 0).date;
            date = date.AddDays(-1);
            date = date.Subtract(TimeSpan.FromDays(date.Day - 1));
            int subtractor = (int)(date.DayOfWeek);
            date = date.AddDays(-subtractor);

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    this.monthPanel1.getDayButton(i, j).Text = date.ToShortDateString();
                    this.monthPanel1.getDayButton(i, j).date = date;
                    date = date.AddDays(1);
                }
            }

            lblMonth.Text = this.monthPanel1.getDayButton(2, 4).date.Month.ToString();
            lblMonth.Text += "    " + this.monthPanel1.getDayButton(2, 4).date.Year.ToString();
        }

    }
}
