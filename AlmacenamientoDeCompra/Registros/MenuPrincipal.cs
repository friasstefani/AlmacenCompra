using AlmacenamientoDeCompra.Consultas;
using AlmacenamientoDeCompra.Registros;
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

namespace AlmacenamientoDeCompra
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto page = new RegistroProducto();
            page.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suplidor page = new Suplidor();
            page.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProducto page =new ConsultaProducto ();
            page.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaSuplidor page = new ConsultaSuplidor();
            page.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultaCompra page = new consultaCompra();
            page.Show();
        }
        
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda page = new ayuda();
            page.Show();
        }

       
        private void utilizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizacion u = new Utilizacion();
            u.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compraCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CompraCompleta page = new CompraCompleta();
            page.Show();
        }

        

    }
}
