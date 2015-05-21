using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AlmacenamientoDeCompra
{
    public partial class RegistroProducto : Form
    {
        public RegistroProducto()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBoxCodigo.Text = null;
            textBoxcosto.Text = null;
            textBoxExistencia.Text = null;
            textBoxNombre.Text = null;
            textBoxPrecio.Text = null;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.CodigoProducto = 0;
            producto.CostoProductos = Convert.ToDouble(textBoxcosto.Text);
            producto.PrecioProductos = Convert.ToDouble(textBoxPrecio.Text);

            int existencia = 0;
            int.TryParse(textBoxExistencia.Text,out existencia);
            producto.Existencia = existencia;

            producto.NombreProductos = textBoxNombre.Text;

            if (producto.Insertar())
            {
                limpiar();
                MessageBox.Show("Transacción exitosa");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            if (producto.Eliminar(Convert.ToInt32(textBoxCodigo.Text)))
            {
                limpiar();
                MessageBox.Show("Transacción exitosa");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            int codigo = 0;
            int.TryParse(textBoxCodigo.Text, out codigo);

            if(producto.Buscar(codigo))
            {
                textBoxcosto.Text = producto.CostoProductos.ToString();
                textBoxExistencia.Text = producto.Existencia.ToString();
                textBoxNombre.Text = producto.NombreProductos;
                textBoxPrecio.Text = producto.PrecioProductos.ToString();
            }
            else
            {
                limpiar();
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void RegistroProducto_Load(object sender, EventArgs e)
        {

        }

    }
}
