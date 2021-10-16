using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Example.Entities.Abstract
{
    public enum Status { Active = 1, Modified = 2, Deleted = 3 }
    public abstract class BaseEntity
    {
        private DateTime _createDate = DateTime.Now;
        public DateTime CreatDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }

    }
}
