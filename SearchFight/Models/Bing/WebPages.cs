using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFight.Models
{
    public class WebPages
    {
        public string webSearchUrl { get; set; }
        public Int64 totalEstimatedMatches { get; set; }
        public IList<Object> value { get; set; }
    }
}
