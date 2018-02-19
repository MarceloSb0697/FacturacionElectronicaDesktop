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
    public partial class Servicios : Form
    {
        DatosProductos dp = new DatosProductos();
        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            dgServicios.DataSource = dp.ListadoProductos().ToList();

            dgServicios.Columns[0].HeaderText = "Tipo";
            dgServicios.Columns[1].HeaderText = "Codigo";
            dgServicios.Columns[2].HeaderText = "Descripcion";
            dgServicios.Columns[3].HeaderText = "Moneda";
            dgServicios.Columns[4].HeaderText = "Valor Unitario";
            dgServicios.Columns[5].HeaderText = "Precio Unitario";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index i = new Index();
            i.Closed += (s, args) => this.Close();
            i.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarServicio ins = new InsertarServicio();
            ins.Closed += (s, args) => this.Close();
            ins.Show();
        }
    }
}
