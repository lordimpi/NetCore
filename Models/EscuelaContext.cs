using System.ComponentModel.Design.Serialization;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<EscuelaViewModel> Escuelas { get; set; }
        public DbSet<AsignaturaViewModel> Asignaturas { get; set; }
        public DbSet<AlumnoViewModel> Alumnos { get; set; }
        public DbSet<CursoViewMoel> Cursos { get; set; }
        public DbSet<EvaluaciónViewModel> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options):base(options)
        {
            
        }
    }
}