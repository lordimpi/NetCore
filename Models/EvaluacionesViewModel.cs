using System;

namespace NetCore.Models
{
    public class EvaluacionesViewModel
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public AlumnoViewModel Alumno { get; set; }
        public AsignaturaViewModel Asignatura  { get; set; }

        public float Nota { get; set; }

        public EvaluacionesViewModel() => UniqueId = Guid.NewGuid().ToString();
    }
}