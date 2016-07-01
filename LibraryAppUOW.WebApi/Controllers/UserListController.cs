using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LibraryAppUOW.Domain.Entities;
using LibraryAppUOW.Domain.Services;

namespace LibraryAppUOW.WebApi.Controllers
{
    [RoutePrefix("userlist")]
    public class UserListController : ApiController
    {
       
        private IUserListService _UserlistService;

        public UserListController(IUserListService productService)
        {
            _UserlistService = productService;
        }

        [Route]
        public IEnumerable<UserList> GetAll()
        {
            return _UserlistService.GetAll().ToList().AsEnumerable();
        }

        //[Route("api/UserList/GetById/{id:int}")]
        //public UserList GetById(int id)
        //{
        //    return _UserlistService.GetById(id);
        //}

        //public void Create(UserList product)
        //{
        //    _UserlistService.Create(product);
        //}

        //public void Update(UserList product)
        //{
        //    _UserlistService.Update(product);
        //}

        //public void Delete(int id)
        //{
        //    _UserlistService.Delete(id);
        //}

    }
}
