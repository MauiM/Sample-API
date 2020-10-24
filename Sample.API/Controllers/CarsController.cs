using Sample.API.Models;
using Sample.API.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace Sample.API.Controllers
{
    public class CarsController : ApiController
    {
        [HttpGet]
        public JsonResult<Pagination<Car>> Get()
        {
            var results = new Pagination<Car>(new CarsRepository().Cars, 0, 10);
            return new JsonResult<Pagination<Car>>(results);
        }
    }
}
