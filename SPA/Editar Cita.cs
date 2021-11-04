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

namespace SPA
{
    public partial class Editar_Cita : Form
    {
        Image logo;
        int indice;
        Boolean[] horarios;
        int[] indexHorarios = new int[5];
        DateTime parsedDate;
        int iterator;
        conexion conexion = new conexion();
        string fechaAnterior;
        int id;
        public Editar_Cita(int id)
        {
            InitializeComponent();
            cargaDatos(id);
            this.id = id;
        }
        private void cargaDatos(int id) {
            conexion conexion = new conexion();

            using (var ms = new MemoryStream(conexion.obtenImagen(1)))
            {
                logo = Image.FromStream(ms);
            }
            pictureBox2.Image = logo;
            conexion.conectar();
            lblNombre.Text = conexion.obtenDatos(" SELECT nombre FROM Citas WHERE idCita=" + id + ";", "nombre");
            lblCorreo.Text = conexion.obtenDatos(" SELECT correo FROM Citas WHERE idCita=" + id + ";", "correo");
            lblFecha.Text = conexion.obtenDatos(" SELECT feyhrelaboracion FROM Citas WHERE idCita=" + id + ";", "feyhrelaboracion");
            fechaAnterior = conexion.obtenDatos(" SELECT feyhrcita FROM Citas WHERE idCita=" + id + ";", "feyhrcita");
            parsedDate = DateTime.Parse(fechaAnterior);
            lblTelefono.Text = conexion.obtenDatos(" SELECT nTelefono FROM Citas WHERE idCita=" + id + ";", "nTelefono");
            indice = Int32.Parse(conexion.obtenDatos(" SELECT \"indexDiaCita\" FROM Citas WHERE idCita=" + id + ";", "indexDiaCita"));
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FechaCita_ValueChanged(object sender, EventArgs e)
        {
            //Al seleccionar un dia especifico en el dateTimePicker se busca en la base de datos 
            // para obtener loshorarios disponibles
            horarios = conexion.obtenHorarios(FechaCita.Text);
            cboxHora.Items.Clear();
            iterator = 0;
            int citasDiponibles = 0;
            if (horarios[0] == false)
            {
                cboxHora.Items.Add("10:00:00");
                indexHorarios[iterator++] = 0;
                citasDiponibles++;
            }
            if (horarios[1] == false)
            {
                cboxHora.Items.Add("12:00:00");
                indexHorarios[iterator++] = 1;
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
            if (citasDiponibles == 0)
                MessageBox.Show("Este dia ya no tiene horarios disponibles, por favor seleccione otro");
        }

        private void btonAcep_Click(object sender, EventArgs e)
        {
            string fechaCitaStr = FechaCita.Value.ToString("yyyy/MM/dd");
            string fecha= fechaCitaStr + " " + cboxHora.Text;
            if (!cboxHora.SelectedIndex.Equals(-1))
            {
                conexion.liberarHorario(indice, parsedDate.ToString("yyyy/MM/dd"));
                horarios[indice] = false;
                horarios[indexHorarios[cboxHora.SelectedIndex]] = true;
                conexion.actualizaCita(id,fecha, horarios, indexHorarios[cboxHora.SelectedIndex]);
                MessageBox.Show("Cita Actualizada");
                Close();
            }
            else
                MessageBox.Show("Seleccione un horario, por favor");
        }
    }
}
