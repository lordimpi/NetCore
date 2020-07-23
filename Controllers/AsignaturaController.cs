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
        private readonly EscuelaContext _asignaturaContext;
        public AsignaturaController(EscuelaContext context)
        {
            _asignaturaContext = context;

        }
        public IActionResult Index()
        {
            return View(_asignaturaContext.Asignaturas.FirstOrDefault());
        }

        public IActionResult MultiAsignatura()
        {
            ViewBag.Fecha = DateTime.UtcNow;

            return View("MultiAsignatura", _asignaturaContext.Asignaturas);
        }
    }
}