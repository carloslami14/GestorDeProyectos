using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProyectos.Modelo
{
    public class Tarea
    {
        public int IdTarea { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Recurso> Recursos { get; set; }
        public int Abance { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
