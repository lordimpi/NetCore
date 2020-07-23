using System;
using System.Collections.Generic;

namespace NetCore.Models
{
    public class AlumnoViewModel: ObjetoEscuelaBaseViewModel
    {
        public string CursoId { get; set; }
        public CursoViewMoel Curso { get; set; }
        public List<EvaluaciónViewModel> Evaluaciones { get; set; }
    }
}