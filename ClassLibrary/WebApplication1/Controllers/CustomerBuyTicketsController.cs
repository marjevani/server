using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary;

namespace WebApplication1.Controllers
{
    public class CustomerBuyTicketsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public CustomerBuyTicket Put(CustomerBuyTicket cbt)
        {
            movieDBConnection db = new movieDBConnection();
            db.CustomerBuyTickets.Add(cbt);
            PlayTime p= db.PlayTimes.SingleOrDefault(x => x.movie_id == cbt.movie_id);
            p.availble_sits = p.availble_sits - (int)cbt.amount;
            db.SaveChanges();
            return cbt;
                     

             
                            
                          

  
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}