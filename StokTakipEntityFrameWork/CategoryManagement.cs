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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        DatabaseContext dbContext = new DatabaseContext();
        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            RefreshScreen();

        }

        private void RefreshScreen()
        {
            dgwCategories.DataSource = dbContext.Categories.ToList();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtCategory.Text = string.Empty;
            txtAciklama.Text = string.Empty;
        }

        private void dgwCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategory.Text = dgwCategories.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtAciklama.Text = dgwCategories.CurrentRow.Cells["Description"].Value.ToString();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtAciklama.Text))
            {
                MessageBox.Show("Kategori ya da Açıklama alanı boş olamaz!");
                return; 
            }

            Categories category = new Categories
            {
                CategoryName = txtCategory.Text,
                Description = txtAciklama.Text
            };

            dbContext.Categories.Add(category);

            int sonuc = dbContext.SaveChanges();

            RefreshScreen();

            if (sonuc > 0)
                MessageBox.Show("Kategori eklenmiştir");
            else
                MessageBox.Show("Kayıt ekleme başarısız");

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtAciklama.Text))
            {
                MessageBox.Show("Kategori ya da Açıklama alanı boş olamaz!");
                return;
            }

            var existingCategory = dbContext.Categories.Find((long)dgwCategories.CurrentRow.Cells["Id"].Value);

            existingCategory.CategoryName = txtCategory.Text;
            existingCategory.Description = txtAciklama.Text;

            int sonuc = dbContext.SaveChanges();

            if (sonuc > 0)
                MessageBox.Show("Kategori güncellenmiştir");
            else
                MessageBox.Show("Kayıt güncelleme başarısız");

            RefreshScreen();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtAciklama.Text))
            {
                MessageBox.Show("Kategori ya da Açıklama alanı boş olamaz!");
                return;
            }

            dbContext.Categories.Remove(dbContext.Categories.Find((long)dgwCategories.CurrentRow.Cells["Id"].Value));

            int sonuc = dbContext.SaveChanges();

            if (sonuc > 0)
                MessageBox.Show("Kategori silinmiştir");
            else
                MessageBox.Show("Kayıt silme başarısız");

            RefreshScreen();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            // dgwCategories.DataSource = categoryDal.GetSearchedCategories(txtAra.Text);

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            // dgwCategories.DataSource = categoryDal.GetSearchedCategories(txtAra.Text);
        }
    }
}
