using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeProyectos.Interfaces;

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
            if (usuario == "carlos")
            {
                if (contraseña == "1234")
                {
                    _vista.Notificar("Usuario Correcto");
                }
                else
                {
                    _vista.Notificar("Contraseña incorrecta");
                }
            }
            else
            {
                _vista.Notificar("Usuario incorrecto");
            }
        }
    }
}
