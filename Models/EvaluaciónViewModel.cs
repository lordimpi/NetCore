using System;

namespace NetCore.Models
{
    public class EvaluaciónViewModel:ObjetoEscuelaBaseViewModel
    {
        public AlumnoViewModel Alumno { get; set; }
        public AsignaturaViewModel Asignatura  { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}