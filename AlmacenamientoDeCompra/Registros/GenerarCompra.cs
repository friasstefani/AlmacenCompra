
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
namespace AlmacenamientoDeCompra.Registros
{
    public partial class GenerarCompra : Form
    {
        BLL.Compras compra = new BLL.Compras();
        public GenerarCompra()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Text = null;
            dateTimePickerFecha.Text = null;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            compra.CodigoCompra = 0;
            compra.CodigoSuplidor = Convert.ToInt32(comboBoxSuplidor.SelectedValue);
            compra.Fecha = Convert.ToDateTime(dateTimePickerFecha.Text);
            compra.TotalCompras = 0;

            if (compra.Insertar())
            {
                MessageBox.Show("Guardado");
                /*Compras ventana = new Compras();
                ventana.ShowDialog();*/
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Operación exitosa");
                }
            }
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
            }
            else
            {
                MessageBox.Show("Compra no encontrada");
            }
        }

        private void GenerarCompra_Load_1(object sender, EventArgs e)
        {
            comboBoxSuplidor.DataSource = BLL.Suplidor.Lista("CodigoSuplidor,Nombre", "Nombre !=  ''");
            comboBoxSuplidor.DisplayMember = "Nombre";
            comboBoxSuplidor.ValueMember = "CodigoSuplidor";
        }
        
    }
}
