namespace StokTakipAdonet
{
    partial class CategoryManagement
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
            this.dgwCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).BeginInit();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCategories
            // 
            this.dgwCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategories.Location = new System.Drawing.Point(12, 21);
            this.dgwCategories.Name = "dgwCategories";
            this.dgwCategories.RowHeadersWidth = 51;
            this.dgwCategories.RowTemplate.Height = 24;
            this.dgwCategories.Size = new System.Drawing.Size(876, 584);
            this.dgwCategories.TabIndex = 0;
            this.dgwCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategories_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kateogori Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(142, 81);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(273, 22);
            this.txtCategory.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(142, 136);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(273, 22);
            this.txtAciklama.TabIndex = 4;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.txtAra);
            this.gbCategory.Controls.Add(this.btnAra);
            this.gbCategory.Controls.Add(this.btnDelete);
            this.gbCategory.Controls.Add(this.btnUpdate);
            this.gbCategory.Controls.Add(this.btnAdd);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Controls.Add(this.txtAciklama);
            this.gbCategory.Controls.Add(this.txtCategory);
            this.gbCategory.Controls.Add(this.label2);
            this.gbCategory.Location = new System.Drawing.Point(894, 21);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(421, 247);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = " Kategori Yönetimi ";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(0, 24);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(305, 22);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(311, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(104, 22);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(271, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(142, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 36);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 617);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.dgwCategories);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Yönetimi EF";
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).EndInit();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
    }
}