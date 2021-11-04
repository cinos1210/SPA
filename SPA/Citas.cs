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
using System.Text.RegularExpressions;


namespace SPA
{
    public partial class Citas : Form
    {
        conexion conexion = new conexion();
        int nIma = 0;
        Image[] arr;
        Boolean[] horarios;
        //este arreglo ayuda a conocer la posicion en el arreglo de la base de datos, solucion a error al confudirlo con index de cbox
        int[] indexHorarios= new int[5];
        int iterator;

        public Citas()
        {
            
            InitializeComponent();
            //Verificacion limite de cada campo
            tbxNombre.MaxLength=100;
            txbCorreo.MaxLength = 100;
            txbTelefono.MaxLength = 10;
            FechaCita.MinDate = DateTime.Today;
  
            //Obtencion de imagenes de la base de datos
            nIma = Int32.Parse(conexion.obtenNumDeImagenes());
            arr = new Image[nIma];
            for (int i = 1; i <= nIma; i++) {
                using (var ms = new MemoryStream(conexion.obtenImagen(i)))
                {
                    arr[i-1]= Image.FromStream(ms);
                }
            }
            pictureBox2.Image=arr[0];
        }
       
        private void btnAgrCita_Click(object sender, EventArgs e)
        {

                if (!cboxServicio.SelectedIndex.Equals(-1))
                {
                    if (!cboxHora.SelectedIndex.Equals(-1))
                    {
                        if (!vacio())
                        {
                            if ((new Regex(@"^[0-9]+$")).IsMatch(txbTelefono.Text)&& txbTelefono.Text.Length==10)
                            {
                                if ((new Regex(@"^[A-Z a-z]+$")).IsMatch(tbxNombre.Text)&& tbxNombre.Text.Length>12)
                                {
                                    if (new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$").IsMatch(txbCorreo.Text))
                                    {
                                        string fechaCitaStr = FechaCita.Value.ToString("yyyy/MM/dd");
                                        int servicio = Int32.Parse(cboxServicio.Text.Substring(0, 2));
                                        horarios[indexHorarios[cboxHora.SelectedIndex]] = true;
                                        conexion.registrarCita(tbxNombre.Text, txbCorreo.Text, txbTelefono.Text, fechaCitaStr + " " + cboxHora.Text, servicio, FechaCita.Text, horarios, indexHorarios[cboxHora.SelectedIndex]);
                                        Close();
                                    }else
                                        MessageBox.Show("Ingresa un correo valido, por favor");
                                }else
                                    MessageBox.Show("Ingrese un nombre valido, por favor");
                            }else
                                MessageBox.Show("Ingrese un numero valido, por favor");
                        }
                    }
                    else
                        MessageBox.Show("Seleccione un horario, por favor");
                }
                else
                    MessageBox.Show("Seleccione un servicio, por favor");
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
            //Al seleccionar un dia especifico en el dateTimePicker se busca en la base de datos 
            // para obtener loshorarios disponibles
            horarios = conexion.obtenHorarios(FechaCita.Text);
            cboxHora.Items.Clear();
            iterator = 0;
            int citasDiponibles=0;
            if (horarios[0] == false) {
                cboxHora.Items.Add("10:00:00");
                indexHorarios[iterator++] = 0;
                citasDiponibles++;
            }
            if (horarios[1] == false)
            {
                cboxHora.Items.Add("12:00:00");
                indexHorarios[iterator++] =1;
                citasDiponibles++;
            }
            if (horarios[2] == false)
            {
                cboxHora.Items.Add("14:00:00");
                indexHorarios[iterator++] = 2;
                citasDiponibles++;
            }
            if (horarios[3] == false)
            {
                cboxHora.Items.Add("16:00:00");
                indexHorarios[iterator++] = 3;
                citasDiponibles++;
            }
            if (horarios[4] == false)
            {
                cboxHora.Items.Add("18:00:00");
                indexHorarios[iterator++] = 4;
                citasDiponibles++;
            }
            if(citasDiponibles==0)
                MessageBox.Show("Este dia ya no tiene horarios disponibles, por favor seleccione otro");
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

        private void cboxHora_ValueMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
