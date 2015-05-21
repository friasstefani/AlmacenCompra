namespace AlmacenamientoDeCompra.Consultas
{
    partial class consultaCompra
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
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.buttonImprimirCompra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTOTALSuma = new System.Windows.Forms.TextBox();
            this.textBoxTOTALCompras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(304, 16);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxBusqueda.MaxLength = 20;
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(104, 22);
            this.textBoxBusqueda.TabIndex = 16;
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonconsultar.Location = new System.Drawing.Point(420, 16);
            this.buttonconsultar.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(112, 26);
            this.buttonconsultar.TabIndex = 15;
            this.buttonconsultar.Text = "Consultar";
            this.buttonconsultar.UseVisualStyleBackColor = true;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar por:";
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "CodigoCompra"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(158, 16);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(134, 22);
            this.comboBoxBuscarPor.TabIndex = 13;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(19, 61);
            this.dataGridViewConsulta.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(610, 276);
            this.dataGridViewConsulta.TabIndex = 12;
            // 
            // buttonImprimirCompra
            // 
            this.buttonImprimirCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImprimirCompra.Location = new System.Drawing.Point(30, 358);
            this.buttonImprimirCompra.Name = "buttonImprimirCompra";
            this.buttonImprimirCompra.Size = new System.Drawing.Size(96, 33);
            this.buttonImprimirCompra.TabIndex = 17;
            this.buttonImprimirCompra.Text = "Imprimir";
            this.buttonImprimirCompra.UseVisualStyleBackColor = true;
            this.buttonImprimirCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBoxTOTALSuma);
            this.panel1.Controls.Add(this.textBoxTOTALCompras);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(180, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 55);
            this.panel1.TabIndex = 18;
            // 
            // textBoxTOTALSuma
            // 
            this.textBoxTOTALSuma.Enabled = false;
            this.textBoxTOTALSuma.Location = new System.Drawing.Point(344, 24);
            this.textBoxTOTALSuma.Name = "textBoxTOTALSuma";
            this.textBoxTOTALSuma.Size = new System.Drawing.Size(100, 22);
            this.textBoxTOTALSuma.TabIndex = 25;
            // 
            // textBoxTOTALCompras
            // 
            this.textBoxTOTALCompras.Enabled = false;
            this.textBoxTOTALCompras.Location = new System.Drawing.Point(119, 24);
            this.textBoxTOTALCompras.MaxLength = 20;
            this.textBoxTOTALCompras.Name = "textBoxTOTALCompras";
            this.textBoxTOTALCompras.Size = new System.Drawing.Size(100, 22);
            this.textBoxTOTALCompras.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Suma Total :";
            // 
            // consultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(645, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonImprimirCompra);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(661, 437);
            this.Name = "consultaCompra";
            this.Text = "consulta de Compra";
            this.Load += new System.EventHandler(this.ConsultaSuplidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonconsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Button buttonImprimirCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTOTALSuma;
        private System.Windows.Forms.TextBox textBoxTOTALCompras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}