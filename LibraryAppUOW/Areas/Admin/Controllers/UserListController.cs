using LibraryAppUOW.Domain.Entities;
using LibraryAppUOW.Domain.Services;
using LibraryAppUOW.Models.UserListVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryAppUOW.Areas.Admin.Controllers
{
    public class UserListController : BaseController
    {
        private IUserListService _UserlistService;

        public UserListController(IUserListService productService)
        {
            _UserlistService = productService;
        }

        public ActionResult Index()
        {
            if (!_UserlistService.GetAll().Any())
            {
                _UserlistService.Create(new UserList { Name = "Erkan GÜZELKÜÇÜK", Auth = 1, Email = "guzelkucukerkan@gmail.com", Password = "***", RecordDate = DateTime.Now });

                _UserlistService.Create(new UserList { Name = "Dilek GÜZELKÜÇÜK", Auth = 0, Email = "guzelkucukdilek@gmail.com", Password = "***", RecordDate = DateTime.Now });

            }

            var viewModel = new UserListVM();
            viewModel.Userlist = _UserlistService.GetAll();

            return View(viewModel);
        }
    }
}