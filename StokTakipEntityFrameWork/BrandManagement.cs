using StokTakipEntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipAdonet
{
    public partial class BrandManagement : Form
    {
        public BrandManagement()
        {
            InitializeComponent();
        }

        DatabaseContext dbContext = new DatabaseContext();

        private void RefreshScreen()
        {
            dgwBrands.DataSource= dbContext.Brands.ToList();
            btnAdd.Enabled = true;
            dtpCreateDate.Value = DateTime.Now;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtBrand.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cbStatus.Checked = false;

        }


        private void BrandManagement_Load(object sender, EventArgs e)
        {
            RefreshScreen();
        }

        private void dgwBrands_Click(object sender, EventArgs e)
        {


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Marka ya da Açıklama alanı boş olamaz!");
                return;
            }

            var brand = dbContext.Brands.Find((long) dgwBrands.CurrentRow.Cells["Id"].Value);
            brand.BrandName = txtBrand.Text;
            brand.Description = txtDescription.Text;
            brand.Status = cbStatus.Checked;
            
            int sonuc = dbContext.SaveChanges();

            if (sonuc > 0)
                MessageBox.Show("Marka güncellenmiştir");
            else
                MessageBox.Show("Kayıt güncelleme başarısız");

            RefreshScreen();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Marka ya da Açıklama alanı boş olamaz!");
                return;
            }
        

            Brands brand = new Brands
            {
                BrandName = txtBrand.Text,
                Description = txtDescription.Text,
                Status = cbStatus.Checked,
                CreateDate = DateTime.Now
            };

            dbContext.Brands.Add(brand);

            int sonuc = dbContext.SaveChanges();

            if (sonuc > 0)
                MessageBox.Show("Marka eklenmiştir");
            else
                MessageBox.Show("Kayıt ekleme başarısız");

            RefreshScreen();
        }

        private void dgwBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBrand.Text = dgwBrands.CurrentRow.Cells["BrandName"].Value.ToString();
            txtDescription.Text = dgwBrands.CurrentRow.Cells["Description"].Value.ToString();
            cbStatus.Checked = (bool) dgwBrands.CurrentRow.Cells["Status"].Value;
            dtpCreateDate.Value = (DateTime) dgwBrands.CurrentRow.Cells["CreateDate"].Value;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Marka ya da Açıklama alanı boş olamaz!");
                return;
            }

            dbContext.Brands.Remove(dbContext.Brands.Find((long)dgwBrands.CurrentRow.Cells["Id"].Value));

            int sonuc = dbContext.SaveChanges();

            RefreshScreen();

            if (sonuc > 0)
                MessageBox.Show("Marka silinmiştir");
            else
                MessageBox.Show("Kayıt silme başarısız");

            
        }
    }
}
