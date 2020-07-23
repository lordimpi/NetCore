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
        private readonly EscuelaContext _escuelaContext;
        public EscuelaController(EscuelaContext escuelaContext)
        {
            _escuelaContext = escuelaContext;

        }

        public IActionResult Index()
        {
            var escuela = _escuelaContext.Escuelas.FirstOrDefault();
            return View(escuela);
        }
    }
}