using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFight.Models
{
    public class BingSearch
    {
        public string engine = "Bing";
        public string _type { get; set; }
        public QueryContext queryContext { get; set; }
        public WebPages webPages { get; set; }
        public Object relatedSearches { get; set; }
        public Object videos { get; set; }
        public Object rankingResponse { get; set; }

        public class QueryContext
        {
            public string originalQuery { get; set; }
        }
    }
}
