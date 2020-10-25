using Sample.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample.API.Models
{
    public class Pagination<T> : ApiResult<List<T>>
    {
        public int Total { get; set; }

        public Pagination(IQueryable<T> data, int page, int pageSize)
        {
            DataValidator.NonNegativeInt(page, nameof(page));

            DataValidator.PositiveInt(pageSize, nameof(pageSize));
            DataValidator.MaxValue(pageSize, Constants.MaxPageSize, nameof(pageSize));

            Total = data.Count();

            int pageMax = (int)(Total / pageSize);
            if (page > pageMax)
            {
                throw new ArgumentException($"page exceded maximum size of {pageMax}.");
            }

            Data = data.Take(pageSize).Skip(page * pageSize).ToList();
        }
    }
}