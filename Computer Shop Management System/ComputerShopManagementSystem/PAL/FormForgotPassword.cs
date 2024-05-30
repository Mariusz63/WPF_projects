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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void picClocse_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if(txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string pass = Computer.Computer.ForgotPassword(txtUserName.Text.Trim(), txtEmail.Text.Trim());

                if(pass != string.Empty)
                {
                    MessageBox.Show($"Your password is: {pass}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show($"Username or email is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
}
    }
}
