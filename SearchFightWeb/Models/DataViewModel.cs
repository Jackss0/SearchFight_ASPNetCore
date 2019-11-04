using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFightWeb.Models
{
    public class DataViewModel
    {
        public string Info { get; }

        public DataViewModel(string info)
        {
            Info = info;
        }
    }
}
