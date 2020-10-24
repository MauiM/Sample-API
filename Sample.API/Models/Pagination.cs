using System.Collections.Generic;
using System.Linq;

namespace Sample.API.Models
{
    public class Pagination<T>
    {
        public List<T> Data { get; set; }
        public int Total { get; set; }

        public Pagination(IQueryable<T> data, int page, int pageSize)
        {
            Data = data.Take(pageSize).Skip(page * pageSize).ToList();
            Total = data.Count();
        }
    }
}