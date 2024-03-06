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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int sayac=0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 10)
            {
                this.BackColor = Color.Red;
            }

            if (sayac == 20)
            {
                this.BackColor = Color.Yellow;
            }
            if (sayac == 30)
            {
                this.BackColor = Color.Green;
                sayac = 0;

            }
            label2.Text = sayac.ToString();

        }

        
        
        
        /* int sayac = 0;
private void button1_Click(object sender, EventArgs e)
{
timer1.Start();
}

private void timer1_Tick(object sender, EventArgs e)
{
sayac++;
if (sayac == 5)
{

this.BackColor=Color.PeachPuff;
}
if (sayac == 10)
{
// timer1.Stop();
this.BackColor = Color.GreenYellow;
sayac = 0;
}
label1.Text = sayac.ToString();

}
*/

    }
    
}
