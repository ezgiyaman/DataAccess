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
    [Table("Suppliers")]
    public class Supplier : BaseEntity
    {
        [Required,Column(Order = 2)]
        public string CompanyName { get; set; }
        [Required, Column(Order = 3)]
        public string ContactName { get; set; }
        [Required]
        public string  Adress { get; set; }
        [Required]
        public string City{ get; set; }
        [Required]
        public string Country { get; set; }
        public virtual List<Product> Products { get; set; }


    }
}
