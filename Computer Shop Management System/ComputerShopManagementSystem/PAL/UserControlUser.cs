using Computer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopManagementSystem.PAL
{
    public partial class UserControlUser : UserControl
    {
        private string id = "";
        private DataGridView dgvUser;

        public UserControlUser()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void EmptyBox()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void EmptyBox1()
        {
            txtUserName1.Clear();
            txtEmail1.Clear();
            txtPassword1.Clear();
            id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == string.Empty) { 
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User user = new User(txtUserName.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim());
                Computer.Computer.AddUser(user);
                EmptyBox();
            }
        }

        private void tpAddUser_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageUser_Enter(object sender, EventArgs e)
        {
            txtSearchUserName.Clear();
            dgvUser1.Columns[0].Visible = false;
            Computer.Computer.DisplayAndSearch("SELECT * FROM Users;", dgvUser1);
            lblTotalNumber.Text = dgvUser1.Rows[0].ToString();
        }

        private void txtSearchUserName_TextChanged(object sender, EventArgs e)
        {
            Computer.Computer.DisplayAndSearch("SELECT * FROM Users WHERE Users_Name LIKE '%" + txtSearchUserName.Text + "%';", dgvUser1);
            lblTotalNumber.Text = dgvUser1.Rows[0].ToString();
        }

        private void dgvUser1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvUser1.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                txtUserName1.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtPassword.Text = row.Cells[3].Value.ToString();
                tcUser.SelectedTab = tpOptions;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if( id == "" )
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtUserName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User user = new User(txtUserName1.Text.Trim(), txtEmail1.Text.Trim(), txtPassword1.Text.Trim());
                Computer.Computer.ChangeUser(user, id);
                EmptyBox1();
                tcUser.SelectedTab = tpManageUser;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtUserName1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this user?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Computer.Computer.RemoveUser(id);
                    EmptyBox1();
                    tcUser.SelectedTab = tpManageUser;
                }
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if (id == "")
                tcUser.SelectedTab = tpManageUser;
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }
    }
}
