using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class DayButton : System.Windows.Forms.Button
    {
        public DateTime date;
        public DayButton()
        {
            InitializeComponent();
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            TestForm form = new TestForm();
            form.Show();
        }
    }
}
