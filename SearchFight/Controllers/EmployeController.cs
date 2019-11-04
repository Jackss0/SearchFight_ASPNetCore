using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SearchFight.Models;

namespace SearchFight.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        IEmployeServices _employeServices;

        public EmployeController(IEmployeServices employeServices)
        {
            System.Threading.Thread.Sleep(2500);
            _employeServices = employeServices;
            Debug.WriteLine($"Instancia solicitada por {nameof(EmployeController)}: {DateTimeOffset.Now}");
        }

        // GET: api/Employe
        [HttpGet]
        public IEnumerable<Employe> Get()
        {
            return _employeServices.GetEmployes();
        }

        // GET: api/Employe/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employe
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employe/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
