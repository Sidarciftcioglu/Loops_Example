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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, multi = 1;

            int sayi = Convert.ToInt32(textBox1.Text);

            for (i = 1; i <= sayi; i++)
            {
                multi = multi * i; 
            }
            label1.Text = multi.ToString();
        }
    }
}
