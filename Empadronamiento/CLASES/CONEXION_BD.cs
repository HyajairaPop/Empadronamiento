using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Registro_Ciudadanos
{
    class CONEXIONBD
    {
        string cadena = @"Data Source=DESKTOP-M7KI6LL\YAHAIRA;Initial Catalog=RegistroCiudadanos;Integrated Security=true;";

        public SqlConnection conectarBD = new SqlConnection();

        public CONEXIONBD()
        {
            conectarBD.ConnectionString = cadena;
        }
        public void ABRIR()
        {
            try
            {
                conectarBD.Open();
                Console.WriteLine("LA CONEXION HA SIDO HECHA");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SE HA PRODUCIDO UN ERROR AL INTENTAR CONECTAR LA BASE DE DATOS" + ex.Message);
            }
        }

        public void CERRAR()
        {
            conectarBD.Close();
        }
    }
}
