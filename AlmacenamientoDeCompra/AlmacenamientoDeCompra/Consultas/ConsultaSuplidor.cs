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
    public partial class ConsultaSuplidor : Form
    {
        public ConsultaSuplidor()
        {
            InitializeComponent();
        }

        private void buttonconsultar_Click(object sender, EventArgs e)
        {
            if (textBoxBusqueda.Text != "")
            {
                dataGridViewConsulta.DataSource = BLL.Suplidor.Lista("*", comboBoxBuscarPor.Text + " = '" + textBoxBusqueda.Text + "'");
            }
            else
            {
                dataGridViewConsulta.DataSource = BLL.Suplidor.Lista("*", "Nombre != ''");
            }
        }

        private void ConsultaSuplidor_Load(object sender, EventArgs e)
        {
            dataGridViewConsulta.DataSource = BLL.Suplidor.Lista("*", "Nombre != ''");
        }
    }
}
