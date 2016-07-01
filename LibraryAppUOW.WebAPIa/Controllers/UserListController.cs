using LibraryAppUOW.Domain.Entities;
using LibraryAppUOW.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryAppUOW.WebAPI.Controllers
{
 
    public class UserListController : ApiController
    {
        private IUserListService _userlistService;

        public UserListController(IUserListService UserListService)
        {
            _userlistService = UserListService;
        }

        [Route("api/userlist/getall")]
        [HttpGet]
        public IEnumerable<UserList> GetAll()
        {
            // ensure there are products for the example
            if (!_userlistService.GetAll().Any())
            {
                _userlistService.Create(new UserList { Name = "UserList 1" });
                _userlistService.Create(new UserList { Name = "UserList 2" });
                _userlistService.Create(new UserList { Name = "UserList 3" });
            }

            return  _userlistService.GetAll();
        }
    }
}
