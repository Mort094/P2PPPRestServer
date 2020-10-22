using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace P2PPPRestServer.Controllers
{
    [Route("api/register")]
    [ApiController]
    public class FileEndPointsController : ControllerBase
    {
        private static Dictionary<string, List<FileEndPoint>> registry = new Dictionary<string, List<FileEndPoint>>();

        // GET: api/<FileEndPointsController>
        [HttpGet]
        [Route("{substring}")]
        public IEnumerable<FileEndPoint> GetFromSubstring(String substring)
        {
            if (registry.ContainsKey(substring))
            {
                return registry[substring];
            }
            return new List<FileEndPoint>();
        }

        // GET api/<FileEndPointsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<FileEndPointsController>
        [HttpPost]
        [Route("Register/{substring}")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FileEndPointsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FileEndPointsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
