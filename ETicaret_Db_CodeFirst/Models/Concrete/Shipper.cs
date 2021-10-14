using ETicaret_Db_CodeFirst.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Db_CodeFirst.Models.Concrete
{
   
    public class Shipper : BaseEntity
    {
        [Required, Column(Order = 2)]
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
