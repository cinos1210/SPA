using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;
namespace SPA
{
    class conexion
    {

        NpgsqlConnection con = new NpgsqlConnection("Server = 143.198.59.91; User Id= admin; Password = SistemaSpa2021B; Database= spa");
        public void conectar()
        {
            con.Open();
        }
        public void liberarHorario(int indice,string fechaAnterior) {
            Boolean[] horarios = obtenHorarios(fechaAnterior);
            con.Open();
            horarios[indice] = false;
            NpgsqlCommand insert = new NpgsqlCommand("UPDATE public.\"DiaCita\" SET  horarios='{" + horarios[0] + "," + horarios[1] + "," + horarios[2] + "," + horarios[3] + "," + horarios[4] + "}' WHERE \"diaDeCita\" ='" + fechaAnterior + "';", con);
            insert.ExecuteNonQuery();
            con.Close();
           

        }
        public void actualizaCita(int id, string fecha, Boolean[] horarios, int indiHorario)
        {
            con.Open();
            NpgsqlCommand insert = new NpgsqlCommand(" UPDATE public.citas SET feyhrcita = '" + fecha + "', \"indexDiaCita\" = "+indiHorario+" WHERE idcita = " + id + ";", con);
            insert.ExecuteNonQuery();
            string updatehorarios = "UPDATE \"DiaCita\" SET horarios='{" + horarios[0] + "," + horarios[1] + "," + horarios[2] + "," + horarios[3] + "," + horarios[4] + "}' WHERE \"diaDeCita\"='" + fecha + "';";
            insert = new NpgsqlCommand(updatehorarios, con);
            insert.ExecuteNonQuery();
            con.Close();

        }
    public void registrarCita(string nombre,string correo, string Ntelefono, string FeYHrCita,int servicio,string fechaDeCita, Boolean[] horarios, int indiHorario)
        {
            conectar();
            
            DateTime localDate = DateTime.Now;
            string str = localDate.ToString("yyyy/MM/dd HH:mm:ss");
            NpgsqlCommand insert = new NpgsqlCommand("INSERT INTO Compras (FeyHr,total) VALUES ('"+str+"',0);", con);
            insert.ExecuteNonQuery();
            string idC = obtenId("SELECT max(idCompras) FROM Compras;");
  

            string sent = "INSERT INTO Citas(nombre, idCompras, correo, Ntelefono, FeYHrCita, FeYHrElaboracion, \"indexDiaCita\") VALUES ('" + nombre + "'," + idC + ",'" + correo + "','" + Ntelefono + "','" + FeYHrCita + "','" + str + "',"+indiHorario+");";
            insert = new NpgsqlCommand(sent,  con);
            insert.ExecuteNonQuery();


            string precioSer = obtenPrecioServicio("SELECT costo From Servicios WHERE idServicio="+servicio);
            string ser = "INSERT INTO ServiciosContratados(idCompras,idServicio,precio) Values ("+idC+","+servicio+","+precioSer+"); ";
            insert = new NpgsqlCommand(ser, con);
            insert.ExecuteNonQuery();


            string corrigePrecio = "UPDATE Compras SET total="+precioSer+" WHERE idCompras=" + idC;
            insert = new NpgsqlCommand(corrigePrecio, con);
            insert.ExecuteNonQuery();

            string updatehorarios = "UPDATE \"DiaCita\" SET horarios='{"+horarios[0]+"," + horarios[1] + "," + horarios[2] + "," + horarios[3] + "," + horarios[4] + "}' WHERE \"diaDeCita\"='" + fechaDeCita + "';";
            insert = new NpgsqlCommand(updatehorarios, con);
            insert.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Cita creada");

        }
        public void Compra(int[] productos, float total, float[] precios) {
            conectar();

            DateTime localDate = DateTime.Now;
            string str = localDate.ToString("yyyy/MM/dd HH:mm:ss");
            NpgsqlCommand insert = new NpgsqlCommand("INSERT INTO Compras (FeyHr,total) VALUES ('" + str + "'," + total + ");", con);
            insert.ExecuteNonQuery();
            string idC = obtenId("SELECT max(idCompras) FROM Compras;");
            for (int i = 0; i < productos.Length; i++) {
                if (productos[i] > 0)
                {
                    insert = new NpgsqlCommand("INSERT INTO public.productocomprado(idcompras, idproducto, cantidad, precio, preciototal)VALUES(" + idC + "," + (i + 1) + "," + productos[i] + "," + precios[i] + "," + (precios[i] * productos[i]) + ");", con);
                    insert.ExecuteNonQuery();
                }
            }
        }
        public string obtenId(string sent)
        {
            NpgsqlCommand com = new NpgsqlCommand(sent, con);
            NpgsqlDataAdapter dato = new NpgsqlDataAdapter(com);
            DataTable tabla = new DataTable();
            dato.Fill(tabla);
            return tabla.Rows[0]["max"].ToString();
        }
        public bool buscaId(int id)
        {
            con.Open();
            try
            {
                string sent = " SELECT * FROM Citas WHERE idCita=" + id + ";";
                NpgsqlCommand com = new NpgsqlCommand(sent, con);
                NpgsqlDataAdapter dato = new NpgsqlDataAdapter(com);
                con.Close();
                return true;
            }
            catch {
                return false;
            }
        }
        public string obtenPrecioServicio(string sent)
        {
            NpgsqlCommand com = new NpgsqlCommand(sent, con);
            NpgsqlDataAdapter dato = new NpgsqlDataAdapter(com);
            DataTable tabla = new DataTable();
            dato.Fill(tabla);
            return tabla.Rows[0]["costo"].ToString();
        }
        public string obtenDatos(string sent,string inf)
        {

            NpgsqlCommand com = new NpgsqlCommand(sent, con);
            NpgsqlDataAdapter dato = new NpgsqlDataAdapter(com);
            DataTable tabla = new DataTable();
            dato.Fill(tabla);
            return tabla.Rows[0][inf].ToString();
        }
        public string obtenNumDeImagenes()
        {
            string sent = "SELECT max(id) FROM imagenes;";
            con.Open();
            NpgsqlCommand com = new NpgsqlCommand(sent, con);
            NpgsqlDataAdapter dato = new NpgsqlDataAdapter(com);
            DataTable tabla = new DataTable();
            dato.Fill(tabla);
            con.Close();
            return tabla.Rows[0]["max"].ToString();
        }
        public Byte[] obtenImagen(int num)
        {
            string sent = "SELECT image FROM imagenes WHERE id=" + num + ";" ;
            con.Open();
            NpgsqlCommand com = new NpgsqlCommand(sent, con);
            NpgsqlDataAdapter dato = new NpgsqlDataAdapter(com);
            DataTable tabla = new DataTable();
            dato.Fill(tabla);
            con.Close();
            return (byte[])(tabla.Rows[0]["image"]);
        }
        public Boolean[] obtenHorarios(string date) {
            try
            {
                string sent = "SELECT horarios FROM \"DiaCita\" WHERE \"diaDeCita\"='" + date + "';";
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand(sent, con);
                NpgsqlDataAdapter dato = new NpgsqlDataAdapter(com);
                DataTable tabla = new DataTable();
                dato.Fill(tabla);
                con.Close();
                return (Boolean[])(tabla.Rows[0]["horarios"]);
            }
            catch {
                con.Open();
                NpgsqlCommand insert = new NpgsqlCommand("INSERT INTO public.\"DiaCita\" (\"diaDeCita\", horarios) VALUES  ('" + date + "', '{0,0,0,0,0}');", con);
                insert.ExecuteNonQuery();
                con.Close();
                Boolean[] arr = new Boolean[] { false,false,false,false,false};
                return arr;
            }
        }
        public DataTable obtenerProductos()
        {
            con.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = con;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from productos";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                comm.Dispose();
                con.Close();
                return dt;
            }
            else
                MessageBox.Show("No hay productos");

            return null;
        }
    }
}
