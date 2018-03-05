using CapaDatos;
using FacturacionElectronicaDesktop.Controlador;
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

namespace FacturacionElectronicaDesktop.Vista
{
    public partial class InsertarCuentaBancaria : Form
    {
        DatosMoneda dm = new DatosMoneda();
        DatosCuentaBancaria dc = new DatosCuentaBancaria();

        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");
        public InsertarCuentaBancaria()
        {
            InitializeComponent();
        }

        private void InsertarCuentaBancaria_Load(object sender, EventArgs e)
        {
            cboMoneda.DataSource = dm.ListadoMonedas();
            cboMoneda.ValueMember = "CodigoMoneda";
            cboMoneda.DisplayMember = "DescripcionMoneda";

            cboTipoCuenta.DataSource = dc.ListadoTipoCuenta();
            cboTipoCuenta.ValueMember = "IdTipoCuenta";
            cboTipoCuenta.DisplayMember = "DescripcionTipoCuenta";

            cboMoneda.SelectedIndex = -1;
            cboTipoCuenta.SelectedIndex = -1;


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            CuentaBancaria cb = new CuentaBancaria();
            cb.Closed += (s, args) => this.Close();
            cb.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMoneda.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccionar moneda");
                }
                if (cboTipoCuenta.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccionar tipo de cuenta");
                }

                if (txtNombreBanco.Text == "")
                {
                    MessageBox.Show("Ingresar nombre de banco");
                    txtNombreBanco.Focus();
                }
                if (txtTitular.Text == "")
                {
                    MessageBox.Show("Ingresar nombre de titular");
                    txtTitular.Focus();
                }
                if (txtNumeroCuenta.Text == "")
                {
                    MessageBox.Show("Ingresar numero de cuenta");
                    txtNumeroCuenta.Focus();
                }

                else
                {
                    string q = "insert into CuentaBancaria values('" + cboMoneda.SelectedValue.ToString() + "','" + cboTipoCuenta.SelectedValue.ToString() + "','" + txtNombreBanco.Text + "','" + txtTitular.Text + "','" + txtNumeroCuenta.Text + "')";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Cuenta Bancaria Insertada");
                    this.Hide();
                    CuentaBancaria se = new CuentaBancaria();
                    se.Closed += (s, args) => this.Close();
                    se.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cuenta bancaria");
            }
        }
    }
}
