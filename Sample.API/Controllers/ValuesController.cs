using System.Collections.Generic;
using System.Web.Http;

namespace Sample.API.Controllers
{
    public class CarsController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
