using SearchFight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFight.Controllers
{
    public interface IEmployeServices
    {
        List<Employe> GetEmployes();
    }
}
