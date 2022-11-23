using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace formulario151122
{
    public class ClsEstudiante: ClsConexionBD
    {
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        ClsConexionBD conect = new ClsConexionBD();

        public void cargarDatosAlum(DataGridView dgv)
        {
            conect.conectar();
            try
            {
                da = new SqlDataAdapter("Select IdEstudiante, NombreEst, ApellidoEst, Direccion, Fecha_Nac, NombreCar from Alumnos join Carrera on Fk_CodCarrera = CodCarrera ", conect.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede cargar los datos", "Error");
            }
            finally
            {
                conect.desconectar();
            }

        }

    }
}
