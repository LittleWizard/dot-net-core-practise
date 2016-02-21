using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using explore_core.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace explore_core.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET: api/runners
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();
            runners.Add(new Runner(){Id = 1, First = "Tanmoy", Last = "Majumdar", Age = 29, FavoriteBeer = "Water"});
            runners.Add(new Runner(){Id = 2, First = "Hello", Last = "World", Age = 29, FavoriteBeer = "Water"});
            runners.Add(new Runner(){Id = 3, First = "Ohh", Last = "Ya", Age = 29, FavoriteBeer = "Water"});
            return runners.ToArray();
        }

        // GET api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(b => b.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
