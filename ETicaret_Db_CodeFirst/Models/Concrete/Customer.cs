using ETicaret_Db_CodeFirst.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Db_CodeFirst.Models.Concrete
{
    public class Customer : BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}
       
        
