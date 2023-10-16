using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSwissDiamond
{
    public partial class frmInterior : Form
    {
        public frmInterior()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._3;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._8;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
        }
    }
}
