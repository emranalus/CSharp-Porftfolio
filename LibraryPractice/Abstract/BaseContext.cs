using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice.Abstract
{

    public enum Status
    {
        Active=1,
        Passive=2
    }

    public abstract class BaseContext
    {

        public int Id { get; set; }
        public Status status { get; set; }

        private DateTime _createDate;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        private DateTime _deleteDate;

        public DateTime DeleteDate
        {
            get { return _deleteDate; }
            set { _deleteDate = value; }
        }


    }
}
