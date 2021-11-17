using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoSO productos = new ProductoSO();
            productos.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas();

            citas.Show();
        }

        private void btonEditarCita_Click(object sender, EventArgs e)
        {
            Busqueda_de_cita busqueda_De_Cita = new Busqueda_de_cita();
            busqueda_De_Cita.Show(); 
        }
    }
}
