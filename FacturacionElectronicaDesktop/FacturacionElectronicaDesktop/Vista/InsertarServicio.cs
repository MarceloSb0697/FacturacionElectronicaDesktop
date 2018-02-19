using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using FacturacionElectronicaDesktop.Modelo.Entidades;

namespace FacturacionElectronicaDesktop.Vista
{
    public partial class InsertarServicio : Form
    {
        DatosMoneda dm = new DatosMoneda();
        DatosUnidadMedida du = new DatosUnidadMedida();

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public InsertarServicio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Servicios se = new Servicios();
            se.Closed += (s, args) => this.Close();
            se.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           
            string q = "insert into Productos values('" + cboTipo.SelectedValue.ToString() + "','" + txtCodigo.Text + "','" + txtDescripcion.Text + "','"+ cboMoneda.SelectedValue.ToString() + "','"+txtValorUnitario.Text + "','" + txtPrecioUnitario.Text + "')";
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Servicio Insertado");
            this.Hide();
            Servicios se = new Servicios();
            se.Closed += (s, args) => this.Close();
            se.Show();
        }

        private void InsertarServicio_Load(object sender, EventArgs e)
        {

            cboMoneda.DataSource = dm.ListadoMonedas();
            cboMoneda.ValueMember = "CodigoMoneda";
            cboMoneda.DisplayMember = "DescripcionMoneda";

            cboTipo.DataSource = du.ListadoUnidades();
            cboTipo.ValueMember = "CodigoUnidadMedida";
            cboTipo.DisplayMember = "DescripcionUnidadMedida";
        }
    }
}
