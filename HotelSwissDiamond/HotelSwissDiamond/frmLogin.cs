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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            var user = MyData.Users.Where(t => t.Username == txtUsername.Text && t.Password == txtPassword.Text).Count();
            if (user > 0)
            {
                frmMain main = new frmMain();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
            Console.WriteLine("User count: " + user);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MyData.LoadUsers();
        }
    }
}
