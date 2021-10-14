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
    [Table("Categories")]
    public class Category : BaseEntity
    {
        [Required,Column(Order =2)]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        public string Picture { get; set; }
        public virtual List<Product> Product { get; set; }

    }
}
