using System;
using System.Collections.Generic;

namespace NetCore.Models
{
    public class AsignaturaViewModel : ObjetoEscuelaBaseViewModel
    {
        public string CurdoId { get; set; }
        public CursoViewMoel Curso { get; set; }
        public List<EvaluaciónViewModel> Evaluaciones { get; set; }

    }
}