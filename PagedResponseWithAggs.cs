using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions
{
    public class PagedResponseWithAggs<T> : PagedResponse<T>
    {
        public PagedResponseWithAggs() { }

        public PagedResponseWithAggs(PagedResponse<T> res)
        {
            this.List = res.List;
            this.Total = res.Total;
        }

        public Dictionary<string, List<AggItem>> Aggs { get; set; }
    }
}
