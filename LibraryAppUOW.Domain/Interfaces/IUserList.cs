using LibraryAppUOW.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppUOW.Domain.Interfaces
{
    public interface IUserList 
    {
        IList<UserList> GetAll();
        UserList GetById(int id);
        void Create(UserList User);
        void Update(UserList User);
        void Delete(int id);
    }
}
