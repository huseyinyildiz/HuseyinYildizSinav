namespace HuseyinYildizSinav
{
    partial class Form1
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
            this.pnlListe = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.TxtCategory = new System.Windows.Forms.TextBox();
            this.pcUrunGiris = new System.Windows.Forms.SplitContainer();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCategoryName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSupplier = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUrunGiris)).BeginInit();
            this.pcUrunGiris.Panel1.SuspendLayout();
            this.pcUrunGiris.Panel2.SuspendLayout();
            this.pcUrunGiris.SuspendLayout();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListe
            // 
            this.pnlListe.BackColor = System.Drawing.Color.IndianRed;
            this.pnlListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListe.Location = new System.Drawing.Point(0, 0);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(1362, 46);
            this.pnlListe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Price,
            this.Category,
            this.Supplier});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 46);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersVisible = false;
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(1362, 669);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(241, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 49);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(680, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 64);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ürün Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(17, 13);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 49);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(73, 13);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(50, 49);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(129, 13);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 49);
            this.btnSil.TabIndex = 17;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(185, 13);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(50, 49);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // TxtCategory
            // 
            this.TxtCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCategory.Location = new System.Drawing.Point(0, 32);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(375, 26);
            this.TxtCategory.TabIndex = 22;
            // 
            // pcUrunGiris
            // 
            this.pcUrunGiris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcUrunGiris.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.pcUrunGiris.Location = new System.Drawing.Point(0, 74);
            this.pcUrunGiris.Name = "pcUrunGiris";
            // 
            // pcUrunGiris.Panel1
            // 
            this.pcUrunGiris.Panel1.Controls.Add(this.Liste);
            this.pcUrunGiris.Panel1.Controls.Add(this.pnlListe);
            // 
            // pcUrunGiris.Panel2
            // 
            this.pcUrunGiris.Panel2.BackColor = System.Drawing.Color.IndianRed;
            this.pcUrunGiris.Panel2.Controls.Add(this.button1);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtSupplier);
            this.pcUrunGiris.Panel2.Controls.Add(this.label6);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtProductPrice);
            this.pcUrunGiris.Panel2.Controls.Add(this.label5);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtCategoryName);
            this.pcUrunGiris.Panel2.Controls.Add(this.label4);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtProductName);
            this.pcUrunGiris.Panel2.Controls.Add(this.label99);
            this.pcUrunGiris.Panel2.Controls.Add(this.label3);
            this.pcUrunGiris.Panel2.Controls.Add(this.btnAddCategory);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtCategory);
            this.pcUrunGiris.Panel2.Controls.Add(this.label2);
            this.pcUrunGiris.Size = new System.Drawing.Size(1749, 719);
            this.pcUrunGiris.SplitterDistance = 1366;
            this.pcUrunGiris.TabIndex = 3;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.IndianRed;
            this.pnlUst.Controls.Add(this.btnPrint);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Controls.Add(this.btnKaydet);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1749, 74);
            this.pnlUst.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCategory.Location = new System.Drawing.Point(0, 58);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(375, 40);
            this.btnAddCategory.TabIndex = 23;
            this.btnAddCategory.Text = "Submit";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Add Product";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label99
            // 
            this.label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label99.Dock = System.Windows.Forms.DockStyle.Top;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label99.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label99.Location = new System.Drawing.Point(0, 130);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(375, 32);
            this.label99.TabIndex = 25;
            this.label99.Text = "Product Name";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtProductName.Location = new System.Drawing.Point(0, 162);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(375, 26);
            this.TxtProductName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Product Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCategoryName.FormattingEnabled = true;
            this.TxtCategoryName.Items.AddRange(new object[] {
            "Doktor",
            "Firma",
            "Hastane",
            "Personel",
            "Diger"});
            this.TxtCategoryName.Location = new System.Drawing.Point(0, 220);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(375, 28);
            this.TxtCategoryName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Product Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtProductPrice
            // 
            this.TxtProductPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtProductPrice.Location = new System.Drawing.Point(0, 280);
            this.TxtProductPrice.Name = "TxtProductPrice";
            this.TxtProductPrice.Size = new System.Drawing.Size(375, 26);
            this.TxtProductPrice.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(0, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = "Supplier Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtSupplier.FormattingEnabled = true;
            this.TxtSupplier.Items.AddRange(new object[] {
            "Doktor",
            "Firma",
            "Hastane",
            "Personel",
            "Diger"});
            this.TxtSupplier.Location = new System.Drawing.Point(0, 338);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.Size = new System.Drawing.Size(375, 28);
            this.TxtSupplier.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 40);
            this.button1.TabIndex = 33;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 59;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.Width = 109;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 8;
            this.Supplier.Name = "Supplier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 793);
            this.Controls.Add(this.pcUrunGiris);
            this.Controls.Add(this.pnlUst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pcUrunGiris.Panel1.ResumeLayout(false);
            this.pcUrunGiris.Panel2.ResumeLayout(false);
            this.pcUrunGiris.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUrunGiris)).EndInit();
            this.pcUrunGiris.ResumeLayout(false);
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox TxtCategory;
        private System.Windows.Forms.SplitContainer pcUrunGiris;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TxtSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TxtCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
    }
}

