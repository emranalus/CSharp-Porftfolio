using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Abstract
{
    public abstract class BaseEntity
    {

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        private DateTime _createTime;

        public virtual DateTime CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

    }
}
