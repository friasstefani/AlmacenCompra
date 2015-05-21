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

namespace AlmacenamientoDeCompra.Registros
{
    public partial class CompraCompleta : Form
    {
        BLL.Compras compra = new BLL.Compras();

        public CompraCompleta()
        {
            InitializeComponent();
        }


        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Text = null;
            dateTimePickerFecha.Text = null;
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            int codigo = 0;
            int.TryParse(textBoxCodigo.Text, out codigo);

            if (compra.Buscar(codigo))
            {
                dateTimePickerFecha.Text = compra.Fecha.ToString();
                textBoxCodigo.Text = compra.CodigoCompra.ToString();
                comboBoxSuplidor.SelectedValue = compra.CodigoSuplidor.ToString();
                buttonEliminar.Enabled = true;
                textBoxCantidad.Enabled = true;
                comboBoxProducto.Enabled = true;
                ConsultadataGridView.DataSource = BLL.DetallesCompras.Lista("*", "CodigoCompra =" + codigo);
                textBoxTotalCompra.Text = BLL.Compras.BuscarTotalCompra(textBoxCodigo.Text).ToString();
            }
            else
            {
                MessageBox.Show("Compra no encontrada");
            }
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            try
            {
                BLL.Producto producto = new BLL.Producto();
                producto.Buscar(Convert.ToInt32(comboBoxProducto.SelectedValue));

                textBoxPrecio.Text = producto.PrecioProductos.ToString();
                textBoxPrecio.Enabled = false;
            }
            catch (Exception ex)
            {

            }
           
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                MessageBox.Show("No contiene una Cantida");
            }
            else
            {

                compra.CodigoSuplidor = Convert.ToInt32(comboBoxSuplidor.SelectedValue);
                compra.Fecha = Convert.ToDateTime(dateTimePickerFecha.Text);
                compra.TotalCompras = 0;

                if (textBoxCodigo.Text.Length == 0)
                {
                    if (compra.Insertar())
                    {
                        //asignamos al textbox codigo el codigo de la compra que se inserto. 
                        textBoxCodigo.Text = BLL.Compras.getUltimoIdInsertado().ToString();
                    }
                }

                BLL.DetallesCompras detalle = new BLL.DetallesCompras();
                detalle.CantidadProductos = Convert.ToInt32(textBoxCantidad.Text);
                detalle.CodigoCompra = Convert.ToInt32(textBoxCodigo.Text);
                detalle.CodigoProducto = Convert.ToInt32(comboBoxProducto.SelectedValue);

               //inserta en el detalle de la compra con los datos de arriba
                if (detalle.Insertar())
                {
                    //si inserto hacemos que el grid se llene con los datos de esa compra
                    ConsultadataGridView.DataSource = BLL.DetallesCompras.Lista("*", "CodigoCompra =" + textBoxCodigo.Text);
                    textBoxTotalCompra.Text = (BLL.Compras.BuscarTotalCompra(textBoxCodigo.Text) + Convert.ToDouble(textBoxITBIS.Text)).ToString();
                    
                    //se aumenta  la existencia del producto
                    Producto.AumentarExistenciaProducto(detalle.CodigoProducto.ToString(), detalle.CantidadProductos);
                }
                else
                {
                    MessageBox.Show("Error al insertar, intente nuevamente!");
                }
            }
        }
        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
          
            BLL.Producto producto = new BLL.Producto();
            producto.Buscar(Convert.ToInt32(comboBoxProducto.SelectedValue));

            int cantidad = 0;
            int.TryParse(textBoxCantidad.Text, out cantidad);

       
            double itbis = (producto.ITBIS / 100);
            double subtotal = (cantidad * producto.PrecioProductos) + itbis;
            double total = subtotal;

            textBoxSubTotal.Text = (subtotal).ToString();
            textBoxITBIS.Text = (itbis).ToString();
        }

        private void CompraCompleta_Load(object sender, EventArgs e)
        {
            comboBoxProducto.DataSource = BLL.Producto.Lista("CodigoProducto,NombreProductos", "NombreProductos != ''");
            comboBoxProducto.ValueMember = "CodigoProducto";
            comboBoxProducto.DisplayMember = "NombreProductos";

            comboBoxSuplidor.DataSource = BLL.Suplidor.Lista("CodigoSuplidor,Nombre", "Nombre != ''");
            comboBoxSuplidor.ValueMember = "CodigoSuplidor";
            comboBoxSuplidor.DisplayMember = "Nombre";
        }



        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
           
                int codigo = 0;
                int.TryParse(textBoxCodigo.Text, out codigo);

                DetallesCompras detalle = new DetallesCompras();
                if (textBoxCodigo.Text == "")
                {
                    MessageBox.Show("No tiene nada que eliminar");

                }
            else{
            
                if (detalle.Eliminar(codigo))
                {
                    if (compra.Eliminar(codigo))
                    {
                        textBoxCodigo.Text = null;
                        dateTimePickerFecha.Text = null;
                        ConsultadataGridView.DataSource = null;
                        textBoxTotalCompra.Text = null;
                        MessageBox.Show("Operación exitosa");

                    }
                }
           
        }
        }
        

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(textBoxCodigo.Text, out codigo);

            DetallesCompras detalle = new DetallesCompras();
            if (detalle.Eliminar(codigo))
            {
                if (compra.Eliminar(codigo))
                {
                    textBoxCodigo.Text = null;
                    dateTimePickerFecha.Text = null;
                    ConsultadataGridView.DataSource = null;
                    textBoxTotalCompra.Text = null;
                    MessageBox.Show("Operación exitosa");
                    this.Close();
                }
            }
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

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
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





