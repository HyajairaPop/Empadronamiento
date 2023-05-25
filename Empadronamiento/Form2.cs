using Registro_Ciudadanos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CONEXIONBD conexion = new CONEXIONBD();
            conexion.ABRIR();

            string nombres = nombre.Text;
            string apellidos = apellido.Text;
            string fechadenacimiento = fecha.Text;
            string numerodepdi = dpi.Text;
            string deptoderesidencia = depto.Text;
            string municipioderesidencia = municipio.Text;
            string correoelectronico = correo.Text;

            string cadena = "insert into RegistroCiudadanos (nombre,apellido,dpi,fechadenacimiento,departamentoderesidencia,municipioderesidencia,correoelectronico) values " +
                "('" + nombre.Text + "', '" + apellido.Text + "', '" + fecha.Text + "', '" + dpi.Text + "', '" + depto.Text + "', '" + municipio.Text + "', '" + correo.Text + "')";
           
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarBD);
            comando.ExecuteNonQuery();
            MessageBox.Show("** SE HA AGREGADO UN NUEVO REGISTRO DE EMPADRONADO **");

            nombre.Text = "";
            apellido.Text = "";
            fecha.Text = "";
            dpi.Text = "";
            depto.Text = "";
            municipio.Text = "";
            correo.Text = "";

        }
    }
}
