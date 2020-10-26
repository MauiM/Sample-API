using Sample.API.Enums;
using Sample.API.Models;
using System;
using System.Linq;

namespace Sample.API.Utilities
{
    public class TestCar : Car
    {
        private static readonly Random _random = new Random(DateTime.UtcNow.Millisecond);
        private static readonly object syncLock = new object();
        private static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return _random.Next(min, max);
            }
        }

        public TestCar()
        {
            int makeMax = MakeModelHelper.MakeAndModels.Count;
            int colorMax = (int)(Enum.GetValues(typeof(ColorEnum)).Cast<ColorEnum>().Last()) + 1;
            int carOptionsMax = (int)(Enum.GetValues(typeof(CarOptionEnum)).Cast<CarOptionEnum>().Last()) + 1;

            var makeAndModel = MakeModelHelper.MakeAndModels.ElementAt(RandomNumber(0, makeMax));
            int modelIndex = RandomNumber(0, makeAndModel.Value.Count);

            Id = Guid.NewGuid();
            Make = makeAndModel.Key;
            Model = makeAndModel.Value[modelIndex];
            Color = ((ColorEnum)RandomNumber(1, colorMax)).ToString();
            Price = (decimal)(RandomNumber(1000000, 5000000)) / (decimal)100.0;

            int carOptionsCount = RandomNumber(0, carOptionsMax - 1);
            while (CarOptions.Count < carOptionsCount)
            {
                CarOptionEnum carOption = (CarOptionEnum)RandomNumber(1, carOptionsMax);
                if (!CarOptions.Contains(carOption))
                {
                    CarOptions.Add(carOption);
                }
            }
        }
    }
}