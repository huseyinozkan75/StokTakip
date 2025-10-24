using StokTakipEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipAdonet
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }
        
        DatabaseContext dbContext = new DatabaseContext();

        private void RefreshScreen()
        {
            dgwProducts.DataSource = dbContext.Products.ToList();

            cbCategory.DataSource = dbContext.Categories.ToList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";

            cbBrand.DataSource = dbContext.Brands.ToList();
            cbBrand.DisplayMember = "BrandName";
            cbBrand.ValueMember = "Id";

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtProduct.Text = string.Empty;
            txtAciklama.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStocksCount.Text = string.Empty;
            cbDurum.Checked = false;
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            RefreshScreen();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products product = new Products
            {
                ProductName = txtProduct.Text,
                Status = cbDurum.Checked,
                CreateDate = DateTime.Now,
                Price = Convert.ToDecimal(txtPrice.Text),
                Description = txtAciklama.Text,
                StocksCount = Convert.ToInt32(txtStocksCount.Text),
                CategoryID = (long)cbCategory.SelectedValue,
                BrandID = (long)cbBrand.SelectedValue,
            };

            dbContext.Products.Add(product);

            int sonuc = dbContext.SaveChanges();

            RefreshScreen();

            if (sonuc > 0)
                MessageBox.Show("Ürün eklenmiştir");
            else
                MessageBox.Show("Kayıt ekleme başarısız");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var existingProduct = dbContext.Products.Find((long)dgwProducts.CurrentRow.Cells["Id"].Value);

            existingProduct.ProductName = txtProduct.Text;
            existingProduct.Status = cbDurum.Checked;
            existingProduct.Description = txtAciklama.Text;
            existingProduct.CategoryID = (long)cbCategory.SelectedValue;
            existingProduct.BrandID = (long)cbBrand.SelectedValue;
            existingProduct.StocksCount = Convert.ToInt32(txtStocksCount.Text);
            existingProduct.Price = Convert.ToDecimal(txtPrice.Text);
           
            int sonuc = dbContext.SaveChanges();

            if (sonuc > 0)
                MessageBox.Show("Ürün güncellenmiştir");
            else
                MessageBox.Show("Kayıt ekleme başarısız");

            RefreshScreen();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProduct.Text = dgwProducts.CurrentRow.Cells["ProductName"].Value.ToString();
            txtAciklama.Text = dgwProducts.CurrentRow.Cells["Description"].Value.ToString();
            txtPrice.Text = dgwProducts.CurrentRow.Cells["Price"].Value.ToString();
            txtStocksCount.Text = dgwProducts.CurrentRow.Cells["StocksCount"].Value.ToString();
            cbDurum.Checked = (bool)dgwProducts.CurrentRow.Cells["Status"].Value;
            cbCategory.SelectedValue = (long)dgwProducts.CurrentRow.Cells["CategoryID"].Value;
            cbBrand.SelectedValue = (long)dgwProducts.CurrentRow.Cells["BrandID"].Value;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            // dgwProducts.DataSource = ProductDAL.GetSearchedProducts(txtAra.Text);
        }
    }
}
