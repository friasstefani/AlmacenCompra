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
    public partial class consultaCompra : Form
    {
        public consultaCompra()
        {
            InitializeComponent();
        }

        private void buttonconsultar_Click(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text != "")
            {
                
                dataGridViewConsulta.DataSource = BLL.Compras.Lista("*", comboBoxBuscarPor.Text + " = '" + textBoxBusqueda.Text + "'");
            }
            else
            {
             
                dataGridViewConsulta.DataSource = BLL.Compras.Lista("*", "CodigoCompra != ''");
            }

            double Total = 0;
            double sumaTotal = 0;
           
            try
            {
                DataTable dt = BLL.Compras.Lista("Count(TotalCompra) as TotalCompra, Sum(TotalCompra) as SumaTotal", "TotalCompra != ''");
                Total = Convert.ToDouble(dt.Rows[0]["TotalCompra"]);
                sumaTotal = Convert.ToDouble(dt.Rows[0]["SumaTotal"]);
            }catch (Exception ex) {
                MessageBox.Show("No existen compras");
            }
           
            textBoxTOTALSuma.Text = sumaTotal.ToString();
            textBoxTOTALCompras.Text = Total.ToString();
            
        }

        private void ConsultaSuplidor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComprasReporte rpt = new ComprasReporte();
            rpt.WindowState = FormWindowState.Maximized;
            rpt.Show();
        }

    }
}
