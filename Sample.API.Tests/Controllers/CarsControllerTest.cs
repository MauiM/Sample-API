using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.API.Controllers;
using Sample.API.Models;
using Sample.API.Utilities;

namespace Sample.API.Tests.Controllers
{
    [TestClass]
    public class CarsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            CarsController controller = new CarsController();
            
            Pagination<Car> results = controller.Get("kiA", "sOuL", "bLUe", "[1,5]", false, 0, 42);

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Data.Count);

            Car car = results.Data.FirstOrDefault();
            Assert.AreEqual(car.Make, "kia", true, CultureInfo.CurrentCulture);
            Assert.AreEqual(car.Model, "soul", true, CultureInfo.CurrentCulture);
            Assert.AreEqual(car.Color, "blue", true, CultureInfo.CurrentCulture);
        }

        [TestMethod]
        public void Get_LargePageSize()
        {
            CarsController controller = new CarsController();
            var ex = Assert.ThrowsException<ArgumentException>(
                () => controller.Get("kiA", "sOuL", "bLUe", "[1,5]", false, 0, Constants.MaxPageSize + 1)
            );

            string message = $"pageSize cannot be more than {Constants.MaxPageSize}.";
            Assert.AreEqual(ex.Message, message);
        }

        [TestMethod]
        public void Get_InvalidCarOptions()
        {
            CarsController controller = new CarsController();
            var ex = Assert.ThrowsException<ArgumentException>(
                () => controller.Get("kiA", "sOuL", "bLUe", "sun roof", false, 0, 10)
            );

            string message = $"carOptions had invalid json.";
            Assert.AreEqual(ex.Message, message);
        }

        [TestMethod]
        public void Get_InvalidPage()
        {
            CarsController controller = new CarsController();
            var ex = Assert.ThrowsException<ArgumentException>(
                () => controller.Get(page: 1000000)
            );
            
            Assert.IsTrue(ex.Message.StartsWith("page exceded maximum size of "));
        }
    }
}
