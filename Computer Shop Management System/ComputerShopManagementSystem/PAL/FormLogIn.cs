using Microsoft.VisualBasic.Devices;
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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void EmptyBox()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void picClocse_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picShowPass_Click(object sender, EventArgs e)
        {
            if(picShowPass.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShowPass.Visible = false;
                picHidePass.Visible = true;
            }
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            if (picHidePass.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShowPass.Visible = false;
                picHidePass.Visible = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if(txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool check = Computer.Computer.IsValidNamePass(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                
                if(check)
                {
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();
                    EmptyBox();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }
    }
}
