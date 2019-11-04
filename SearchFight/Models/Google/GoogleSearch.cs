using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFight.Models.Google
{
    public class GoogleSearch
    {
        public string engine = "Google";
        public Query query { get; set; }
        public IList<Organic> organic { get; set; }
        public IList<Object> related_searches { get; set; }
        public Int64 number_of_results { get; set; }
    }
}
