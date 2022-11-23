using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//librerias necesarias para conexion a base de datos
using System.Data;//librerias necesarias para conexion a base de datos
using System.Windows.Forms;

namespace formulario151122
{
    public class ClsConexionBD
    {
        String conex = "Data Source = HUGO-PC; Initial Catalog = Ejercicio; Integrated Security=True";

        //Instancia de conexion
        public SqlConnection sc = new SqlConnection();

        //metodo constructor
        public ClsConexionBD()
        {
            sc.ConnectionString = conex;
        }

        public void conectar() 
        {
            try
            {
                if (sc.State == ConnectionState.Closed)
                {
                    sc.Open();
                    //MessageBox.Show("Conexion abierta exitosamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar");
            }
 
        }

        public void desconectar()
        {
            try
            {
                if (sc.State == ConnectionState.Open)
                {
                    sc.Close();
                    MessageBox.Show("Conexion cerrada exitosamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al desconectar");
            }

        }
    }
}
