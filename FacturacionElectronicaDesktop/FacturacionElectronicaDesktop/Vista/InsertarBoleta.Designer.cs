namespace FacturacionElectronicaDesktop.Vista
{
    partial class InsertarBoleta
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
            this.txtEmisor = new System.Windows.Forms.MaskedTextBox();
            this.txtRazonEmisor = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRazonReceptor = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEmision = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultarValor = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTotalBoleta = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtGratuita = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGravada = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtInafecta = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtExonerada = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboIGV = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmisor
            // 
            this.txtEmisor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmisor.Enabled = false;
            this.txtEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmisor.Location = new System.Drawing.Point(11, 36);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(185, 24);
            this.txtEmisor.TabIndex = 153;
            // 
            // txtRazonEmisor
            // 
            this.txtRazonEmisor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRazonEmisor.Enabled = false;
            this.txtRazonEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonEmisor.Location = new System.Drawing.Point(222, 36);
            this.txtRazonEmisor.Name = "txtRazonEmisor";
            this.txtRazonEmisor.Size = new System.Drawing.Size(262, 24);
            this.txtRazonEmisor.TabIndex = 152;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(276, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 16);
            this.label24.TabIndex = 151;
            this.label24.Text = "RAZON EMISOR";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(53, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 16);
            this.label25.TabIndex = 150;
            this.label25.Text = "EMISOR";
            // 
            // txtRazonReceptor
            // 
            this.txtRazonReceptor.Enabled = false;
            this.txtRazonReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonReceptor.Location = new System.Drawing.Point(693, 36);
            this.txtRazonReceptor.Name = "txtRazonReceptor";
            this.txtRazonReceptor.Size = new System.Drawing.Size(262, 24);
            this.txtRazonReceptor.TabIndex = 149;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(762, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 16);
            this.label23.TabIndex = 148;
            this.label23.Text = "RAZON RECEPTOR";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(854, 120);
            this.txtCambio.MaxLength = 5;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(111, 24);
            this.txtCambio.TabIndex = 114;
            this.txtCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCambio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(862, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 113;
            this.label8.Text = "TIPO CAMBIO";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(662, 118);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(175, 26);
            this.cboMoneda.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(695, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "MONEDA";
            // 
            // cboOperacion
            // 
            this.cboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Location = new System.Drawing.Point(464, 118);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(175, 26);
            this.cboOperacion.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 109;
            this.label5.Text = "TIPO OPERACION";
            // 
            // dtEmision
            // 
            this.dtEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmision.Location = new System.Drawing.Point(246, 118);
            this.dtEmision.Name = "dtEmision";
            this.dtEmision.Size = new System.Drawing.Size(200, 24);
            this.dtEmision.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "FECHA EMISION";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativo.Location = new System.Drawing.Point(113, 120);
            this.txtCorrelativo.MaxLength = 6;
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(111, 24);
            this.txtCorrelativo.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "CORRELATIVO";
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(3, 120);
            this.txtSerie.MaxLength = 4;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(89, 24);
            this.txtSerie.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 103;
            this.label6.Text = "SERIE";
            // 
            // cboDocumento
            // 
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Location = new System.Drawing.Point(1134, 37);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(175, 26);
            this.cboDocumento.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1146, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "TIPO DOCUMENTO";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(500, 37);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(175, 26);
            this.cboCliente.TabIndex = 100;
            this.cboCliente.SelectionChangeCommitted += new System.EventHandler(this.cboCliente_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "RECEPTOR";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(966, 32);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(152, 31);
            this.btnConsultar.TabIndex = 98;
            this.btnConsultar.Text = "NUEVO CLIENTE";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConsultarValor
            // 
            this.btnConsultarValor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarValor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarValor.Location = new System.Drawing.Point(993, 107);
            this.btnConsultarValor.Name = "btnConsultarValor";
            this.btnConsultarValor.Size = new System.Drawing.Size(264, 47);
            this.btnConsultarValor.TabIndex = 187;
            this.btnConsultarValor.Text = "CONSULTAR VALOR UNITARIO SUNAT";
            this.btnConsultarValor.UseVisualStyleBackColor = false;
            this.btnConsultarValor.Click += new System.EventHandler(this.btnConsultarValor_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Location = new System.Drawing.Point(636, 249);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(132, 24);
            this.txtValorUnitario.TabIndex = 186;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(1178, 244);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 31);
            this.btnEliminar.TabIndex = 185;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTotalBoleta
            // 
            this.txtTotalBoleta.Enabled = false;
            this.txtTotalBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBoleta.Location = new System.Drawing.Point(947, 592);
            this.txtTotalBoleta.Name = "txtTotalBoleta";
            this.txtTotalBoleta.Size = new System.Drawing.Size(152, 24);
            this.txtTotalBoleta.TabIndex = 184;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(781, 597);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 16);
            this.label22.TabIndex = 183;
            this.label22.Text = "TOTAL BOLETA";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(425, 641);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(175, 43);
            this.btnVolver.TabIndex = 182;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertar.Location = new System.Drawing.Point(194, 641);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(217, 43);
            this.btnInsertar.TabIndex = 181;
            this.btnInsertar.Text = "CREAR COMPROBANTE";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtGratuita
            // 
            this.txtGratuita.Enabled = false;
            this.txtGratuita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGratuita.Location = new System.Drawing.Point(557, 589);
            this.txtGratuita.Name = "txtGratuita";
            this.txtGratuita.Size = new System.Drawing.Size(152, 24);
            this.txtGratuita.TabIndex = 180;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(391, 594);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 16);
            this.label21.TabIndex = 179;
            this.label21.Text = "GRATUITA";
            // 
            // txtIGV
            // 
            this.txtIGV.Enabled = false;
            this.txtIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGV.Location = new System.Drawing.Point(184, 589);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(152, 24);
            this.txtIGV.TabIndex = 178;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 594);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 16);
            this.label20.TabIndex = 177;
            this.label20.Text = "IGV";
            // 
            // txtGravada
            // 
            this.txtGravada.Enabled = false;
            this.txtGravada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGravada.Location = new System.Drawing.Point(947, 548);
            this.txtGravada.Name = "txtGravada";
            this.txtGravada.Size = new System.Drawing.Size(152, 24);
            this.txtGravada.TabIndex = 176;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(781, 553);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 175;
            this.label19.Text = "GRAVADA";
            // 
            // txtInafecta
            // 
            this.txtInafecta.Enabled = false;
            this.txtInafecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInafecta.Location = new System.Drawing.Point(557, 548);
            this.txtInafecta.Name = "txtInafecta";
            this.txtInafecta.Size = new System.Drawing.Size(152, 24);
            this.txtInafecta.TabIndex = 174;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(391, 553);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 16);
            this.label18.TabIndex = 173;
            this.label18.Text = "INAFECTA";
            // 
            // txtExonerada
            // 
            this.txtExonerada.Enabled = false;
            this.txtExonerada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExonerada.Location = new System.Drawing.Point(184, 545);
            this.txtExonerada.Name = "txtExonerada";
            this.txtExonerada.Size = new System.Drawing.Size(152, 24);
            this.txtExonerada.TabIndex = 172;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 550);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 16);
            this.label17.TabIndex = 171;
            this.label17.Text = "EXONERADA";
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.Producto,
            this.Cantidad,
            this.IDTipo,
            this.TipoIGV,
            this.ValorUnitario,
            this.Subtotal,
            this.Total});
            this.dgDetalle.Enabled = false;
            this.dgDetalle.Location = new System.Drawing.Point(3, 298);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.Size = new System.Drawing.Size(1306, 233);
            this.dgDetalle.TabIndex = 170;
            this.dgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalle_CellContentClick);
            this.dgDetalle.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgDetalle_DataBindingComplete);
            // 
            // IDProducto
            // 
            this.IDProducto.HeaderText = "ID Producto";
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 180;
            // 
            // IDTipo
            // 
            this.IDTipo.HeaderText = "ID Tipo IGV";
            this.IDTipo.Name = "IDTipo";
            this.IDTipo.ReadOnly = true;
            // 
            // TipoIGV
            // 
            this.TipoIGV.HeaderText = "Tipo IGV";
            this.TipoIGV.Name = "TipoIGV";
            this.TipoIGV.ReadOnly = true;
            this.TipoIGV.Width = 180;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Valor Unitario";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            this.ValorUnitario.Width = 180;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 180;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 210;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(909, 249);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 24);
            this.txtTotal.TabIndex = 169;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(794, 249);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(109, 24);
            this.txtSubtotal.TabIndex = 168;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(1038, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 31);
            this.btnAgregar.TabIndex = 167;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(944, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 166;
            this.label16.Text = "TOTAL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(805, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 165;
            this.label15.Text = "SUBTOTAL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(648, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 164;
            this.label14.Text = "VALOR UNITARIO";
            // 
            // cboIGV
            // 
            this.cboIGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIGV.FormattingEnabled = true;
            this.cboIGV.Location = new System.Drawing.Point(332, 249);
            this.cboIGV.Name = "cboIGV";
            this.cboIGV.Size = new System.Drawing.Size(288, 26);
            this.cboIGV.TabIndex = 163;
            this.cboIGV.SelectionChangeCommitted += new System.EventHandler(this.cboIGV_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(412, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 162;
            this.label13.Text = "TIPO IGV";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(204, 251);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 24);
            this.txtCantidad.TabIndex = 161;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(212, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 160;
            this.label12.Text = "CANTIDAD";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(6, 251);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(175, 26);
            this.cboProducto.TabIndex = 159;
            this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.cboProducto_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 158;
            this.label11.Text = "PRODUCTO";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(586, 173);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(66, 26);
            this.cboEstado.TabIndex = 157;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(490, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 156;
            this.label10.Text = "¿PAGADO?";
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimiento.Location = new System.Drawing.Point(266, 176);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(200, 24);
            this.dtVencimiento.TabIndex = 155;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 16);
            this.label9.TabIndex = 154;
            this.label9.Text = "FECHA VENCIMIENTO";
            // 
            // InsertarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1324, 689);
            this.ControlBox = false;
            this.Controls.Add(this.btnConsultarValor);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtTotalBoleta);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtGratuita);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtGravada);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtInafecta);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtExonerada);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgDetalle);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboIGV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtVencimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.txtRazonEmisor);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtRazonReceptor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEmision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorrelativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Name = "InsertarBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMITIR BOLETA";
            this.Load += new System.EventHandler(this.InsertarBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtEmisor;
        private System.Windows.Forms.MaskedTextBox txtRazonEmisor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox txtRazonReceptor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEmision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultarValor;
        private System.Windows.Forms.MaskedTextBox txtValorUnitario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTotalBoleta;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtGratuita;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtGravada;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtInafecta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtExonerada;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboIGV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtVencimiento;
        private System.Windows.Forms.Label label9;
    }
}