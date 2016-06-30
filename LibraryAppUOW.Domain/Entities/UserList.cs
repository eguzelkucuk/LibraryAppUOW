using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Domain.Entities
{
    public class UserList : IEntity
    {
        public virtual int ID { get; set; }

        public virtual string Name { get; set; }

        public virtual string Email { get; set; }

        public virtual int Auth { get; set; }

        public virtual string Password { get; set; }

        public virtual DateTime RecordDate { get; set; }
    }
}
