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
    public partial class UserControlOrder : UserControl
    {

        private string id = "";

        public UserControlOrder()
        {
            InitializeComponent();
        }

        //for Add
        public void EmptyBox()
        {
            dtpDate.Value = DateTime.Now;
            txtCustomerName.Clear();
            mtbCustomerNumber.Clear();
            AddClear();
            dgvOrdersList.Rows.Clear();
            txtTotalAmount.Text = "0";
            nudPaidAmount.Value = 0;
            txtDueAmount.Text = "0";
            nudDiscount.Value = 0;
            txtGrandTotal.Text = "0";
            cmbPaymentStatus.SelectedIndex = 0;
        }

        //for Options
        public void EmptyBox1()
        {
            dtpDateOptions.Value = DateTime.Now;
            txtCustomerNameOptions.Clear();
            mtxtCustomerNumberOptions.Clear();   
            txtTotalAmountOptions.Text = "0";
            nudPaidAmountOptions.Value = 0;
            txtDueAmountOptions.Text = "0";
            nudDiscountOptions.Value = 0;
            txtGrandTotalOptions.Text = "0";
            cmbPaymentStatusOptions.SelectedIndex = 0;
            id = "";
        }

        private void AddClear()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status = 'Available' ORDER BY Product_Name; ", cmbProduct);
            cmbProduct.SelectedIndex = 0;
            tbRate.Clear();
            nudQuantity.Value = 0;
            tbTotal.Clear();
        }

        RichTextBox richTextBox = new RichTextBox();
        private void Receipt()
        {
            richTextBox.Clear();
            richTextBox.Text += "\t     COMPUTER SHOP MANAGEMENT SYSTEM\n";
            richTextBox.Text += "************************************************\n\n";
            richTextBox.Text += "   Date: "+ dtpDate.Text + "\n";
            richTextBox.Text += "   Name " + txtCustomerName.Text.Trim() + "\n";
            richTextBox.Text += "   Number " + mtbCustomerNumber.Text.Trim() + "\n";
            richTextBox.Text += "************************************************\n\n";
            richTextBox.Text += "   Name\t\tRate\t\tQunatity\t\tTotal\n";


            for(int i = 0; i < dgvOrdersList.Rows[i].Cells[j]; i++)
            {
                for (int j = 0; j < dgvOrdersList.Columns.Count - 1; j++)
                {
                    richTextBox.Text += dgvOrdersList.Rows[i].Cells[j].Value.ToString() + "\t\t";
                }
                richTextBox.Text += "\n";
            }

            richTextBox.Text += "************************************************\n\n";
            richTextBox.Text += "\t\t\t\t\tTotal: $ " + txtTotalAmount.Text + "\n";
            richTextBox.Text += "\t\t\t\t\tPaid Amount: $ " + nudPaidAmount.Value + "\n";
            richTextBox.Text += "\t\t\t\t\tDue Amount: $ " + txtDueAmount.Text + "\n";
            richTextBox.Text += "\t\t\t\t\tDiscount: $ " + nudDiscount.Value + "\n";
            richTextBox.Text += "\t\t\t\t\tGrand Total: $ " + txtGrandTotal.Text + "\n";

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdd, "Add");
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(picSearch, "Search");
        }


    }
}
