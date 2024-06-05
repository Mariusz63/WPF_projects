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
    public partial class UserControlOrder : UserControl
    {

        private string id = "";
        int oTotal = 0;

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
            richTextBox.Text += "***************************************************************\n\n";
            richTextBox.Text += "   Date: "+ dtpDate.Text + "\n";
            richTextBox.Text += "   Name " + txtCustomerName.Text.Trim() + "\n";
            richTextBox.Text += "   Number " + mtbCustomerNumber.Text.Trim() + "\n";
            richTextBox.Text += "***************************************************************\n\n";
            richTextBox.Text += "   Name\t\tRate\t\tQunatity\t\tTotal\n";

            for(int i = 0; i < dgvOrdersList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvOrdersList.Columns.Count - 1; j++)
                {
                    richTextBox.Text += dgvOrdersList.Rows[i].Cells[j].Value.ToString() + "\t\t";
                }
                richTextBox.Text += "\n";
            }

            richTextBox.Text += "***************************************************************\n\n";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Please select product.","Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(nudQuantity.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(nudQuantity.Value > 0)
                {
                    int rate, total;
                    Int32.TryParse(tbRate.Text, out rate);
                    Int32.TryParse(txtTotalAmount.Text, out total);

                    if(dgvOrdersList.Rows.Count != 0)
                    {
                        foreach(DataGridViewRow rows in dgvOrdersList.Rows)
                        {
                            if (rows.Cells[0].Value.ToString() == cmbProduct.SelectedItem.ToString())
                            {
                                int quantity = Convert.ToInt32(rows.Cells[2].Value.ToString());
                                int total1 = Convert.ToInt32(rows.Cells[3].Value.ToString());
                                quantity += Convert.ToInt32(nudQuantity.Value);
                                total1 += total;
                                rows.Cells[2].Value = quantity;
                                rows.Cells[3].Value = total1;
                                AddClear();
                            }
                            else
                            {
                                if(cmbProduct.SelectedIndex != 0)
                                {
                                    txtTotalAmount.Text = (rate * Convert.ToInt32(nudQuantity.Value)).ToString();
                                    string[] row  =
                                    {
                                     cmbProduct.SelectedItem.ToString(), tbRate.Text, nudQuantity.ToString(), tbTotal.Text 
                                    };
                                    dgvOrdersList.Rows.Add(row);
                                    AddClear();
                                }
                            }
                        }
                    }
                    else
                    {
                        tbTotal.Text = (rate * Convert.ToInt32(nudQuantity.Value)).ToString();
                        string[] row =
                                  {
                                    cmbProduct.SelectedItem.ToString(), tbRate.Text, nudQuantity.ToString(), tbTotal.Text
                                  };
                        dgvOrdersList.Rows.Add(row);
                        AddClear();
                    }
                }
               txtTotalAmount.Text = oTotal.ToString();
            }
            foreach (DataGridViewRow rows in dgvOrdersList.Rows)
            {
                oTotal += Convert.ToInt32(rows.Cells[3].Value.ToString());
                txtTotalAmount.Text = oTotal.ToString();
            }
            oTotal = 0;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rate = Computer.Computer.Rate(cmbProduct.SelectedItem.ToString());
            if (rate != string.Empty)
            {
                tbRate.Text = rate;
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            int rate;
            Int32.TryParse(tbRate.Text, out rate);
            txtTotalAmount.Text = (rate * Convert.ToInt32(nudQuantity.Value)).ToString();
        }

        private void dgvOrdersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int rowIndex = dgvOrdersList.CurrentCell.RowIndex;
                dgvOrdersList.Rows.RemoveAt(rowIndex);
                
                if(dgvOrdersList.Rows.Count != 0)
                {
                    foreach (DataGridViewRow rows in dgvOrdersList.Rows)
                    {
                        oTotal += Convert.ToInt32(rows.Cells[3].Value.ToString());
                        txtTotalAmount.Text = oTotal.ToString();
                    }
                }
                else
                    txtTotalAmount.Text = "0";
                oTotal = 0;
            }
        }

        private void nudPaidAmount_ValueChanged(object sender, EventArgs e)
        {
            txtDueAmount.Text = (Convert.ToInt32(nudPaidAmount.Value) - Convert.ToInt32(txtTotalAmount.Text)).ToString();
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            txtGrandTotal.Text = (Convert.ToInt32(txtTotalAmount.Text) - Convert.ToInt32(nudDiscount.Text)).ToString();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            nudPaidAmount_ValueChanged(sender,e);
            nudDiscount_ValueChanged(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCustomerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please eneter customer name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(!mtbCustomerNumber.MaskCompleted)
            {
                MessageBox.Show("Please eneter valid customer number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudPaidAmount.Value == 0)
            {
                MessageBox.Show("Please eneter paid amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbPaymentStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select payment status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Order order = new Order(dtpDate.Value.Date, txtCustomerName.Text.Trim(), mtbCustomerNumber.Text, Convert.ToInt32(txtTotalAmount.Text), Convert.ToInt32(nudPaidAmount.Value),
                    Convert.ToInt32(txtDueAmount.Text), Convert.ToInt32(nudDiscount.Value), Convert.ToInt32(txtGrandTotal.Text), cmbPaymentStatus.SelectedItem.ToString());
                Computer.Computer.SaveOrder(order);
                EmptyBox();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            Receipt();
            printPreviewDialog.Document = printDocument;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, new Font("Segoe UI", 6, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void tbRate_TextChanged(object sender, EventArgs e)
        {
            nudQuantity_ValueChanged(sender, e);
        }

        private void tpManageOrders_Enter(object sender, EventArgs e)
        {
            txtSearchCustomerName.Clear();
            dgvOrdersList.Columns[0].Visible = false;
            Computer.Computer.DisplayAndSearch("SELECT * FROM Orders; ", dgvOrdersList);
            lblTotalNumber.Text = dgvOrdersList.Rows.Count.ToString();
        }

        private void txtSearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            Computer.Computer.DisplayAndSearch("SELECT * FROM Orders WHERE Customer_Name LIKE '%" + txtSearchCustomerName.Text + "%'; ", dgvManageOrders);
            lblTotalNumber.Text = dgvManageOrders.Rows.ToString();
        }

        private void dgvManageOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvManageOrders.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                dtpDateOptions.Text = row.Cells[1].Value.ToString();
                txtCustomerNameOptions.Text = row.Cells[2].Value.ToString();
                mtxtCustomerNumberOptions.Text = row.Cells[3].Value.ToString();
                txtTotalAmountOptions.Text = row.Cells[4].ToString();
                nudPaidAmountOptions.Value = Convert.ToInt32(row.Cells[5].Value.ToString());
                txtDueAmountOptions.Text = row.Cells[6].Value.ToString();
                nudDiscountOptions.Value = Convert.ToInt32(row.Cells[7].Value.ToString());
                txtGrandTotalOptions.Text = row.Cells[8].Value.ToString();
                cmbPaymentStatusOptions.SelectedItem = row.Cells[9].Value.ToString();
                tcOrder.SelectedTab = tpOptions;
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if(id == "")
            {
                tcOrder.SelectedTab = tpManageOrders;
            }
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void btnChangeOptions_Click(object sender, EventArgs e)
        {
            if(id == "")
            {
                MessageBox.Show("First select row from table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCustomerNameOptions.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please eneter customer name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!mtxtCustomerNumberOptions.MaskCompleted)
            {
                MessageBox.Show("Please eneter valid customer number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudPaidAmountOptions.Value == 0)
            {
                MessageBox.Show("Please eneter paid amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbPaymentStatusOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select payment status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Order order = new Order(dtpDateOptions.Value.Date, txtCustomerNameOptions.Text.Trim(), mtxtCustomerNumberOptions.Text, Convert.ToInt32(txtTotalAmountOptions.Text), 
                    Convert.ToInt32(nudPaidAmountOptions.Value), Convert.ToInt32(txtDueAmountOptions.Text), Convert.ToInt32(nudDiscountOptions.Value), Convert.ToInt32(txtGrandTotalOptions.Text),
                    cmbPaymentStatusOptions.SelectedItem.ToString());

                Computer.Computer.SaveOrder(order);
                EmptyBox1();
                tcOrder.SelectedTab = tpManageOrders;
            }
        }

        private void tpAddOrder_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void nudPaidAmountOptions_ValueChanged(object sender, EventArgs e)
        {
            txtDueAmountOptions.Text = (Convert.ToInt32(nudPaidAmountOptions.Value) - Convert.ToInt32(txtTotalAmountOptions.Text)).ToString();
        }

        private void nudDiscountOptions_ValueChanged(object sender, EventArgs e)
        {
            txtGrandTotalOptions.Text = (Convert.ToInt32(txtTotalAmountOptions.Text) - Convert.ToInt32(nudDiscountOptions.Text)).ToString();
        }

        private void txtTotalAmountOptions_TextChanged(object sender, EventArgs e)
        {
            nudPaidAmountOptions_ValueChanged(sender, e);
            nudDiscountOptions_ValueChanged(sender, e);
        }

        private void btnRemoveOption_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("First select row from table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCustomerNameOptions.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please eneter customer name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!mtxtCustomerNumberOptions.MaskCompleted)
            {
                MessageBox.Show("Please eneter valid customer number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudPaidAmountOptions.Value == 0)
            {
                MessageBox.Show("Please eneter paid amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbPaymentStatusOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select payment status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this product?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Computer.Computer.RemoveOrder(id);
                    EmptyBox1();
                    tcOrder.SelectedTab = tpManageOrders;
                }
            }
        }
    }
}
