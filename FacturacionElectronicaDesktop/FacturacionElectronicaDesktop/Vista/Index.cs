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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Closed += (s, args) => this.Close();
            l.Show();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas v = new Ventas();
            v.Closed += (s, args) => this.Close();
            v.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta c = new Consulta();
            c.Closed += (s, args) => this.Close();
            c.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Servicios se = new Servicios();
            se.Closed += (s, args) => this.Close();
            se.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cl = new Clientes();
            cl.Closed += (s, args) => this.Close();
            cl.Show();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            CuentaBancaria cb = new CuentaBancaria();
            cb.Closed += (s, args) => this.Close();
            cb.Show();
        }
    }
}
