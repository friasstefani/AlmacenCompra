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
            page.ShowDialog();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suplidor page = new Suplidor();
            page.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras ventana = new Compras();
            ventana.ShowDialog();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProducto page =new ConsultaProducto ();
            page.ShowDialog();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaSuplidor page = new ConsultaSuplidor();
            page.ShowDialog();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultaCompra page = new consultaCompra();
            page.ShowDialog();
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GenerarCompra page = new GenerarCompra();
            page.ShowDialog();

        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda page = new ayuda();
            page.ShowDialog();
        }

        private void suplidoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SuplidorReporte rpt = new SuplidorReporte();
            rpt.WindowState = FormWindowState.Maximized;
            rpt.Show();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductosReporte rpt = new ProductosReporte();
            rpt.WindowState = FormWindowState.Maximized;
            rpt.Show();
        }

        private void comprasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ComprasReporte rpt = new ComprasReporte();
            rpt.WindowState = FormWindowState.Maximized;
            rpt.Show();
        }

        

    }
}
