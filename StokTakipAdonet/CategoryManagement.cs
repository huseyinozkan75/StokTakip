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

        CategoryDAL categoryDal = new CategoryDAL();
        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            RefreshScreen();

        }

        private void RefreshScreen()
        {
            dgwCategories.DataSource = categoryDal.GetCategories();
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

            Category category = new Category
            {
                CategoryName = txtCategory.Text,
                Description = txtAciklama.Text
            };

            int sonuc = categoryDal.Add(category);
            
            if (sonuc > 0)
                MessageBox.Show("Kategori eklenmiştir");
            else
                MessageBox.Show("Kayıt ekleme başarısız");

            RefreshScreen();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtAciklama.Text))
            {
                MessageBox.Show("Kategori ya da Açıklama alanı boş olamaz!");
                return;
            }

            Category category = new Category
            {
                Id = (Int64) dgwCategories.CurrentRow.Cells["Id"].Value,
                CategoryName = txtCategory.Text,
                Description = txtAciklama.Text
            };

            int sonuc = categoryDal.Update(category);

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

            Category category = new Category
            {
                Id = (Int64)dgwCategories.CurrentRow.Cells["Id"].Value,
                CategoryName = txtCategory.Text,
                Description = txtAciklama.Text
            };

            int sonuc = categoryDal.Update(category);

            if (sonuc > 0)
                MessageBox.Show("Kategori silinmiştir");
            else
                MessageBox.Show("Kayıt silme başarısız");

            RefreshScreen();
        }
    }
}
