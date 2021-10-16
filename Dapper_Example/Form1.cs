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

        public void EmployeesChoose()
        {
            using (IDbConnection connection = new SqlConnection("Server =DESKTOP-DF88VQJ;Database=Northwind;Integrated Security=True;"))
            {
                connection.Open();
                List<Employees> employees = connection.Query<Employees>("Select * from Employees Where EmployeeID > 5 ").ToList();
                dataGridView1.DataSource = employees;
                connection.Close();
            }
        }

        private void btnExample_1_Click(object sender, EventArgs e)
        {
            EmployeesChoose();
        }

    }
}
