using AlmacenamientoDeCompra.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlmacenamientoDeCompra.Consultas
{
    public partial class ConsultaProducto : Form
    {
        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void buttonconsulta_Click(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text != "")
            {
                dataGridViewConsulta.DataSource = BLL.Producto.Lista("*", comboBoxBuscarPor.Text + " like '" + textBoxBusqueda.Text + "%'");
            }
            else
            {
                dataGridViewConsulta.DataSource = BLL.Producto.Lista("*", "NombreProductos !=  ''");
            }

            double Total = 0;
            double sumaTotal = 0;

            DataTable dt = BLL.Producto.Lista("Count(CostoProductos) as CantidadProductos, Sum(CostoProductos) as ValorInvertido", "CostoProductos > 0");

            for (int x = 0; x <= dt.Rows.Count - 1; x++)
            {
                int numero = 0;
                int.TryParse(dt.Rows[x]["CantidadProductos"].ToString(), out numero);
                Total += numero;

                int numero2 = 0;
                int.TryParse(dt.Rows[x]["ValorInvertido"].ToString(), out numero2);
                sumaTotal += numero2;
            }

            textBoxTOTALSuma.Text = sumaTotal.ToString();
            textBoxTOTALProducto.Text = Total.ToString();
            
        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosReporte rpt = new ProductosReporte();
            rpt.WindowState = FormWindowState.Maximized;
            rpt.Show();
        }

        private void textBoxTOTALProducto_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
