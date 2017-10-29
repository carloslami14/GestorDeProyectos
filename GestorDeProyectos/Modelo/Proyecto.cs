using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProyectos.Modelo
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public float Abance { get; set; }
        public EstadoProyecto Estado { get; set; }
        public float Costo { get; set; }
        public Usuario Administrador { get; set; }
        public Usuario Lider { get; set; }
    }
}
