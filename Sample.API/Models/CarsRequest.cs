using Sample.API.Enums;
using System.Collections.Generic;

namespace Sample.API.Models
{
    public class CarsRequest
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        
        public List<CarOptionEnum> CarOptions = new List<CarOptionEnum>();
        public bool CarOptionsRequired { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}