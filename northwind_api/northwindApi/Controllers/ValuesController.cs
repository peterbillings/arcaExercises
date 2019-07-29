using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using northwindApi.NorthwindDBModel;

namespace northwindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() 
        {
            List<string> employees = new List<string>();

            using (var context = new NorthwindDBContext()) 
            {

                var employeeFirstLastNames = context.Employee
                            .Select(e => new {e.FirstName, e.LastName}); //anonymous type

                foreach (var name in employeeFirstLastNames)
                {
                    employees.Add(name.FirstName + "_" + name.LastName);
                }
            }

            
            // return "hello world";
            return employees.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
