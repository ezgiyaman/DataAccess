using ETicaret_Db_CodeFirst.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Db_CodeFirst.Models.Concrete
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate{ get; set; }

        public int EmployeeId { get; set; }
        public virtual Employees Employees { get; set; }


        public int ShipperId { get; set; }
        public virtual Shipper Shipper { get; set; }


        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }



    }
}
