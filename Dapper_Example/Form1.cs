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
            
        }
    }
}
