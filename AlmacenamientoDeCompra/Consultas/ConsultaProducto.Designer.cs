namespace AlmacenamientoDeCompra.Consultas
{
    partial class ConsultaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonimprimirProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTOTALProducto = new System.Windows.Forms.TextBox();
            this.textBoxTOTALSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(36, 85);
            this.dataGridViewConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(620, 238);
            this.dataGridViewConsulta.TabIndex = 0;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "NombreProductos",
            "CodigoProducto"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(146, 42);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(122, 22);
            this.comboBoxBuscarPor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por:";
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Location = new System.Drawing.Point(489, 42);
            this.buttonconsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(124, 22);
            this.buttonconsultar.TabIndex = 5;
            this.buttonconsultar.Text = "Consultar";
            this.buttonconsultar.UseVisualStyleBackColor = true;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsulta_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(275, 42);
            this.textBoxBusqueda.MaxLength = 45;
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(206, 22);
            this.textBoxBusqueda.TabIndex = 6;
            // 
            // buttonimprimirProducto
            // 
            this.buttonimprimirProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonimprimirProducto.Location = new System.Drawing.Point(43, 348);
            this.buttonimprimirProducto.Name = "buttonimprimirProducto";
            this.buttonimprimirProducto.Size = new System.Drawing.Size(96, 33);
            this.buttonimprimirProducto.TabIndex = 22;
            this.buttonimprimirProducto.Text = "Imprimir";
            this.buttonimprimirProducto.UseVisualStyleBackColor = true;
            this.buttonimprimirProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Invertidos en Producto:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total Producto";
            // 
            // textBoxTOTALProducto
            // 
            this.textBoxTOTALProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTOTALProducto.Enabled = false;
            this.textBoxTOTALProducto.Location = new System.Drawing.Point(275, 353);
            this.textBoxTOTALProducto.Name = "textBoxTOTALProducto";
            this.textBoxTOTALProducto.Size = new System.Drawing.Size(100, 22);
            this.textBoxTOTALProducto.TabIndex = 25;
            this.textBoxTOTALProducto.TextChanged += new System.EventHandler(this.textBoxTOTALProducto_TextChanged);
            // 
            // textBoxTOTALSuma
            // 
            this.textBoxTOTALSuma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTOTALSuma.Enabled = false;
            this.textBoxTOTALSuma.Location = new System.Drawing.Point(559, 353);
            this.textBoxTOTALSuma.Name = "textBoxTOTALSuma";
            this.textBoxTOTALSuma.Size = new System.Drawing.Size(97, 22);
            this.textBoxTOTALSuma.TabIndex = 26;
            // 
            // ConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 398);
            this.Controls.Add(this.textBoxTOTALSuma);
            this.Controls.Add(this.textBoxTOTALProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonimprimirProducto);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(661, 437);
            this.Name = "ConsultaProducto";
            this.Text = "ConsultaProducto";
            this.Load += new System.EventHandler(this.ConsultaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonconsultar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonimprimirProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTOTALProducto;
        private System.Windows.Forms.TextBox textBoxTOTALSuma;
    }
}