using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendarCitas.Controllers
{
    public class AgendarCitasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
