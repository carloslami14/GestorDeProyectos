using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeProyectos.Interfaces;
using GestorDeProyectos.BD;

namespace GestorDeProyectos.Presentador
{
    public class PresentadorInicioSesion
    {
        private readonly IInicioSesion _vista;

        public PresentadorInicioSesion(IInicioSesion vista)
        {
            _vista = vista;
        }

        public void ValidarUsuario(string usuario, string contraseña)
        {
           
        }
    }
}
