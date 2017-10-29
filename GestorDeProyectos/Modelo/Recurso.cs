using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProyectos.Modelo
{
    public class Recurso
    {
        public int IdRecurso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public TipoRecurso Tipo { get; set; }
    }
}
