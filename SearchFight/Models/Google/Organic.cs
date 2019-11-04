using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFight.Models.Google
{
    public class Organic
    {
        public string position { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string destination { get; set; }
        public string description { get; set; }
        public bool isAmp { get; set; }
        public IList<Object> sitelinks { get; set; }
        public IList<Object> questions { get; set; }
    }
}
