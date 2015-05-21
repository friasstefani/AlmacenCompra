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
            maskedTextBoxCelular.Text = null;
            textBoxCodigoSuplidor.Text = null;
            textBoxDirecion.Text = null;
            textBoxEmail.Text = null;
            textBoxNombre.Text = null;
            maskedTextBoxTelefono.Text = null;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre No puede estar vacio");
            }
            else if (maskedTextBoxTelefono.MaskCompleted == false)
            {
                MessageBox.Show("El campo telefono No puedo estar vacio ni medio lleno");
            }
            else if (maskedTextBoxCelular.MaskCompleted == false)
            {
                MessageBox.Show("El campo celular No puedo estar vacio ni medio lleno");
            }
            else if (textBoxDirecion.Text == "")
            {
                MessageBox.Show("El campo Direcion No puede estar vacio");
            }
            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("El Email No puede estar vacio");
            }
            else
            {


                suplidor.Celular = maskedTextBoxCelular.Text;
                suplidor.Direcion = textBoxDirecion.Text;
                suplidor.Nombre = textBoxNombre.Text;
                suplidor.Telefono = maskedTextBoxTelefono.Text;
                suplidor.Email = textBoxEmail.Text;

                if (suplidor.CodigoSuplidor == 0)
                {
                    if (suplidor.Insertar())
                    {
                        limpiar();
                        MessageBox.Show("Transacción exitosa");
                    }
                }
                else
                {
                    if (suplidor.Modificar(suplidor.CodigoSuplidor))
                    {
                        limpiar();
                        MessageBox.Show("Modificado Exitosamente");
                    }

                }

            }

        }
        
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(textBoxCodigoSuplidor.Text, out codigo);

            //esta funcion busca las compras que tenga ese suplidor 
            if (DetallesCompras.ConsultarSuplidor(Convert.ToInt32(textBoxCodigoSuplidor.Text)) == true)
            {
                MessageBox.Show("El Suplidor Contiene una Compra no se puede Eliminar");
            }
            else if (codigo != 0)
            {
                if (suplidor.Eliminar(codigo))
                {
                    limpiar();
                    MessageBox.Show("Transacción exitosa");
                }
            }
            else
            {
                MessageBox.Show("No tiene nada que eliminar, intente nuevamente");

            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            int.TryParse(textBoxCodigoSuplidor.Text, out codigo);

            if (suplidor.Buscar(codigo))
            {
                textBoxCodigoSuplidor.Text = suplidor.CodigoSuplidor.ToString();
                maskedTextBoxCelular.Text = suplidor.Celular;
                textBoxDirecion.Text = suplidor.Direcion;
                textBoxNombre.Text = suplidor.Nombre;
                maskedTextBoxTelefono.Text = suplidor.Telefono;
                textBoxEmail.Text = suplidor.Email;
            }
            else
            {
                limpiar();
                MessageBox.Show("Suplidor no encontrado.");
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

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

        private void maskedTextBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar !=(char)Keys.Back)){
          MessageBox.Show("solo puede digitar numeros","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
           
                e.Handled = true;
                return;
            }


        }

        private void maskedTextBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("solo puede digitar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }

        }

        private void textBoxCodigoSuplidor_KeyPress(object sender, KeyPressEventArgs e)
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