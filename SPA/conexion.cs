using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace SPA
{
    class conexion
    {

        NpgsqlConnection con = new NpgsqlConnection("Server = 143.198.59.91; User Id= admin; Password = SistemaSpa2021B Database= spa");
        public void conectar()
        {
            con.Open();
            MessageBox.Show("Conectado");
        }
        public void registrarCita(string nombre,string correo, string Ntelefono, string FeYHrCita)
        {

            // string sent = "INSERT INTO Citas(nombre, idCompras, correo, Ntelefono, FeYHrCita) VALUES('" + tbxNombre.Text + "','");
            DateTime localDate = DateTime.Now;
            MessageBox.Show(localDate.ToString());
            NpgsqlCommand insert = new NpgsqlCommand("INSET INTO Compras (total) VALUES (0);", con);
            con.Open();
            insert.ExecuteNonQuery();
            insert = new NpgsqlCommand(sent,  con);
            insert.ExecuteNonQuery();
            MessageBox.Show("Cita creada");
        }

    }
}
