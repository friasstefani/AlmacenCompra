using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebHome
{
    public partial class RegistroProducto : System.Web.UI.Page
    {
        Producto producto = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {

            producto.CostoProductos = Convert.ToDouble(TextBoxcosto.Text);
            producto.PrecioProductos = Convert.ToDouble(TextBoxprecio.Text);
            producto.ITBIS = Convert.ToDouble(DropDownListitb.SelectedValue.ToString());


            int existencia = 0;
            int.TryParse(TextBoxeixtencia.Text, out existencia);
            producto.Existencia = existencia;


            int codigo = 0;
            int.TryParse(TextBoxCodigo.Text, out codigo);

            producto.NombreProductos = TextBoxnombre.Text;

            if (codigo == 0)
            {
                if (producto.Insertar())
                {
                    Labelmensaje.Text = "Transacción exitosa";
                }
            }
        }
    }
}