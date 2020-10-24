using Sample.API.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Sample.API.Controllers
{
    public class CarTestDataController : ApiController
    {
        [HttpGet]
        public List<Car> GenerateTestCars(int count)
        {
            List<Car> generatedCars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                Car testCar = new Utilities.TestCar();
                generatedCars.Add(testCar);
            }

            return generatedCars;
        }
    }
}
