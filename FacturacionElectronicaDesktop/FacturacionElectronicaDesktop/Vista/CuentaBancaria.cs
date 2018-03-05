using FacturacionElectronicaDesktop.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionElectronicaDesktop.Vista
{
    public partial class CuentaBancaria : Form
    {
        DatosCuentaBancaria dc = new DatosCuentaBancaria();
        FactronLCTEntities db = new FactronLCTEntities();
        public CuentaBancaria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index i = new Index();
            i.Closed += (s, args) => this.Close();
            i.Show();
        }

        private void btnCuentaBancaria_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarCuentaBancaria ic = new InsertarCuentaBancaria();
            ic.Closed += (s, args) => this.Close();
            ic.Show();
        }

        private void CuentaBancaria_Load(object sender, EventArgs e)
        {
            dgCuentaBancaria.DataSource = (from f in db.CuentaBancaria
                                           join m in db.TipoCuentaBancaria on f.id_tipo equals m.id_tipo
                                           

                                           select new
                                           {
                                               f.codigo_moneda,
                                               m.descripcion_tipo,
                                               f.nombre_banco,
                                               f.nombre_titular,
                                               f.numero_cuenta
                                              
                                           }).ToList();

            dgCuentaBancaria.Columns[0].HeaderText = "Moneda";
            dgCuentaBancaria.Columns[1].HeaderText = "Tipo Cuenta Bancaria";
            dgCuentaBancaria.Columns[2].HeaderText = "Nombre Banco";
            dgCuentaBancaria.Columns[3].HeaderText = "Nombre Titular";
            dgCuentaBancaria.Columns[4].HeaderText = "Numero de Cuenta";

            dgCuentaBancaria.Columns[0].Width = 120;
            dgCuentaBancaria.Columns[1].Width = 120;
            dgCuentaBancaria.Columns[2].Width = 120;
            dgCuentaBancaria.Columns[3].Width = 120;
            dgCuentaBancaria.Columns[4].Width = 120;


        }

        private void dgCuentaBancaria_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgCuentaBancaria.ClearSelection();
        }
    }
}
