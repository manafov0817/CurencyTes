using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyConverter.Core.Models.Currency
{
    public class PaginatedResponse<T>
    {
        public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    }
}
