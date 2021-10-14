using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Db_CodeFirst.Models.Abstract
{
    public enum Status { Active = 1, Modified = 2, Deleted = 3 }
    public abstract class BaseEntity
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreatDate { get => _createDate; set => _createDate = value; }
     
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }

}
