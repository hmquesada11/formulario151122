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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btncarreras_Click(object sender, EventArgs e)
        {
            FormCarreras carreras = new FormCarreras();

            carreras.ShowDialog();
        }

        private void btnclases_Click(object sender, EventArgs e)
        {

        }

        private void btnalumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnreportes_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
