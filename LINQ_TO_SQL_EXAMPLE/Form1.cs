using LINQ_TO_SQL_EXAMPLE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_TO_SQL_EXAMPLE
{
    public partial class Form1 : Form
    {
        NorthwindEntities db;
        public Form1()
        {
            db = new NorthwindEntities();
            InitializeComponent();
        }

        private void btnExample1_Click(object sender, EventArgs e)
        {
            #region Linq To Entity
            dataGridView1.DataSource = db.Products
                                      .Where(x => x.UnitsInStock > 50 && x.UnitPrice < 20)
                                      .OrderBy(x => x.ProductName)
                                      .Select(x => new
                                      {
                                          x.ProductName,
                                          x.UnitPrice,
                                          x.UnitsInStock
                                      }).ToList();
            #endregion

            #region  Linq to SQL
            var product = from x in db.Products
                          where x.UnitsInStock > 50 && x.UnitsInStock < 8
                          orderby x.ProductName
                          select new
                          {
                              x.ProductName,
                              x.UnitPrice,
                              x.UnitsInStock
                          };
            dataGridView1.DataSource = product.ToList();
            #endregion

        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            #region Linq To Entity
            dataGridView1.DataSource = db.Employees
                          .Where(x=> x.EmployeeID >= 4 && x.EmployeeID >= 8 )
                          .OrderBy(x=>x.EmployeeID)
                         .Select(x => new
           {
                FullName = x.FirstName + " " + x.LastName,
                Title = x.Title,
               
            }).ToList();
            #endregion

            #region Linq to SQL
            var employees = from x in db.Employees
                            where x.EmployeeID >= 4 && x.EmployeeID >= 8
                            orderby x.EmployeeID
                            select new
                            {
                                x.FirstName,
                                x.LastName,
                                x.Title,
                            };
            dataGridView1.DataSource = employees.ToList();

            #endregion
        }


    }
}
