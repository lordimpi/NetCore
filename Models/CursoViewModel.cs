using System;
using System.Collections.Generic;


namespace NetCore.Models
{
    public class CursoViewMoel : ObjetoEscuelaBaseViewModel
    {
        public TiposJornadaViewModel Jornada { get; set; }
        public List<AlumnoViewModel> Asignaturas{ get; set; }
        public List<AlumnoViewModel> Alumnos{ get; set; }

        public string Dirección { get; set; }

    }
}