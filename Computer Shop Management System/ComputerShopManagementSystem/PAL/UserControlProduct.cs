using Computer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopManagementSystem.PAL
{
    public partial class UserControlProduct : UserControl
    {
        private string id = "";
        byte[] image;
        ImageConverter imageConverter;
        MemoryStream memoryStream;

        public UserControlProduct()
        {
            InitializeComponent();
            imageConverter = new ImageConverter();
        }

        private void ImageUpload(PictureBox picture)
        {
            try
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picture.Image = Image.FromFile(openFileDialog.FileName);
                }
            }catch (Exception)
            { 
                MessageBox.Show("Image upload error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EmptyBox()
        {
            txtProductName.Clear();
            picPhoto.Image = null;
            numdRate.Value = 0;
            numdQuantity.Value = 0;

            cmbBrand.Items.Clear();
            cmbBrand.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = 'Available' ORDER BY Brand_Name;", cmbBrand);
            cmbBrand.SelectedIndex = 0;

            cmbCategory.SelectedIndex = 0;
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = 'Available' ORDER BY Category_Name;", cmbCategory);
            cmbCategory.SelectedIndex = 0;

            cmbStatus.SelectedIndex = 0;
        }

        //Emptybox for Options 
        private void EmptyBox1()
        {
            txtProductNameOptions.Clear();
            picbPhotoOptions.Image = null;
            numdRateOptions.Value = 0;
            numdQuantityOptions.Value = 0;

            cmbStatusOptions.SelectedIndex = 0;
            id = "";
        }

        private void ComboBoxAutoFill()
        {
            cmbBrandOptions.Items.Clear();
            cmbBrandOptions.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = 'Available' ORDER BY Brand_Name;", cmbBrandOptions);
            cmbBrandOptions.SelectedIndex = 0;

            cmbCategoryOptions.SelectedIndex = 0;
            cmbCategoryOptions.Items.Clear();
            cmbCategoryOptions.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Brand_Name FROM Category WHERE Category_Status = 'Available' ORDER BY Category_Name;", cmbCategoryOptions);
            cmbCategoryOptions.SelectedIndex = 0;
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ImageUpload(picPhoto);

        }

        private void btnBrowseOptions_Click(object sender, EventArgs e)
        {
            ImageUpload(picbPhotoOptions);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto.Image == null)
            {
                MessageBox.Show("Please select image", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (numdRate.Value == 0)
            {
                MessageBox.Show("Please enter rate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (numdQuantity.Value == 0)
            {
                MessageBox.Show("Please enter quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbBrand.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtProductName.Text.Trim(), (byte[])imageConverter.ConvertTo(picPhoto.Image, typeof(byte[])), Convert.ToInt32(numdRate.Value), Convert.ToInt32(numdQuantity.Value),
                    cmbBrand.SelectedIndex.ToString(), cmbCategory.SelectedIndex.ToString(), cmbStatus.SelectedIndex.ToString());
                Computer.Computer.AddProduct(product);
                EmptyBox();
            }
        }

        private void btnAddProduct_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tcProduct_Enter(object sender, EventArgs e)
        {
            txtSearchProductName.Clear();
            dgvProduct.Columns[0].Visible = false;
            Computer.Computer.DisplayAndSearch("SELECT * FROM Product; ",dgvProduct);
            lblTotalNumber.Text = dgvProduct.Rows.Count.ToString();
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            Computer.Computer.DisplayAndSearch("SELECT * FROM Brand WHERE Product_Name LIKE '%" + txtSearchProductName.Text + "%'; ", dgvProduct);
            lblTotalNumber.Text = dgvProduct.Rows.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                ComboBoxAutoFill();
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                txtProductNameOptions.Text = row.Cells[1].Value.ToString(); // w razie czego zmienic txtProductName
                image = (byte[])row.Cells[2].Value;
                memoryStream = new MemoryStream(image);
                picbPhotoOptions.Image = Image.FromStream(memoryStream);

                numdRateOptions.Value = Convert.ToInt32(row.Cells[3].Value.ToString());
                numdQuantityOptions.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
                cmbBrandOptions.SelectedItem = row.Cells[5].Value.ToString();
                cmbCategoryOptions.SelectedItem = row.Cells[6].Value.ToString();
                cmbStatusOptions.SelectedItem = row.Cells[7].Value.ToString();
                tcProduct.SelectedTab = tpOptions;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(id == "")
            {
                MessageBox.Show("Please select row from table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtProductNameOptions.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picbPhotoOptions.Image == null)
            {
                MessageBox.Show("Please select image", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (numdRateOptions.Value == 0)
            {
                MessageBox.Show("Please enter rate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (numdQuantityOptions.Value == 0)
            {
                MessageBox.Show("Please enter quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbBrandOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbCategoryOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatusOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtProductNameOptions.Text.Trim(), (byte[])imageConverter.ConvertTo(picbPhotoOptions.Image, typeof(byte[])), Convert.ToInt32(numdRateOptions.Value), Convert.ToInt32(numdQuantityOptions.Value),
                    cmbBrandOptions.SelectedIndex.ToString(), cmbCategoryOptions.SelectedIndex.ToString(), cmbStatusOptions.SelectedIndex.ToString());
                Computer.Computer.ChangeProduct(product, id);
                EmptyBox1();
                tcProduct.SelectedTab = tpManageProduct;
            }
        }

        private void btnRemoveOption_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Please select row from table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtProductNameOptions.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picbPhotoOptions.Image == null)
            {
                MessageBox.Show("Please select image", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (numdRateOptions.Value == 0)
            {
                MessageBox.Show("Please enter rate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (numdQuantityOptions.Value == 0)
            {
                MessageBox.Show("Please enter quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbBrandOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbCategoryOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatusOptions.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this product?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    Computer.Computer.RemoveProduct(id);
                    EmptyBox1();
                    tcProduct.SelectedTab = tpManageProduct;
                }
  
            }
        }

        private void tpOptions_Enter(object sender, EventArgs e)
        {
            if(id == "")
            {
                tcProduct.SelectedTab = tpManageProduct;
            }
        }

        private void tpOptions_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

    }
}
