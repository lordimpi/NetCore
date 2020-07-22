using System;

namespace NetCore.Models
{
    public abstract class ObjetoEscuelaBaseViewModel
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBaseViewModel()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}