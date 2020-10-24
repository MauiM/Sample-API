﻿using Sample.API.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sample.API.Repositories
{
    public class CarsRepository
    {
        private static List<Car> data = null;

        public CarsRepository()
        {
            if (data == null)
            {
                string path = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/CarData.json");
                if (File.Exists(path))
                {
                    TextReader textReader = File.OpenText(path);
                    string json = textReader.ReadToEnd();

                    data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Car>>(json);
                }
            }
        }

        public IQueryable<Car> Cars
        {
            get
            {
                return data.AsQueryable();
            }

        }
    }
}