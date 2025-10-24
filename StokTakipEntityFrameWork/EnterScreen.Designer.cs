namespace StokTakipAdonet
{
    partial class EnterScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUserCheck = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUserCheck);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(203, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Kullanıcı Girişi ";
            // 
            // btnUserCheck
            // 
            this.btnUserCheck.Location = new System.Drawing.Point(128, 163);
            this.btnUserCheck.Name = "btnUserCheck";
            this.btnUserCheck.Size = new System.Drawing.Size(265, 35);
            this.btnUserCheck.TabIndex = 2;
            this.btnUserCheck.Text = "Giriş";
            this.btnUserCheck.UseVisualStyleBackColor = true;
            this.btnUserCheck.Click += new System.EventHandler(this.btnUserCheck_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(265, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Posta";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.markalarToolStripMenuItem,
            this.urunStokToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(979, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // markalarToolStripMenuItem
            // 
            this.markalarToolStripMenuItem.Name = "markalarToolStripMenuItem";
            this.markalarToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.markalarToolStripMenuItem.Text = "Markalar";
            this.markalarToolStripMenuItem.Click += new System.EventHandler(this.markalarToolStripMenuItem_Click);
            // 
            // urunStokToolStripMenuItem
            // 
            this.urunStokToolStripMenuItem.Name = "urunStokToolStripMenuItem";
            this.urunStokToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.urunStokToolStripMenuItem.Text = "Ürün Stok";
            this.urunStokToolStripMenuItem.Click += new System.EventHandler(this.urunStokToolStripMenuItem_Click);
            // 
            // EnterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "EnterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı EF (Stok Takibi)";
            this.Load += new System.EventHandler(this.EnterScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUserCheck;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunStokToolStripMenuItem;
    }
}

