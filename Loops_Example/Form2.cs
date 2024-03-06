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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
             int i,sum=0;
             for( i = 1; i <= 10; i++)
             {
                 sum = sum + i;

             }
             label1.Text = (sum).ToString();
            */

            /*
             int sum = 0;
             for(int i = 1; i <= 10; i++)
             {
                 if (i % 2 == 0)
                 {
                     sum = sum + i;
                 }

             }
             label2.Text=sum.ToString();
            */
            int i, sum = 0;
           for( i= 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    sum=sum+i;
                }
            }
           label2.Text = sum.ToString();    
        }
    }
}
