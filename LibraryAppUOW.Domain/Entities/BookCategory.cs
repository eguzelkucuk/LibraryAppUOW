using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Domain.Entities
{
    public class BookCategory : IEntity
    {
        public virtual int ID { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual DateTime RecordDate { get; set; }
    }
}
