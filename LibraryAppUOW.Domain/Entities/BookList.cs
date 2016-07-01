using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Domain.Entities
{

    public class BookList : IEntity
    {
        public virtual int ID { get; set; }
        public virtual string BookName { get; set; }
        public virtual string BookDescription { get; set; }
        public virtual DateTime RecordDate { get; set; }
    }
}
