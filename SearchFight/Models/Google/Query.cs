using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFight.Models.Google
{
    public class Query
    {
        public string q { get; set; }
        public string hl { get; set; }
        public string gl { get; set; }
        public string location { get; set; }
        public string search_engine { get; set; }
        public string apikey { get; set; }
        public string url { get; set; }
    }
}
