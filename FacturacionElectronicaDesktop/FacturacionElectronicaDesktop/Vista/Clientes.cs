using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace FacturacionElectronicaDesktop.Vista
{
    public partial class Clientes : Form
    {
        DatosClientes dc = new DatosClientes();

        public Clientes()
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgClientes.DataSource = dc.ListadoCliente().ToList();

            dgClientes.Columns[0].HeaderText = "Numero";
            dgClientes.Columns[1].HeaderText = "Tipo";
            dgClientes.Columns[2].HeaderText = "Razon Social";
            dgClientes.Columns[3].HeaderText = "Direccion";
            dgClientes.Columns[4].HeaderText = "Email";
            dgClientes.Columns[5].HeaderText = "Teléfono Fijo";
            dgClientes.Columns[6].HeaderText = "Teléfono Móvil";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarCliente iC = new InsertarCliente();
            iC.Closed += (s, args) => this.Close();
            iC.Show();
        }

        private void dgClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgClientes.ClearSelection();
        }
    }
}
