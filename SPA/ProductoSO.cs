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
    public partial class ProductoSO : Form
    {
        Image[] products;
        DataTable data;
        int cant = 0;
        float precio = 0;
        int[] productos;
        float[] precios;
        public ProductoSO()
        {

            InitializeComponent();
            conexion conexion = new conexion();
            data = conexion.obtenerProductos();

            using (var ms = new MemoryStream(conexion.obtenImagen(1)))
            {
                pbLogo.Image = Image.FromStream(ms);
            }
            //Carga de imagenes de productos
            products = new Image[data.Rows.Count];
            productos = new int[data.Rows.Count];
            precios = new float[data.Rows.Count];
            for (int i = 0; i < data.Rows.Count; i++)
            {
                using (var ms = new MemoryStream((byte[])(data.Rows[i]["image"])))
                {
                    products[i] = Image.FromStream(ms);
                }
                CbProductos.Items.Add(data.Rows[i]["nombre"]);
                productos[i] = 0;
                precios[i] = float.Parse(data.Rows[i]["precio_cliente"].ToString());
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbProduc.Image = products[CbProductos.SelectedIndex];
            pbProduc.SizeMode = PictureBoxSizeMode.StretchImage;
            lblMarca.Text = data.Rows[CbProductos.SelectedIndex]["marca"].ToString();
            lblDescripcion.Text = data.Rows[CbProductos.SelectedIndex]["descripcion"].ToString();
            lblPrecio.Text = data.Rows[CbProductos.SelectedIndex]["precio_cliente"].ToString();
            lblTipo.Text = data.Rows[CbProductos.SelectedIndex]["tipo"].ToString();
            precio = float.Parse(lblPrecio.Text);
            lblCantidad0.Text = productos[CbProductos.SelectedIndex].ToString();
            lblCosto.Text = (float.Parse(lblCantidad0.Text) * precio).ToString();
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductoSO_Load(object sender, EventArgs e)
        {

        }

        private void btnMas_Click(object sender, EventArgs e)
        { 
            if(CbProductos.SelectedIndex!=-1){
                lblCantidad0.Text =(Int32.Parse(lblCantidad0.Text) + 1).ToString();
                lblCosto.Text = (float.Parse(lblCantidad0.Text) * precio).ToString();
                lbltotal.Text = (float.Parse(lbltotal.Text) + precio).ToString();
                productos[CbProductos.SelectedIndex]++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CbProductos.SelectedIndex != -1)
            {
                if (Int32.Parse(lblCantidad0.Text) > 0)
                {
                    lblCantidad0.Text = (Int32.Parse(lblCantidad0.Text) - 1).ToString();
                    lblCosto.Text = (float.Parse(lblCantidad0.Text) * precio).ToString();
                    lbltotal.Text = (float.Parse(lbltotal.Text) - precio).ToString();
                    productos[CbProductos.SelectedIndex]--;
                }
            }
        }

        private void btonAceptar_Click(object sender, EventArgs e)
        {   if (CbProductos.SelectedIndex != -1)
            {
                conexion conexion = new conexion();
                conexion.Compra(productos, float.Parse(lbltotal.Text), precios);
                MessageBox.Show("Compra realizada");
                Close();
            }
        }
    }
}
