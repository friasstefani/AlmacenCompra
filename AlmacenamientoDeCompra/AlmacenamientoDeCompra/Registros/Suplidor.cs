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
    public partial class Suplidor : Form
    {
        BLL.Suplidor suplidor = new BLL.Suplidor();

        public Suplidor()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBoxCelular.Text = null;
            textBoxCodigoSuplidor.Text = null;
            textBoxDirecion.Text = null;
            textBoxEmail.Text = null;
            textBoxNombre.Text = null;
            textBoxTelefono.Text = null;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            suplidor.Celular = textBoxCelular.Text;
            suplidor.Direcion = textBoxDirecion.Text;
            suplidor.Nombre = textBoxNombre.Text;
            suplidor.Telefono = textBoxTelefono.Text;
            suplidor.Email = textBoxEmail.Text;

            if (suplidor.Insertar())
            {
                limpiar();
                MessageBox.Show("Transacción exitosa");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(textBoxCodigoSuplidor.Text, out codigo);

            if (suplidor.Eliminar(codigo))
            {
                limpiar();
                MessageBox.Show("Transacción exitosa");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(textBoxCodigoSuplidor.Text, out codigo);

            if (suplidor.Buscar(codigo))
            {
                textBoxCodigoSuplidor.Text = suplidor.CodigoSuplidor.ToString();
                textBoxCelular.Text = suplidor.Celular;
                textBoxDirecion.Text = suplidor.Direcion;
                textBoxNombre.Text = suplidor.Nombre;
                textBoxTelefono.Text = suplidor.Telefono;
                textBoxEmail.Text = suplidor.Email;
            }
            else
            {
                limpiar();
                MessageBox.Show("Suplidor no encontrado.");
            }
        }

        
    }
}
