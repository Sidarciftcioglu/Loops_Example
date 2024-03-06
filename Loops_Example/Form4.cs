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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i=1;
            while (i <= 5)
            {
                listBox1.Items.Add("Hello Mardin");
                listBox2.Items.Add(i);
                i++;
            }
            
            int j = 1,sum=0;
            while (j <= 5)
            {
                sum=sum+j;
                j++;
                
            }
            MessageBox.Show(sum.ToString());

        }
    }
}
