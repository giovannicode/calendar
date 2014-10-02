using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MonthPanel : UserControl
    {
        public MonthPanel()
        {
            InitializeComponent();
        }

        public DayButton getDayButton(int i, int j)
        {
            switch (i)
            {
                case 0:
                    {
                        return weekPanel1.getChild(j);
                    }
                case 1:
                    {
                        return weekPanel2.getChild(j);
                    }
                case 2:
                    {
                        return weekPanel3.getChild(j);
                    }
                case 3:
                    {
                        return weekPanel4.getChild(j);
                    }
                case 4:
                    {
                        return weekPanel5.getChild(j);
                    }
                case 5:
                    {
                        return weekPanel6.getChild(j);
                    }
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        private void MonthPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
