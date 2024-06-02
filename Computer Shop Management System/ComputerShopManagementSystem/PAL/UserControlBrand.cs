using Computer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopManagementSystem.PAL
{
    public partial class UserControlBrand : UserControl
    {

        private string Id = "";

        public UserControlBrand()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            txtBrandName.Clear();
            cmbStatus.SelectedIndex = 0;
        }

        private void EmptyBox1()
        {
            txtSearchBrandName.Clear();
            cmbStatus.SelectedIndex = 0;
            Id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if(txtBrandName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter brand name", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return;
            }
            else if (cmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Brand brand = new Brand(txtBrandName.Text.Trim(), cmbStatus.SelectedItem.ToString());
                Computer.Computer.AddBrand(brand);
                EmptyBox();
            }
        }

        private void tpAddBrand_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageBrand_Enter(object sender, EventArgs e)
        {
            txtSearchBrandName.Clear();
            dgvBrand.Columns[0].Visible = false;
            Computer.Computer.DisplayAndSearch("SELECT * FROM Brand;", dgvBrand);
            lblTotal.Text = dgvBrand.Rows.Count.ToString();
        }

        private void txtSearchBrandName_TextChanged(object sender, EventArgs e)
        {
            Computer.Computer.DisplayAndSearch("SELECT * FROM Brand WHERE Brand_Name LIKE '%" + txtSearchBrandName.Text + "%'; ", dgvBrand);
            lblTotal.Text = dgvBrand.Rows.ToString();
        }

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvBrand.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtBrandName.Text = row.Cells[1].Value.ToString();
                cmbStatusOptions.SelectedItem = row.Cells[2].Value.ToString();
                tcBrand.SelectedTab = tpOptions;

            }
        }

        private void btnChangeOptions_Click(object sender, EventArgs e)
        {
            if(Id == "")
            {
                MessageBox.Show("First select row from table", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (txtBrandNameOptions.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter brand name", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatusOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Brand brand = new Brand(txtBrandNameOptions.Text.Trim(), cmbStatusOptions.SelectedIndex.ToString());
                Computer.Computer.ChangeBrand(brand, Id);
                EmptyBox1();
                tcBrand.SelectedTab = tpManageBrand;
            }
        }

        private void btnRemoveOption_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("First select row from table", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtBrandNameOptions.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter brand name", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatusOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this brand?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.Yes)
                {
                    Computer.Computer.RemoveBrand(Id);
                    EmptyBox1();
                    tcBrand.SelectedTab = tpManageBrand;
                }
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if(Id == "")
            {
                tcBrand.SelectedTab = tpManageBrand;
            }
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void cmbStatusOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtBrandNameOptions_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
