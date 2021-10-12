using DbFirst_LINO_Methods.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirst_LINO_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();

        private void btnToList_Click(object sender, EventArgs e)
        {
            //ToList() => Koleksiyonda bulunan verileri list'e dönüştürür.

            dataGridView1.DataSource = db.Employees.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock > 100 && x.UnitsInStock < 200).ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Order_Details.Where(x => x.Quantity < 50 && x.UnitPrice == 10)
                                                      .Select(x => new
                                                      {
                                                          x.Quantity,
                                                          x.UnitPrice
                                                      })
                                                      .ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees
                                       .Where(x => x.EmployeeID >= 1 && x.EmployeeID <= 5)
                                       .OrderBy(x => x.FirstName)
                                       .Select(x => new
                                       {
                                           x.FirstName,
                                           x.LastName,
                                           x.EmployeeID

                                       }).ToList();
        }

        private void BtnOrderByDescending_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees
                                       .OrderByDescending(x => x.EmployeeID)
                                       .Select(x => new
                                       {
                                           x.FirstName,
                                           x.EmployeeID,
                                           x.TitleOfCourtesy,

                                       }).ToList();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //First() => Sorgu sonucunda ilk elemanı seçmek için kullanılır.
            //First kullanılırken eğer veri tabanında olmayan bir datanın getirilmesi isteniyorsa uygulama exception fırlatır.Bunun için try-catch kullanırız.
            try
            {
                Employee employee = db.Employees.First(x => x.FirstName == "Davolia");
                MessageBox.Show($"Çalışanın adı : {employee.FirstName}");
            }
            catch
            {
                MessageBox.Show("Aradığınız çalışan bulunamamaktadır.");
            }
        }

        private void btnFirstOfDefault_Click(object sender, EventArgs e)
        {
            //FirstOfDefault() =>Sorgu sonucunda ilk elemanı seçmek için kullanılır."Exception" fırlatmaz.

            Category category = db.Categories.FirstOrDefault(x => x.CategoryID > 15);

            if (category == null)
                MessageBox.Show($"Aradığınız kategori bulunmamaktadır.");
            else
                MessageBox.Show($"Aradığınız kategorinin adı : {category.CategoryName}");

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Find() => Id gibi biricik alanların filtrelemesinde kullanılır.

            Product product = db.Products.Find(20);
            if (product == null)
                MessageBox.Show("Aradığınız ürün bulunmamaktadır");
            else
                MessageBox.Show($"Aradığınız ürünün adı : {product.ProductName}");
        }

        private void btnTake_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Categories
                                       .Where(x => x.CategoryID > 3)
                                       .Select(x => new
                                       {
                                           x.CategoryID,
                                           x.CategoryName,
                                           x.Description
                                       })
                                       .Take(5)
                                       .ToList();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Products
                                       .Where(x => x.UnitPrice > 50)
                                       .OrderByDescending(x => x.UnitsInStock)
                                       .Select(x => new
                                       {
                                           x.ProductName,
                                           x.UnitPrice,
                                           x.UnitsInStock
                                       })
                                       .Skip(3)
                                       .Take(3)
                                       .ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers
                                    .Where(x => x.CompanyName.Contains("k"))
                                    .Select(x => new
                                    {
                                        x.City,
                                        x.CustomerID,
                                        x.CompanyName
                                    })
                                    .Skip(4)
                                    .Take(6)
                                    .ToList();
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => x.LastName.StartsWith("d")).ToList();
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => x.LastName.EndsWith("n")).ToList();
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            bool result = db.Suppliers.Any(x => x.ContactName == "Peter Wilson");

            MessageBox.Show(result.ToString());


            bool harf = db.Categories.Any(x => x.CategoryName.EndsWith("ts"));

            MessageBox.Show(result.ToString());

            bool cevap = db.Customers.Any(x => x.CompanyName.StartsWith("co"));

            MessageBox.Show(result.ToString());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int city = db.Customers.Count();
            MessageBox.Show("Sehir Sayısı: " + city);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int? stok = db.Products.Sum(x => x.UnitsInStock);
            MessageBox.Show(stok.ToString());
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            decimal? enUcuzUrun = db.Products.Min(x => x.UnitPrice);

            decimal? enPahaliUrun = db.Products.Max(x => x.UnitPrice);

            MessageBox.Show($"En ucuz Ürün  : {enUcuzUrun}\n En Pahalı Ürün:{enPahaliUrun}");
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            List<string> countries = db.Employees.Select(x => x.Country).Distinct().ToList();

            foreach (var item in countries)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName)
                                                .Select(x => new
                                                {
                                                    kategoriadı = x.Key,
                                                    ToplamStok = x.Sum(z => z.UnitsInStock)
                                                }).Take(5)
                                                .ToList();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                 .Join(db.Order_Details, p => p.ProductID, od => od.ProductID, (p, od) => new { p, od }) 
                 .GroupBy(x => x.p.ProductName)
                 .Select(x => new
                 {
                     UrunAdi = x.Key,
                     Mıktar = x.Sum(z => z.od.Quantity),
                     Gelir = x.Sum(z => z.od.Quantity * z.od.UnitPrice * (int)Math.Floor(1 - z.od.Discount))
                 })
                 .OrderByDescending(x => x.Gelir)
                 .ToList();
        }
    }
    
}

       
         
    

       
    

