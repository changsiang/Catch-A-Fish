using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_A_Fish
{
    public partial class CatchAFish : Form
    {
        public CatchAFish()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var newx = rnd.Next(1, 527);
            var newy = rnd.Next(1, 276);

            this.button1.Location = new System.Drawing.Point(newx, newy);
        }
    }
}
