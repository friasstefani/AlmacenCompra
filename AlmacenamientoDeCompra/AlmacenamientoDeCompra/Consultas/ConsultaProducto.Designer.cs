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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(36, 85);
            this.dataGridViewConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.Size = new System.Drawing.Size(577, 238);
            this.dataGridViewConsulta.TabIndex = 0;
            // 
            // comboBoxBuscarPor
            // 
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
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(206, 22);
            this.textBoxBusqueda.TabIndex = 6;
            // 
            // ConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 371);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
    }
}