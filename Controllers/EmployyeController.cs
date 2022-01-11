using class_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace class_.Controllers
{
    public class EmployyeController : ApiController
    {
      static  DataContext datacontext = new DataContext();


        // GET: api/Employye
        //public IHttpActionResult Get()
        //{
        //    //List<Employyes> list1 = datacontext.Employyes.ToList();
        //    return Ok(new { list1 });
        //}

        // GET: api/Employye/5
        public async Task <IHttpActionResult> Get(int id)
        {
            try
            {
                Employyes employye = await datacontext.Employyes.FindAsync(id);
                return Ok(new { employye });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // POST: api/Employye
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employye/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Employye/5
        public void Delete(int id)
        {
        }
    }
}
