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
    public partial class Busqueda_de_cita : Form
    {
        public Busqueda_de_cita()
        {
            InitializeComponent();
        }

        private void btonBusca_Click(object sender, EventArgs e)
        {
            int m;
            
            conexion conexion = new conexion();
            if (Int32.TryParse(tboxid.Text, out m))
                if (conexion.buscaId(m))
                {
                    Editar_Cita editar = new Editar_Cita(m);
                    Close();
                    editar.Show();
                }
                else
                {
                    MessageBox.Show("No existe una cita con ese codigo");
                    Close();
                }
            else
            {
                MessageBox.Show("Ingrese un numero de cita valido");
                tboxid.Text = "";
            }
            
        }

        private void tboxid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
