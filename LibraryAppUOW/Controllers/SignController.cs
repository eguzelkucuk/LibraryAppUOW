using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryAppUOW.Controllers
{
    public class SignController : ApiController
    {
        public IEnumerable<string> All()
        {
            var a = new List<string>() { "asdas", "asdas" };
            return a.ToList().AsEnumerable();
        }
    }
}
