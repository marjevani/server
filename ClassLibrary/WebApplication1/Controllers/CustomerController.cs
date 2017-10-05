using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary;

namespace WebApplication1.Controllers
{
    //[RoutePrefix("api/Customer/")]
    public class CustomerController : ApiController
    {
        // GET: api/Costumer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/Costumer/isValidCustomer/{id}/{pass}")]
        public Customer isValidCustomer(String id, String pass)
        {
            movieDBConnection db = new movieDBConnection();
            Customer ct = db.Customers.SingleOrDefault(x => x.id == id);
            if (ct != null &&
                pass.Equals(ct.pass.Replace(" ", string.Empty)))
            {
                return ct;
            }
            return null;
        }

        // POST: api/Costumer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Costumer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Costumer/5
        public void Delete(int id)
        {
        }
    }
}
