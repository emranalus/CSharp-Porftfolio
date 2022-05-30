using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFWBeginner.Model.Abstract
{

    public enum Status
    {
        Active=1,
        Modify=2,
        Passive=3
    }

    public abstract class BaseEntity
    {
        
        public int Id { get; set; }
        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        // ? means the variable is nullable
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;

        public Status status
        {
            get { return _status; }
            set { _status = value; }
        }


    }
}
