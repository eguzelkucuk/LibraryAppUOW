using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Domain.Entities
{
    public class BookRequestList : IEntity
    {
        public virtual int ID { get; set; }
        public virtual int BookId { get; set; }
        public virtual int UserId { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual bool RequestResult { get; set; }
        public virtual DateTime RecordDate { get; set; }
    }
}
