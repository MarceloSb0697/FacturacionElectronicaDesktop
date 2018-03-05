namespace FacturacionElectronicaDesktop.Vista
{
    partial class CuentaBancaria
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgCuentaBancaria = new System.Windows.Forms.DataGridView();
            this.btnCuentaBancaria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuentaBancaria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalir.Location = new System.Drawing.Point(527, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 39);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgCuentaBancaria
            // 
            this.dgCuentaBancaria.AllowUserToAddRows = false;
            this.dgCuentaBancaria.AllowUserToDeleteRows = false;
            this.dgCuentaBancaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuentaBancaria.Location = new System.Drawing.Point(24, 72);
            this.dgCuentaBancaria.Name = "dgCuentaBancaria";
            this.dgCuentaBancaria.ReadOnly = true;
            this.dgCuentaBancaria.Size = new System.Drawing.Size(647, 333);
            this.dgCuentaBancaria.TabIndex = 5;
            this.dgCuentaBancaria.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgCuentaBancaria_DataBindingComplete);
            // 
            // btnCuentaBancaria
            // 
            this.btnCuentaBancaria.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCuentaBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentaBancaria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCuentaBancaria.Location = new System.Drawing.Point(24, 14);
            this.btnCuentaBancaria.Name = "btnCuentaBancaria";
            this.btnCuentaBancaria.Size = new System.Drawing.Size(238, 39);
            this.btnCuentaBancaria.TabIndex = 4;
            this.btnCuentaBancaria.Text = "NUEVA CUENTA BANCARIA";
            this.btnCuentaBancaria.UseVisualStyleBackColor = false;
            this.btnCuentaBancaria.Click += new System.EventHandler(this.btnCuentaBancaria_Click);
            // 
            // CuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 467);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgCuentaBancaria);
            this.Controls.Add(this.btnCuentaBancaria);
            this.Name = "CuentaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUENTA BANCARIA";
            this.Load += new System.EventHandler(this.CuentaBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCuentaBancaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgCuentaBancaria;
        private System.Windows.Forms.Button btnCuentaBancaria;
    }
}