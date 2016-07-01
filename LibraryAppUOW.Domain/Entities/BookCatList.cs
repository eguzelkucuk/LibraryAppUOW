using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Domain.Entities
{
    public class BookCatList : IEntity
    {
        public virtual int ID { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int BookId { get; set; }
        public virtual DateTime RecordDate { get; set; }
    }
}
