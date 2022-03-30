using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuseyinYildizSinav.Entity;

namespace HuseyinYildizSinav
{
    public partial class Form1 : Form
    {
        private int secimId=-1;
        private readonly ProjectDbContext _db = new ProjectDbContext();
        private Product kayitBul;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ForComboBox();
            ProductList();
        }

        private void ForComboBox()
        {
            TxtSupplier.DataSource = Enum.GetValues(typeof(SuppliersName));
            TxtSupplier.SelectedIndex = -1;

            var srg = _db.Categories;
            TxtCategoryName.DataSource = srg.ToList();
            TxtCategoryName.ValueMember = "Id";
            TxtCategoryName.DisplayMember = "CategoryName";
            TxtCategoryName.SelectedIndex = -1;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryAdd();
        }

        private void CategoryAdd()
        {
            Category category = new Category();
            category.CategoryName = TxtCategory.Text;
            _db.Categories.Add(category);
            _db.SaveChanges();
            MessageBox.Show("Successfully added Category");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductAdd();
        }

        private void ProductAdd()
        {
            if (TxtProductName.Text == "")
            {
                MessageBox.Show("İlgili alanlar doldurulmadan kayıt yapılamaz.");
                return;
            }
            try
            {
                Product prd = new Product();
                //if (TxtCategoryName.SelectedValue != null) prd.Category.Id = (int) TxtCategoryName.SelectedValue;
               // prd.Category.CategoryName = Convert.ToString(TxtCategoryName.SelectedValue);
               // prd.Category.CategoryName = TxtCategoryName.Text;
              // prd.Category.CategoryName = TxtCategoryName.Text;
               prd.ProductName = TxtProductName.Text;
               prd.Price = Convert.ToInt32(TxtProductPrice.Text);
               prd.Supplier = TxtSupplier.Text;
               if (TxtCategoryName.SelectedValue != null)
               {
                   prd.CategoryId = (int) TxtCategoryName.SelectedValue;
               }


                _db.Products.Add(prd);
                _db.SaveChanges();
                MessageBox.Show("Product Added Successfully.");
                ProductList();
                ProductClear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "HataKodu : HGK100");

            }

        }

        private void ProductClear()
        {
            foreach (Control k in pcUrunGiris.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
                TxtCategoryName.SelectedIndex = -1;
                TxtSupplier.SelectedIndex = -1;


            }
        }

        private List<Product> prdList;
        private void ProductList()
        {
            int i = 0;

            prdList = (from s in _db.Products select s).ToList();//Products tablosunda bilgi getirir

            foreach (var item in prdList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = item.Id;
                Liste.Rows[i].Cells[1].Value = item.ProductName;
                Liste.Rows[i].Cells[2].Value = item.Price;
                Liste.Rows[i].Cells[4].Value = item.Supplier;
                

                if (item.Category != null)
                {
                    Liste.Rows[i].Cells[3].Value = item.Category.CategoryName;
                }


                i++;

            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void UpdateProduct()
        {
          

            if (secimId < 0)
            {
                MessageBox.Show("Değiştirilecek kayıt bulunamadı, önce bir kayıt seçin.");
                return;
            }
            if (kayitBul != null)
            {
                kayitBul.ProductName = TxtProductName.Text;
                if (TxtCategoryName.SelectedValue != null)
                {
                    kayitBul.Category.CategoryName = Convert.ToString(TxtCategoryName.SelectedValue);
                }

                kayitBul.Price = Convert.ToInt32(TxtProductPrice.Text);
                

           
            }
            _db.SaveChanges();
            MessageBox.Show("Güncelleme yapıldı.");
            ProductClear();
            ProductList();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int) Liste.CurrentRow.Cells[0].Value;
            Ac(secimId);
        }

        private void Ac(int id)
        {
            secimId = id;
            if (secimId < 0)
            {
                MessageBox.Show("Kayıt Id Bulunamadı.");
                return;

            }
           
            //tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId); //DBden gelen ilgili ıd yi bulur kayıtbula atar
            kayitBul = prdList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                if (kayitBul != null)
                {
                    TxtProductName.Text = kayitBul.ProductName;
                    TxtProductPrice.Text = Convert.ToString(kayitBul.Price);
                    TxtCategoryName.Text = kayitBul.Category.CategoryName;
                    TxtSupplier.Text = kayitBul.Supplier;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGListe101");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ProductClear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void DeleteProduct()
        {
            if (secimId > 0)
            {
                _db.Products.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydınız silinmiştir.Geçmiş olsun");
                ProductClear();
                ProductList();
            }
        }
    }
}
