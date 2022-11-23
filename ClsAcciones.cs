using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace formulario151122
{
    public class ClsAcciones
    {
        ClsConexionBD con = new ClsConexionBD();

        SqlDataAdapter da;
        DataTable dt;

        //metodo para cargar datos a cualquier datagrid

        public void cargarDatos(DataGridView dgv, string nameTable)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM" + nameTable, con.sc);
                dt = new DataTable();

                da.Fill(dt);
                dgv.DataSource = dt;
            
            }
            catch (Exception)
            {
                MessageBox.Show("no se cargaron los datos");                
            }
        }
    }
}
