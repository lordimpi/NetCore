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
                Nombre = "Programación",
                UniqueId = Guid.NewGuid().ToString()
            };
            return View(asignatura);
        }

        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<AsignaturaViewModel>
            {
                new AsignaturaViewModel
                {
                    Nombre = "Matemáticas",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new AsignaturaViewModel
                {
                    Nombre="Educación Física",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new AsignaturaViewModel
                {
                    Nombre="Castellano",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new AsignaturaViewModel
                {
                    Nombre="Ciencias Naturales",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new AsignaturaViewModel
                {
                    Nombre="Programación",
                    UniqueId = Guid.NewGuid().ToString()
                }
            };

            ViewBag.Fecha = DateTime.UtcNow;

            return View("MultiAsignatura", listaAsignaturas);
        }
    }
}