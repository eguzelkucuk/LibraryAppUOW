using LibraryAppUOW.Domain.Entities;
using LibraryAppUOW.Domain.Services;
using LibraryAppUOW.Models.UserListVM;
using System;
using System.Linq;
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
           


            var viewModel = new UserListVM();
            viewModel.Userlist = _UserlistService.GetAll();

            return View(viewModel);
        }
    }
}