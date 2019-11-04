using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SearchFight.Models;

namespace SearchFight.Controllers
{
    public class EmployeServices : IEmployeServices
    {

        public List<Employe> GetEmployes()
        {
            List<Employe> list = new List<Employe>();
            list.Add(new Employe
            {
                Id="1", Dni="12345678", Name="Josuexd"
            });

            return list;
        }
    }
}
