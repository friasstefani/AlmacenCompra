namespace AlmacenamientoDeCompra.Consultas
{
    partial class ConsultaSuplidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSuplidor));
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(310, 29);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(208, 22);
            this.textBoxBusqueda.TabIndex = 11;
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonconsultar.Location = new System.Drawing.Point(525, 27);
            this.buttonconsultar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(165, 24);
            this.buttonconsultar.TabIndex = 10;
            this.buttonconsultar.Text = "Consultar";
            this.buttonconsultar.UseVisualStyleBackColor = true;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar por:";
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Nombre",
            "CodigoSuplidor"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(141, 29);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(156, 22);
            this.comboBoxBuscarPor.TabIndex = 8;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(31, 75);
            this.dataGridViewConsulta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.Size = new System.Drawing.Size(659, 256);
            this.dataGridViewConsulta.TabIndex = 7;
            // 
            // ConsultaSuplidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 353);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConsultaSuplidor";
            this.Text = "Consulta de Suplidor";
            this.Load += new System.EventHandler(this.ConsultaSuplidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonconsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;

    }
}