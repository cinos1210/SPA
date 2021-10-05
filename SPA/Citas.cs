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
             
            string fechaCitaStr = FechaCita.Value.ToString();
            string fechaCitaRecor=fechaCitaStr.Substring(0, 10);
            conexion conexion = new conexion();
            conexion.registrarCita(tbxNombre.Text, txbCorreo.Text, txbTelefono.Text, fechaCitaRecor + " " + cboxHora.Text);


        }
    }
}
