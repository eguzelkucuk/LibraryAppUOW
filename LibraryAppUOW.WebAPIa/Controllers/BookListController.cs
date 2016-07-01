using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryAppUOW.WebAPI.Controllers
{
    public class BookListController : ApiController
    {
        // GET: api/BookList
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BookList/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BookList
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BookList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BookList/5
        public void Delete(int id)
        {
        }
    }
}
