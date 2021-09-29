using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAgendarCitas.Controllers
{
    public class AgendarCitaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult registro()
        {
            return View();
        }
    }
}
