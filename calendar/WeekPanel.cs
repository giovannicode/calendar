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
    public partial class WeekPanel : UserControl
    {
        public WeekPanel()
        {
            InitializeComponent();
        }

        public DayButton getChild(int i)
        {
            switch (i)
            {
                case 0:
                    {
                        return this.dayButton0;
                        //break;
                    }

                case 1:
                    {
                        return this.dayButton1;
                        //break;
                    }
                case 2:
                    {
                        return this.dayButton2;
                        //break;
                    }
                case 3:
                    {
                        return this.dayButton3;
                        //break;
                    }
                case 4:
                    {
                        return this.dayButton4;
                        //break;
                    }
                case 5:
                    {
                        return this.dayButton5;
                        //break;
                    }
                case 6:
                    {
                        return this.dayButton6;
                        //break;
                    }
                default:
                    {
                        throw new IndexOutOfRangeException();
                    }
            }

        }

        private void dayButton1_Click(object sender, EventArgs e)
        {

        }

        private void dayButton0_Click(object sender, EventArgs e)
        {

        }
    }
}
