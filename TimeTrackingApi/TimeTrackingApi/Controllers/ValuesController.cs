using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace Testar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [EnableQuery()]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = new List<User>
            {
                new User {Id = 6, FirstName = "John", LastName = "Doe", Login = "John@gg.com", Department="Sell", IsAdmin = false},
                new User {Id = 2, FirstName = "Eric", LastName = "Evans", Login = "Eric@gg.com", Department="Sell", IsAdmin = false},
                new User {Id = 1, FirstName = "Samuel", LastName = "Davidsson", Login = "Sam@gg.com", Department="test", IsAdmin = false},
                new User {Id = 4, FirstName = "Kent", LastName = "Beck", Login = "Kent@gg.com", Department="Test", IsAdmin = true},
                new User {Id = 5, FirstName = "Uncle", LastName = "Bob", Login = "Uncle@gg.com", Department="Sell", IsAdmin = false}
            };
            return users;

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
