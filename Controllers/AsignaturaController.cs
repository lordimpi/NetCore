using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore.Models;

namespace NetCore.Controllers
{
    public class AsignaturaController : Controller
    {
        
        public IActionResult Index()
        {
            var asignatura = new AsignaturaViewModel
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };

            ViewBag.Fecha = DateTime.UtcNow;

            return View(asignatura);
        }
    }
}