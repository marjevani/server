using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class PlayTimeController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("api/PlayTime/{id}")]
        public int Get(int id)
        {
            movieDBConnection db = new movieDBConnection();
            return db.PlayTimes.SingleOrDefault(x => x.movie_id == id).availble_sits;
        }

        // prevent movie time Discrepancy
        [HttpGet]

        static public bool is_Valid_projc_time(DateTime projectionTime, short langth)
        {
            movieDBConnection db = new movieDBConnection();
            PlayTime closestTime;

            closestTime = db.PlayTimes.OrderBy(t => DbFunctions.DiffMinutes(t.play, projectionTime)).First();

            short duration = (closestTime.play < projectionTime) ? closestTime.Movie.langth : langth;

            if (Math.Abs((closestTime.play - projectionTime).TotalMinutes) < duration)
                return false;
            return true;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}