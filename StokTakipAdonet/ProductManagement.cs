﻿using System;
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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }
        
        ProductDAL ProductDAL = new ProductDAL();

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = ProductDAL.GetProducts();
        }
    }
}
