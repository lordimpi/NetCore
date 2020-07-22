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
    public class EscuelaController : Controller
    {
        
        public IActionResult Index()
        {
            var escuela = new EscuelaViewModel();
            escuela.AnioFundacion = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "ImpiSchool";
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Popayán";
            escuela.Direccion = "Carrera 8i # 66bn - 38";
            escuela.TipoEscuela = TiposEscuelaViewModel.Secundaria;
            return View(escuela);
        }
    }
}