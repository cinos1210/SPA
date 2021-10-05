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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
            
        }

        private void btnAgrCita_Click(object sender, EventArgs e)
        {
            
            string fechaCitaStr = FechaCita.Value.ToString("yyyy/MM/dd");
            int servicio = Int32.Parse(cboxServicio.Text.Substring(0,2));
            conexion conexion = new conexion();
            conexion.registrarCita(tbxNombre.Text, txbCorreo.Text, txbTelefono.Text, fechaCitaStr +" "+ cboxHora.Text,servicio);
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboxHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FechaCita_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
