using Microsoft.AspNetCore.Mvc;
using SearchFightWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchFightWeb.Controllers
{
    public class FooController : Controller
    {
        private readonly IData _data;

        public FooController(IServiceProvider serviceProvider, IData data)
        {
            var myService = new MyService(serviceProvider);
            System.Threading.Thread.Sleep(2500);
            _data = data;
            _data.Append($"{nameof(FooController)} " + DateTime.Now + " | ");
        }

        public IActionResult Index()
        {
            var viewModel = new DataViewModel(_data.Get());

            return View(viewModel);
        }
    }

    public class MyService
    {
        public MyService(IServiceProvider serviceProvider)
        {
            var data = (IData)serviceProvider.GetService(typeof(IData));
            data.Append($"{nameof(MyService)} " + DateTime.Now + " | ");
        }
    }
}
