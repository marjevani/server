using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary;
using System.Web;

namespace WebApplication1.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
       // public IEnumerable<string> Get()


        //public dynamic Get()
        //{
        //    //test
        //    movieDBConnection db = new movieDBConnection();
        //    return db.Movies.Select(x => new
        //    {
        //        name = x.name,
        //        id = x.id,
        //        langth = x.langth,

        //    }).ToList();
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
