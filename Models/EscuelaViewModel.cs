using System.Collections.Generic;

namespace NetCore.Models
{
    public class EscuelaViewModel:ObjetoEscuelaBaseViewModel
    {
        public int AnioFundacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public TiposEscuelaViewModel TipoEscuela { get; set; }
        public List<CursoViewMoel> Cursos { get; set; }

        public EscuelaViewModel(string nombre, int anio) => (Nombre, AnioFundacion) = (nombre, anio);
        public EscuelaViewModel(string nombre, int anio,
                       TiposEscuelaViewModel tipo,
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, AnioFundacion) = (nombre, anio);
            Pais = pais;
            Ciudad = ciudad;
        }

        public EscuelaViewModel()
        {

        }
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }    }
}