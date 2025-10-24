namespace StokTakipAdonet
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStocksCount = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(933, 636);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.cbDurum);
            this.gbCategory.Controls.Add(this.cbBrand);
            this.gbCategory.Controls.Add(this.cbCategory);
            this.gbCategory.Controls.Add(this.txtAra);
            this.gbCategory.Controls.Add(this.btnAra);
            this.gbCategory.Controls.Add(this.btnDelete);
            this.gbCategory.Controls.Add(this.btnUpdate);
            this.gbCategory.Controls.Add(this.btnAdd);
            this.gbCategory.Controls.Add(this.label4);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Controls.Add(this.txtPrice);
            this.gbCategory.Controls.Add(this.txtStocksCount);
            this.gbCategory.Controls.Add(this.txtAciklama);
            this.gbCategory.Controls.Add(this.label3);
            this.gbCategory.Controls.Add(this.txtProduct);
            this.gbCategory.Controls.Add(this.label6);
            this.gbCategory.Controls.Add(this.label5);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Location = new System.Drawing.Point(965, 12);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(471, 494);
            this.gbCategory.TabIndex = 1;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = " Ürün Yönetimi ";
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(20, 189);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(64, 20);
            this.cbDurum.TabIndex = 9;
            this.cbDurum.Text = " Aktif?";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(153, 285);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(293, 24);
            this.cbBrand.TabIndex = 8;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(153, 237);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(293, 24);
            this.cbCategory.TabIndex = 8;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(30, 24);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(305, 22);
            this.txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(341, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(115, 22);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(216, 441);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(153, 388);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(293, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtStocksCount
            // 
            this.txtStocksCount.Location = new System.Drawing.Point(153, 333);
            this.txtStocksCount.Name = "txtStocksCount";
            this.txtStocksCount.Size = new System.Drawing.Size(293, 22);
            this.txtStocksCount.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(153, 136);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(293, 22);
            this.txtAciklama.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(153, 81);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(293, 22);
            this.txtProduct.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 660);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.dgwProducts);
            this.Name = "ProductManagement";
            this.Text = "Ürün Yönetimi EF";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStocksCount;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbDurum;
    }
}