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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MyData.LoadUsers();
        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (frmRegister signin = new frmRegister())
            {
                signin.ShowDialog();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (frmInterior offer = new frmInterior())
            {
                offer.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (frmAkomodimi akomodimi = new frmAkomodimi())
            {
                akomodimi.ShowDialog();
            }
        }

      
    }
}
