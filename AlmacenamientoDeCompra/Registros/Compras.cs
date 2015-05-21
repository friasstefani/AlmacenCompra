using AlmacenamientoDeCompra.Registros;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenamientoDeCompra
{
    public partial class Compras : Form
    {
        BLL.Compras compra = new BLL.Compras();
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'sABADataSet2.Suplidores' table. You can move, or remove it, as needed.
            this.suplidoresTableAdapter.Fill(this.sABADataSet2.Suplidores);
            // TODO: This line of code loads data into the 'sABADataSet1.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.sABADataSet1.Productos);

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
            textBoxCantidad.Enabled = true;
            comboBoxProducto.Enabled = true;

            int codigo = 0;
            int.TryParse(textBoxCompra.Text, out codigo);

            if (compra.Buscar(codigo))
            {
                ConsultadataGridView.DataSource = BLL.DetallesCompras.Lista("*", "CodigoCompra =" + codigo);
                
                dateTimePickerFecha.Text = compra.Fecha.ToString();
                textBoxCompra.Text = compra.CodigoCompra.ToString();
                comboBoxSuplidor.SelectedValue = compra.CodigoSuplidor.ToString();


                textBoxTotalCompra.Text = BLL.Compras.BuscarTotalCompra(textBoxCompra.Text).ToString();
            }
            else
            {
                MessageBox.Show("Compra no encontrada");
            }
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            BLL.Producto producto = new BLL.Producto();
            producto.Buscar(Convert.ToInt32(comboBoxProducto.SelectedValue));

            int cantidad = 0;
            int.TryParse(textBoxCantidad.Text,out cantidad);

            textBoxSubTotal.Text = (cantidad * producto.PrecioProductos).ToString();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            BLL.DetallesCompras compra = new BLL.DetallesCompras();
            compra.CantidadProductos = Convert.ToInt32(textBoxCantidad.Text);
            compra.CodigoCompra = Convert.ToInt32(textBoxCompra.Text);
            compra.CodigoProducto = Convert.ToInt32(comboBoxProducto.SelectedValue);

            if (compra.Insertar())
            {
                ConsultadataGridView.DataSource = BLL.DetallesCompras.Lista("*", "CodigoCompra =" + textBoxCompra.Text);
                textBoxTotalCompra.Text = BLL.Compras.BuscarTotalCompra(textBoxCompra.Text).ToString();
                Producto.AumentarExistenciaProducto(compra.CodigoProducto.ToString(), compra.CantidadProductos);
            }
            else
            {
                MessageBox.Show("Error al insertar, intente nuevamente!");
            }



        }
        
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(textBoxCompra.Text, out codigo);

            DetallesCompras detalle = new DetallesCompras();
            if (detalle.Eliminar(codigo))
            {
                if (compra.Eliminar(codigo))
                {
                    textBoxCompra.Text = null;
                    dateTimePickerFecha.Text = null;
                    ConsultadataGridView.DataSource = null;
                    textBoxTotalCompra.Text = null;
                    MessageBox.Show("Operación exitosa");
                }
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            GenerarCompra compra = new GenerarCompra();
            compra.ShowDialog();
        }

        private void comboBoxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            BLL.Producto producto = new BLL.Producto();
            producto.Buscar(Convert.ToInt32(comboBoxProducto.SelectedValue));

            textBoxPrecio.Text = producto.PrecioProductos.ToString();
            textBoxPrecio.Enabled = false;
        }

    }
}
