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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        bool isEditing = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                client.Id = id;
            }
            else
            {
                MessageBox.Show("Id-ja nuk eshte valide!");
                return;
            }
            if (!isEditing) 
            {
              
                if (MyData.clients.Where(t => t.Id == id).Count() > 0)
                {
                    MessageBox.Show("Ekziton klienti me kete id: " + id);
                    return;
                }
            }
            if (txtName.Text != "")
            {
                client.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Jepni emrin e klientit!");
                return;
            };


            if (rbFemale.Checked)
            {
                client.Gender = rbFemale.Text;
            }

            else
            {
                client.Gender = rbMale.Text;
            }

            
            client.Address = txtAddress.Text;

            if (!isEditing)
            {
                
                MyData.clients.Add(client);
            }
            else
            {
           
                Clients row = MyData.clients.Where(t => t.Id == id).FirstOrDefault();
                row.Name = client.Name;
                row.Address = client.Address;
                row.Gender = client.Gender;
            };

            dgvClients.AutoGenerateColumns = false;
            dgvClients.DataSource = MyData.clients.ToList();

            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            isEditing = false;
            txtId.Enabled = true;
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

       
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            isEditing = false;
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            dgvClients.AutoGenerateColumns = false;
            dgvClients.DataSource = MyData.clients.ToList();

        }

        


        private void dgvClients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                txtId.Text = dgvClients.SelectedRows[0].Cells["Id"].Value.ToString();
                txtName.Text = dgvClients.SelectedRows[0].Cells["Name"].Value.ToString();
                txtAddress.Text = dgvClients.SelectedRows[0].Cells["Address"].Value.ToString();
                string gender = dgvClients.SelectedRows[0].Cells["Gender"].Value.ToString();
                if (gender == "Male")
                {
                    rbMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rbFemale.Checked = true;
                }


                isEditing = true;
                txtId.Enabled = false;
            }
        }
    }
}
