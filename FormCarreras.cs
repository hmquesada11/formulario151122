using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario151122
{
    public partial class FormCarreras : Form
    {
        public FormCarreras()
        {
            InitializeComponent();
        }
        int i;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {

                }
                else
                {


                    
                }
            }
            catch (Exception ex)
            {

                
            }


        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodigocarrer.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione un dato para actualizar", "Error");
                }
                else
                {
                    if(i !=1)
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvcarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;

            txtcodigocarrer.Text = dgvcarreras.CurrentRow.Cells[0].Value.ToString();
            txtcodigocarrer.Enabled = false;
            txtnomcarrer.Text = dgvcarreras.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
