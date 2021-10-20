using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.Logging;

namespace SPA
{
    public partial class Citas : Form
    {
        conexion conexion = new conexion();
        int nIma = 0;
        Image[] arr;
        int conImagen = 0;
        public Citas()
        {
            
            InitializeComponent();
            tbxNombre.MaxLength=100;
            txbCorreo.MaxLength = 100;
            txbTelefono.MaxLength = 10;
            nIma=Int32.Parse(conexion.obtenNumDeImagenes());
            arr = new Image[nIma];
            for (int i = 1; i <= nIma; i++) {
                using (var ms = new MemoryStream(conexion.obtenImagen(i)))
                {
                    arr[i-1]= Image.FromStream(ms);
                }
            }
            //pBImagenes.Image = arr[0];
            //pBImagenes.SizeMode = PictureBoxSizeMode.StretchImage;
            conImagen = 1;
            pictureBox2.Image=arr[0];

        }
       
        private void btnAgrCita_Click(object sender, EventArgs e)
        {
            if (!vacio())
            {
                string fechaCitaStr = FechaCita.Value.ToString("yyyy/MM/dd");
                int servicio = Int32.Parse(cboxServicio.Text.Substring(0, 2));
                conexion.registrarCita(tbxNombre.Text, txbCorreo.Text, txbTelefono.Text, fechaCitaStr + " " + cboxHora.Text, servicio);
                Close();
            }
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
        private bool vacio()
        {
            foreach (Control oControls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    MessageBox.Show("Favor de llenar todos los campos solicitados");
                    return true;
                }
            }
            return false;
        }

        private void Citas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           
                pBImagenes.Image = arr[conImagen++];
                pBImagenes.SizeMode = PictureBoxSizeMode.StretchImage;
                //Thread.Sleep(3000);
                //Application.DoEvents();
               // MessageBox.Show(i.ToString());
               
            if (conImagen == nIma)
                conImagen = 0;

                
            if (conImagen == 4)
                conImagen=0;
            
        }

        private void pBImagenes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cboxServicio_Click(object sender, EventArgs e)
        {
          
        }

        private void cboxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            pBImagenes.Image = arr[cboxServicio.SelectedIndex+1];
            pBImagenes.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
