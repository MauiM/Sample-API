using Sample.API.Enums;
using System;
using System.Collections.Generic;

namespace Sample.API.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public List<CarOptionEnum> CarOptions { get; set; } = new List<CarOptionEnum>();
    }
}