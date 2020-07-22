using System;
using System.Collections.Generic;

namespace NetCore.Models
{
    public class AlumnoViewModel: ObjetoEscuelaBaseViewModel
    {
        public List<EvaluaciónViewModel> Evaluaciones { get; set; } = new List<EvaluaciónViewModel>();
    }
}