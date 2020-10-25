using Sample.API.Enums;
using Sample.API.Models;
using Sample.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample.API.Managers
{
    public class CarsManager
    {
        public Pagination<Car> Read(CarsRequest carsRequest)
        {
            var query = new CarsRepository().Cars;

            if (!string.IsNullOrWhiteSpace(carsRequest.Make))
            {
                query = query.Where(x => x.Make.Equals(carsRequest.Make, StringComparison.InvariantCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(carsRequest.Model))
            {
                query = query.Where(x => x.Model.Equals(carsRequest.Model, StringComparison.InvariantCultureIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(carsRequest.Color))
            {
                query = query.Where(x => x.Color.Equals(carsRequest.Color, StringComparison.InvariantCultureIgnoreCase));
            }

            List<CarOptionEnum> requiredOptions = carsRequest.CarOptions?.ToList();
            if (carsRequest.CarOptions?.Count > 0)
            {
                // ANDs the car options
                if (carsRequest.CarOptionsRequired)
                {
                    foreach (var option in carsRequest.CarOptions)
                    {
                        query = query.Where(x => x.CarOptions.Contains(option));
                    }
                }
                else // ORs the car options
                {
                    query = query.Where(x => x.CarOptions.Any(option => carsRequest.CarOptions.Contains(option)));
                }
            }

            return new Pagination<Car>(query, carsRequest.Page, carsRequest.PageSize);
        }
    }
}