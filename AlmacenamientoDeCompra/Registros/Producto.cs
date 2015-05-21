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
        Producto producto = new Producto();

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
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre No puede estar vacio");
            }
            else if (textBoxcosto.Text == "")
            {
                MessageBox.Show("El campo costo No puede estar vacio");
            }
            else if (textBoxPrecio.Text == "")
            {
                MessageBox.Show("El campo precio No puede estar vacio");
            }
            else if (comboBoxITB.Text == "")
            {
                MessageBox.Show("no seleciono su ITBIS");
            }

            else
            {

                producto.CostoProductos = Convert.ToDouble(textBoxcosto.Text);
                producto.PrecioProductos = Convert.ToDouble(textBoxPrecio.Text);
                producto.ITBIS = Convert.ToDouble(comboBoxITB.SelectedItem.ToString());


                int existencia = 0;
                int.TryParse(textBoxExistencia.Text, out existencia);
                producto.Existencia = existencia;


                int codigo = 0;
                int.TryParse(textBoxCodigo.Text, out codigo);

                producto.NombreProductos = textBoxNombre.Text;

                if (codigo == 0)
                {
                    if (producto.Insertar())
                    {
                        limpiar();
                        MessageBox.Show("Transacción exitosa");
                    }
                }
                else
                {
                    if (producto.Modificar(codigo))
                    {
                        limpiar();
                        MessageBox.Show("Modificado Exitosamente");
                    }
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto();
            //usamos esta funcion para identificar si el producto tiene compras
            if (DetallesCompras.ConsultarProducto(Convert.ToInt32(textBoxCodigo.Text)) == true)
                MessageBox.Show("El Producto Contiene una Compra no se puede Eliminar");
            else if (producto.Eliminar(Convert.ToInt32(textBoxCodigo.Text)))
            {
                limpiar();
                MessageBox.Show("Transacción exitosa");
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(textBoxCodigo.Text, out codigo);

            if (producto.Buscar(codigo))
            {
                textBoxcosto.Text = producto.CostoProductos.ToString();
                textBoxExistencia.Text = producto.Existencia.ToString();
                textBoxNombre.Text = producto.NombreProductos;
                textBoxPrecio.Text = producto.PrecioProductos.ToString();
                comboBoxITB.SelectedValue = producto.ITBIS.ToString();
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



        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("solo puede digitar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("solo permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void textBoxcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("solo puede digitar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("solo puede digitar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }



    }
}
