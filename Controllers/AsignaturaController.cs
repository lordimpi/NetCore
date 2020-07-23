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
            var asignatura = new AlumnoViewModel
            {
                Nombre = "Programación",
                Id = Guid.NewGuid().ToString()
            };
            return View(asignatura);
        }

        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<AlumnoViewModel>
            {
                new AlumnoViewModel
                {
                    Nombre = "Matemáticas",
                    Id = Guid.NewGuid().ToString()
                },
                new AlumnoViewModel
                {
                    Nombre="Educación Física",
                    Id = Guid.NewGuid().ToString()
                },
                new AlumnoViewModel
                {
                    Nombre="Castellano",
                    Id = Guid.NewGuid().ToString()
                },
                new AlumnoViewModel
                {
                    Nombre="Ciencias Naturales",
                    Id = Guid.NewGuid().ToString()
                },
                new AlumnoViewModel
                {
                    Nombre="Programación",
                    Id = Guid.NewGuid().ToString()
                }
            };

            ViewBag.Fecha = DateTime.UtcNow;

            return View("MultiAsignatura", listaAsignaturas);
        }
    }
}