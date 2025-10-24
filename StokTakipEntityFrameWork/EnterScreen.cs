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
    public partial class EnterScreen : Form
    {
        public EnterScreen()
        {
            InitializeComponent();
        }

        DatabaseContext dbContext = new DatabaseContext();


        private void EnterScreen_Load(object sender, EventArgs e)
        {
            menuStripMain.Visible = false;

        }

        private void btnUserCheck_Click(object sender, EventArgs e)
        {
            List<Users> users = dbContext.Users.ToList();

            foreach (var user in users)
            {
                if (user.Email == txtEmail.Text && user.Password == txtPassword.Text)
                {
                    menuStripMain.Visible = true;
                    MessageBox.Show("Giriş Başarılı!");
                    return;
                }
            }

            menuStripMain.Visible = false;

            MessageBox.Show("Giriş Başarısız!");
            return;
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement();
            categoryManagement.ShowDialog();
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandManagement brandManagement = new BrandManagement();
            brandManagement.ShowDialog();
        }

        private void urunStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.ShowDialog();
        }
    }
}
