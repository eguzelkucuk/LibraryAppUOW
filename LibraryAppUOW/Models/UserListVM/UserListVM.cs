using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibraryAppUOW.Domain.Entities;

namespace LibraryAppUOW.Models.UserListVM
{
    public class UserListVM
    {
        public IList<UserList> Userlist { get; set; }

        
    }
}