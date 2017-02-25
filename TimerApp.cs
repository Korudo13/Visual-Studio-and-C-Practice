using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class ColorTimer : Form
    {
        public ColorTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Plum)
            {
                this.BackColor = Color.Olive;
            }

            else
            {
                this.BackColor = Color.Plum;
            }

            //timer1.Enabled = false;
            timer1.Interval = timer1.Interval + 100;
        }
    }
}
