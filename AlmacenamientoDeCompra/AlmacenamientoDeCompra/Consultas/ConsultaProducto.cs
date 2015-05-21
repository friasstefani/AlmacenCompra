﻿using System;
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
                dataGridViewConsulta.DataSource = BLL.Producto.Lista("*", comboBoxBuscarPor.Text + " = '" + textBoxBusqueda.Text + "'");
            }
            else
            {
                dataGridViewConsulta.DataSource = BLL.Producto.Lista("*", "NombreProductos != ''");
            }
        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {
            dataGridViewConsulta.DataSource = BLL.Producto.Lista("*", "NombreProductos != ''");
        }

    }
}
