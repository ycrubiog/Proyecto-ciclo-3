using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAgendarCitas.Controllers
{
    public class ConsultarCitaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
