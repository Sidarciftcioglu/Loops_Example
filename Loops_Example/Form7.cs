using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops_Example
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int clock=0,minute=0,second=0;

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label1.Text = second.ToString();

            if (second == 60)
            {
                minute++;
                label2.Text = minute.ToString();
                second = 0;

                if (minute == 5)
                {
                    clock++;
                    label3.Text = clock.ToString();
                    minute = 0;
                }
            }

        }
    }
}
