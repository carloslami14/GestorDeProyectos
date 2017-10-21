using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeProyectos.Presentador;
using GestorDeProyectos.Interfaces;

namespace GestorDeProyectos.Vista
{
    public partial class VInicioSesion : Form, IInicioSesion
    {
        private PresentadorInicioSesion _presentador;

        public VInicioSesion()
        {
            InitializeComponent();
            _presentador = new PresentadorInicioSesion(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ValidarUsuario(tbUsuario.Text, tbContraseña.Text);
        }

        private void ValidarUsuario(string usuario, string contraseña)
        {
            _presentador.ValidarUsuario(usuario, contraseña);
        }

        public void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
