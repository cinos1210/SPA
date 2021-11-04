using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SPA
{
    public partial class Productos : Form
    {
        
        
        
        public void obtenerProductos()
        {
            NpgsqlConnection connPro = new NpgsqlConnection("Server = 143.198.59.91; User Id = admin; Password = SistemaSpa2021B; Database= spa");
            connPro.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = connPro;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from productos";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvProductos.DataSource = dt;
            }
            comm.Dispose();
            connPro.Close();


        }



    }
}
