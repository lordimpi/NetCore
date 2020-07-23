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
    public class AlumnoController : Controller
    {
        private readonly EscuelaContext _alumnoContext;
        public AlumnoController(EscuelaContext context)
        {
            _alumnoContext = context;
        }
        public IActionResult Index()
        {
            var alumno = _alumnoContext.Alumnos.FirstOrDefault();

            return View(alumno);
        }

        public IActionResult MultiAlumno()
        {
            var listaAlumnos = _alumnoContext.Alumnos.ToList();

            ViewBag.Fecha = DateTime.UtcNow;

            return View("MultiAlumno", listaAlumnos);
        }

        private List<AlumnoViewModel> GenerarAlumnoAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Santiago", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Acuña", "Uribe", "Maduro", "Trump", "Obando", "Herrera" };
            string[] nombre2 = { "Freddy", "", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new AlumnoViewModel
                               {
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString()
                               };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }
    }
}