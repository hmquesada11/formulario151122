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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();

        private void Form1_Load(object sender, EventArgs e)
        {
            conect.conectar();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormMenu menu = new FormMenu();
            menu.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            conect.desconectar();
            Application.Exit();
        }
    }
}
