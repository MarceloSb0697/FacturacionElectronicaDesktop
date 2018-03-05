namespace FacturacionElectronicaDesktop.Vista
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnBoleta = new System.Windows.Forms.Button();
            this.btnNotaCredito = new System.Windows.Forms.Button();
            this.btnNotaDebito = new System.Windows.Forms.Button();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgFacturacion = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblBoleta = new System.Windows.Forms.Label();
            this.lblTotalCredito = new System.Windows.Forms.Label();
            this.lblTotalDebito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgDetalleFacturacion = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFactura.Location = new System.Drawing.Point(12, 96);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(188, 39);
            this.btnFactura.TabIndex = 0;
            this.btnFactura.Text = "EMITIR FACTURA";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnBoleta
            // 
            this.btnBoleta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBoleta.Location = new System.Drawing.Point(12, 154);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.Size = new System.Drawing.Size(188, 39);
            this.btnBoleta.TabIndex = 1;
            this.btnBoleta.Text = "EMITIR BOLETA";
            this.btnBoleta.UseVisualStyleBackColor = false;
            this.btnBoleta.Click += new System.EventHandler(this.btnBoleta_Click);
            // 
            // btnNotaCredito
            // 
            this.btnNotaCredito.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNotaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaCredito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNotaCredito.Location = new System.Drawing.Point(12, 210);
            this.btnNotaCredito.Name = "btnNotaCredito";
            this.btnNotaCredito.Size = new System.Drawing.Size(188, 50);
            this.btnNotaCredito.TabIndex = 2;
            this.btnNotaCredito.Text = "EMITIR NOTA DE CREDITO";
            this.btnNotaCredito.UseVisualStyleBackColor = false;
            this.btnNotaCredito.Click += new System.EventHandler(this.btnNotaCredito_Click);
            // 
            // btnNotaDebito
            // 
            this.btnNotaDebito.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNotaDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaDebito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNotaDebito.Location = new System.Drawing.Point(12, 278);
            this.btnNotaDebito.Name = "btnNotaDebito";
            this.btnNotaDebito.Size = new System.Drawing.Size(188, 45);
            this.btnNotaDebito.TabIndex = 3;
            this.btnNotaDebito.Text = "EMITIR NOTA DE DEBITO";
            this.btnNotaDebito.UseVisualStyleBackColor = false;
            this.btnNotaDebito.Click += new System.EventHandler(this.btnNotaDebito_Click);
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(182, 54);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 20);
            this.dtDesde.TabIndex = 5;
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(488, 54);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 20);
            this.dtHasta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "HASTA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar.Location = new System.Drawing.Point(715, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 28);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgFacturacion
            // 
            this.dgFacturacion.AllowUserToAddRows = false;
            this.dgFacturacion.AllowUserToDeleteRows = false;
            this.dgFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturacion.Location = new System.Drawing.Point(221, 96);
            this.dgFacturacion.Name = "dgFacturacion";
            this.dgFacturacion.ReadOnly = true;
            this.dgFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFacturacion.Size = new System.Drawing.Size(977, 283);
            this.dgFacturacion.TabIndex = 9;
            this.dgFacturacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturacion_CellClick);
            this.dgFacturacion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFacturacion_CellFormatting);
            this.dgFacturacion.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgFacturacion_DataBindingComplete);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalir.Location = new System.Drawing.Point(12, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 39);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total de Facturas Electronicas en Nuevos Soles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total de Boletas Electronicas en Nuevos Soles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total de Notas de Creditos Electronicas en Nuevos Soles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total de Notas de Debito en Nuevos Soles";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(1146, 492);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(52, 18);
            this.lblFactura.TabIndex = 15;
            this.lblFactura.Text = "label1";
            // 
            // lblBoleta
            // 
            this.lblBoleta.AutoSize = true;
            this.lblBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoleta.Location = new System.Drawing.Point(1146, 523);
            this.lblBoleta.Name = "lblBoleta";
            this.lblBoleta.Size = new System.Drawing.Size(52, 18);
            this.lblBoleta.TabIndex = 16;
            this.lblBoleta.Text = "label2";
            // 
            // lblTotalCredito
            // 
            this.lblTotalCredito.AutoSize = true;
            this.lblTotalCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredito.Location = new System.Drawing.Point(1146, 556);
            this.lblTotalCredito.Name = "lblTotalCredito";
            this.lblTotalCredito.Size = new System.Drawing.Size(52, 18);
            this.lblTotalCredito.TabIndex = 17;
            this.lblTotalCredito.Text = "label3";
            // 
            // lblTotalDebito
            // 
            this.lblTotalDebito.AutoSize = true;
            this.lblTotalDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebito.Location = new System.Drawing.Point(1146, 586);
            this.lblTotalDebito.Name = "lblTotalDebito";
            this.lblTotalDebito.Size = new System.Drawing.Size(52, 18);
            this.lblTotalDebito.TabIndex = 18;
            this.lblTotalDebito.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DESDE";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVolver.Location = new System.Drawing.Point(813, 48);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 28);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "CANCELAR";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgDetalleFacturacion
            // 
            this.dgDetalleFacturacion.AllowUserToAddRows = false;
            this.dgDetalleFacturacion.AllowUserToDeleteRows = false;
            this.dgDetalleFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleFacturacion.Location = new System.Drawing.Point(12, 451);
            this.dgDetalleFacturacion.Name = "dgDetalleFacturacion";
            this.dgDetalleFacturacion.ReadOnly = true;
            this.dgDetalleFacturacion.Size = new System.Drawing.Size(634, 173);
            this.dgDetalleFacturacion.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "DETALLES";
            // 
            // btnPDF
            // 
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.Location = new System.Drawing.Point(1220, 96);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(47, 46);
            this.btnPDF.TabIndex = 22;
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnXML
            // 
            this.btnXML.Image = ((System.Drawing.Image)(resources.GetObject("btnXML.Image")));
            this.btnXML.Location = new System.Drawing.Point(1220, 154);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(47, 50);
            this.btnXML.TabIndex = 23;
            this.btnXML.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 636);
            this.ControlBox = false;
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgDetalleFacturacion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTotalDebito);
            this.Controls.Add(this.lblTotalCredito);
            this.Controls.Add(this.lblBoleta);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgFacturacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNotaDebito);
            this.Controls.Add(this.btnNotaCredito);
            this.Controls.Add(this.btnBoleta);
            this.Controls.Add(this.btnFactura);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnBoleta;
        private System.Windows.Forms.Button btnNotaCredito;
        private System.Windows.Forms.Button btnNotaDebito;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgFacturacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblBoleta;
        private System.Windows.Forms.Label lblTotalCredito;
        private System.Windows.Forms.Label lblTotalDebito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgDetalleFacturacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnXML;
    }
}