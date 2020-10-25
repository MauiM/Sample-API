using Newtonsoft.Json;
using System;

namespace Sample.API.Utilities
{
    public class DataValidator
    {
        public static void PositiveInt(int param, string paramName)
        {
            if (param < 1)
            {
                throw new ArgumentException($"{paramName} cannot be less than 1.");
            }
        }

        public static void NonNegativeInt(int param, string paramName)
        {
            if (param < 0)
            {
                throw new ArgumentException($"{paramName} cannot be less than 0.");
            }
        }

        public static void MaxValue(int param, int maxValue, string paramName)
        {
            if (param > maxValue)
            {
                throw new ArgumentException($"{paramName} cannot be more than {maxValue}.");
            }
        }

        public static T ValidJson<T>(string json, string paramName)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    return JsonConvert.DeserializeObject<T>(json);
                }
                catch
                {
                    throw new ArgumentException($"{paramName} had invalid json.");
                }
            }

            return default(T);
        }
    }
}