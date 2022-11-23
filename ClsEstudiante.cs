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

        //atributos

        private int id;
        private string name;
        private string apellido;
        private string direccion;
        private string fecha_Nacimiento = "1999/07/09";
        private int cod_Carrera;

        public int Id 
        {
            get => id;

            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                }
            }
        }
        public string Name 
        {
            get => name;

            set
            {
                if (value != String.Empty)
                {
                    name = value;
                }
                else
                {
                    name = " d ";
                }
            }
        }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Fecha_Nacimiento { get => fecha_Nacimiento; set => fecha_Nacimiento = value; }
        public int Cod_Carrera { get => cod_Carrera; set => cod_Carrera = value; }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conect.desconectar();
            }

        }

        //Insertar datos del estudiante

        public void Insertar()
        {
            conect.conectar();

            cmd = new SqlCommand("INSERT INTO Alumnos VALUE (" + id + ", '" + name + "', '" + apellido + "', '" + direccion + "', '" + Fecha_Nacimiento + "', " + cod_Carrera + ")", conect.sc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos guardados");
        }

        //Cargar datos en comboBox

        public void cargarDatosComboBox(ComboBox cmb)
        {
            conect.conectar();

            try
            {
                cmd = new SqlCommand("SELECT * FROM Carreras", conect.sc);

                SqlDataReader registro = cmd.ExecuteReader();
                cmb.DisplayMember = "Text";

                while (registro.Read())
                {
                    cmb.Items.Add(new { Text = registro["NombreCar"], value = registro["CodCarrera"] }.ToString());
                }

            }
            catch (Exception)
            {

               
            }
            finally
            {
                conect.desconectar();
            }
        }

    }
}
