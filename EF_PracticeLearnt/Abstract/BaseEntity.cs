using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_PracticeLearnt.Abstract
{

    public enum Status
    {
        Active=1,
        Passive=2
    }

    public abstract class BaseEntity
    {

        public virtual int Id { get; set; }
        public virtual Status status { get; set; }
        private DateTime _createDate = DateTime.Now;

        public virtual DateTime CreateTime
        {
            get { return _createDate = DateTime.Now; }
            set { _createDate = value; }
        }

        private DateTime _deleteDate;

        public virtual DateTime DeleteDate
        {
            get { return _deleteDate; }
            set { _deleteDate = value; }
        }

    }
}
