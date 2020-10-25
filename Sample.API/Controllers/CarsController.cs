using Sample.API.Enums;
using Sample.API.Managers;
using Sample.API.Models;
using Sample.API.Utilities;
using System.Collections.Generic;
using System.Web.Http;

namespace Sample.API.Controllers
{
    public class CarsController : ApiController
    {
        [HttpGet]
        public JsonResult<Pagination<Car>> Get(
            [FromUri]string make = null,
            [FromUri]string model = null,
            [FromUri]string color = null,
            [FromUri]string carOptions = null,
            [FromUri]bool carOptionsRequired = false,
            [FromUri]int page = 0, 
            [FromUri]int pageSize = 10
        )
        {
            CarsRequest carsRequest = new CarsRequest();
            carsRequest.Make = make;
            carsRequest.Model = model;
            carsRequest.Color = color;
            carsRequest.CarOptions = DataValidator.ValidJson<List<CarOptionEnum>>(carOptions, nameof(carOptions));
            carsRequest.CarOptionsRequired = carOptionsRequired;
            carsRequest.Page = page;
            carsRequest.PageSize = pageSize;
            
            var results = new CarsManager().Read(carsRequest);

            return new JsonResult<Pagination<Car>>(results);
        }
    }
}
