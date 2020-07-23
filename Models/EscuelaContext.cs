using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var escuela = new EscuelaViewModel();
            escuela.AnioFundacion = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Impi School";
            escuela.Ciudad = "Popayan";
            escuela.Pais = "Colombia";
            escuela.Direccion = "Carrera 8i # 66bn - 38";
            escuela.TipoEscuela = TiposEscuelaViewModel.Secundaria;

            modelBuilder.Entity<EscuelaViewModel>().HasData(escuela);

            modelBuilder.Entity<AsignaturaViewModel>().HasData
            (
                new AlumnoViewModel{Nombre = "Matemáticas", Id = Guid.NewGuid().ToString()},
                new AlumnoViewModel{Nombre="Educación Física", Id = Guid.NewGuid().ToString()},
                new AlumnoViewModel{Nombre="Castellano", Id = Guid.NewGuid().ToString()},
                new AlumnoViewModel{Nombre="Ciencias Naturales", Id = Guid.NewGuid().ToString()},
                new AlumnoViewModel{Nombre="Programación", Id = Guid.NewGuid().ToString()}
            );

            modelBuilder.Entity<AlumnoViewModel>().HasData(GenerarAlumnoAlAzar().ToArray());
        }
        private List<AlumnoViewModel> GenerarAlumnoAlAzar()
        {
            string[] nombre1 = {"Alba", "Felipa", "Eusebio", "Santiago","Farid","Donald","Alvaro","Nicolás" };
            string[] apellido1 = { "Ruiz", "Acuña", "Uribe", "Maduro", "Trump", "Obando", "Herrera" };
            string[] nombre2 = { "Freddy", "", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new AlumnoViewModel { 
                                   Nombre = $"{n1} {n2} {a1}" ,
                                   Id = Guid.NewGuid().ToString()
                                   };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }
    }
}