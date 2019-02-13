using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Boilerplate.Web.Mvc.Models;

namespace Boilerplate.Web.Mvc.Api
{
    [Route("api/sample")]
    [CamelCaseControllerConfig]
    public class SampleApiController : ApiController
    {
        public IHttpActionResult Get()
        {
            var results = new List<Person>
            {
                new Person { Name = "Henry Smith", Address="403 Main Street" },
                new Person { Name = "Julie Vasquez", Address="931 Starks Street" },
                new Person { Name = "Holly Ford", Address="192 Hillside Boulevard" }
            };

            return Ok(results);
        }
    }
}
