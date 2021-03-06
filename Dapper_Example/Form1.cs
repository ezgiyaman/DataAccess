using Dapper;
using Dapper_Example.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExample_1_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                List<Employees> employees = con.Query<Employees>("Select * from Employees Where EmployeeID > 5 ").ToList();
                dataGridView1.DataSource = employees;
                con.Close();
            }
        }
        private void btnExample_2_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                List<Products> products = con.Query<Products>("Select Top 10 * from Products Where UnitPrice > 20 ").ToList();
                dataGridView1.DataSource = products;
                con.Close();
            }
        }

        private void btnExample_3_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                List<Employees> employees = con.Query<Employees>("Select * from Employees where YEAR(BirthDate)>=1950 and YEAR(BirthDate)<=1961").ToList();
                dataGridView1.DataSource = employees;
                con.Close();
            }

        }
        private void btnExample_4_Click(object sender, EventArgs e)
        {

            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                List<Products> products = con.Query<Products>("Select ProductID,ProductName,UnitsInStock from Products where (ProductName Like '[A-K]%')and(UnitsInStock between 5 and 40)").ToList();
                dataGridView1.DataSource = products;
                con.Close();
            }
        }

        private void btnExample_5_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                dataGridView1.DataSource = con.Query("Select OrderID, Sum(Quantity) [Satılan Ürün] from [Order Details] group by OrderID").ToList();
                con.Close();
            }
        }

        private void btnExample_6_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
              con.Open();
              dataGridView1.DataSource = con.Query("Select OrderID,Sum(UnitPrice * Quantity * (1 - Discount)) as [Tutar] from [Order Details] group by OrderID order by 2 desc").ToList();
              con.Close();
            }
        }
        private void btnExample_7_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            { 
              con.Open();
              dataGridView1.DataSource = con.Query("Select OrderID, Sum(Quantity) as [Adet] from [Order Details] group by OrderID having sum(Quantity)> 100 order by 2 desc").ToList();
              con.Close();
            }
        }
        private void btnExample8_Click(object sender, EventArgs e)
        {  
            //Count
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                dataGridView1.DataSource = con.Query("select Country, Count(*) as [Çalışan Sayısı] from Employees group by Country").ToList();
                con.Close();
            }
        }
        private void btnExample_9_Click(object sender, EventArgs e)
        {
            //Join
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
              con.Open();
              dataGridView1.DataSource = con.Query("select c.CategoryID,c.CategoryName, p.ProductID,p.ProductName from Categories c join Products p on c.CategoryID = p.CategoryID ").ToList();
              con.Close();
            }
                
        }
    }
}
