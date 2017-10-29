using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestorDeProyectos.BD
{
    class Conexion
    {
        static SqlConnection conexion = new SqlConnection("Data Source=CARLOS-PC\\SQLEXPRESS;Initial Catalog=GestorProyecto;Integrated Security=True");

        public static bool Abrir(string cmd)
        {
            try
            {
                conexion.Open();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Cerrar(string cmd)
        {
            try
            {
                conexion.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
