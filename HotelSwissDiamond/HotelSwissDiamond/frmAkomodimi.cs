using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelSwissDiamond
{
    public partial class frmAkomodimi : Form
    {
        public frmAkomodimi()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label8.Text, out curr))
                curr++;
            label8.Text = curr.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label8.Text, out curr))
                curr--;
            if (curr <= 0)
            {
                curr= 0;
            }
            label8.Text = curr.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible= false;
            groupBox1.Visible= true;
            panel4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            panel4.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            panel4.Visible = false;
        }

        private void frmAkomodimi_Load(object sender, EventArgs e)
        {
            panel4.Visible=true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label8.Text, out curr)) ;
            if (curr != 0)
            {
                curr = 0;
            }
            label8.Text = curr.ToString();

            checkBox1.Checked = false;
           
            MessageBox.Show("Te dhenat tuaja jane validuar");

        }

        private void label14_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label18.Text, out curr))
                curr++;
            label18.Text = curr.ToString();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label18.Text, out curr))
                curr--;
            if (curr <= 0)
            {
                curr = 0;
            }
            label18.Text = curr.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label18.Text, out curr));
            if (curr != 0)
            {
                curr = 0;
            }
            label18.Text = curr.ToString();

            checkBox2.Checked = false;

            MessageBox.Show("Te dhenat tuaja jane validuar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label32.Text, out curr));
            if (curr != 0)
            {
                curr = 0;
            }
            label32.Text = curr.ToString();

            checkBox4.Checked = false;
            MessageBox.Show("Te dhenat tuaja jane validuar");
        }

        private void label28_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label32.Text, out curr))
                curr++;
            label32.Text = curr.ToString();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            var curr = 0;
            if (int.TryParse(label32.Text, out curr))
                curr--;
            if (curr <= 0)
            {
                curr = 0;
            }
            label32.Text = curr.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
