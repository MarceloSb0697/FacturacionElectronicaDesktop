using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CapaDatos;
using System.Data.SqlClient;

namespace FacturacionElectronicaDesktop.Vista
{
    public partial class InsertarCliente : Form
    {
        DatosDocumento da = new DatosDocumento();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public InsertarCliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cl = new Clientes();
            cl.Closed += (s, args) => this.Close();
            cl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataContribuyente datareturn = new DataContribuyente();
            string url = "https://www.facturacionelectronica.us/plugins/sunat/demo.php?act=1&ruc=" + txtNumero.Text;

            var web_request = (HttpWebRequest)System.Net.WebRequest.Create(url);
            using (var response = web_request.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string resultado = reader.ReadToEnd();
                string jsonViene = Convert.ToString(resultado);

                RootObject respuesta = JsonConvert.DeserializeObject<RootObject>(jsonViene);

                if (respuesta.success)
                {
                    datareturn.success = true;
                    datareturn.mensaje = "Datos extraidos correctamente";
                    datareturn.RUC = respuesta.result.RUC;
                    datareturn.RazonSocial = respuesta.result.RazonSocial;
                    datareturn.Direccion = respuesta.result.Direccion;

                    if (txtNumero.TextLength == 8)
                    {
                        cboTipo.SelectedIndex = 1;
                    }
                    if (txtNumero.TextLength == 11)
                    {
                        cboTipo.SelectedIndex = 3;
                    }
                }
                else
                {
                    datareturn.success = false;
                    MessageBox.Show("Datos no encontrados");
                }

                txtRazon.Text = datareturn.RazonSocial;
                txtDireccion.Text = datareturn.Direccion;

                

            }
        }

        public class Result
        {
            public string RUC { get; set; }
            public string RazonSocial { get; set; }
            public string Direccion { get; set; }

        }

        public class RootObject
        {
            public bool success { get; set; }
            public Result result { get; set; }
        }

        public class DataContribuyente
        {
            public bool success { get; set; }
            public string mensaje { get; set; }
            public string RUC { get; set; }
            public string RazonSocial { get; set; }
            public string Direccion { get; set; }
           
        }

        private void InsertarCliente_Load(object sender, EventArgs e)
        {
            cboTipo.DataSource = da.ListadoDocumento();
            cboTipo.ValueMember = "CodigoDocumento";
            cboTipo.DisplayMember = "TipoDocumento";

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text == "")
                {
                    MessageBox.Show("Debe ingresar Numero de RUC");
                    txtNumero.Focus();
                }

                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Debe ingresar correo electrónico");
                    txtEmail.Focus();
                }
                if (txtFijo.Text == "")
                {
                    MessageBox.Show("Debe ingresar telefono fijo");
                    txtFijo.Focus();
                }
                if (txtMovil.Text == "")
                {
                    MessageBox.Show("Debe ingresar celular");
                    txtMovil.Focus();
                }

                else
                {
                    string q = "insert into Cliente values('" + txtNumero.Text + "','" + cboTipo.SelectedValue.ToString() + "','" + txtRazon.Text + "','" + txtDireccion.Text + "','" + txtEmail.Text + "','" + txtMovil.Text + "','" + txtFijo.Text + "')";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(q, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Cliente Insertado");
                    this.Hide();
                    Clientes cl = new Clientes();
                    cl.Closed += (s, args) => this.Close();
                    cl.Show();
                }

                
            }
            catch(Exception ex){
                MessageBox.Show("Error al insertar Cliente");
            }
           
        }

        private void txtFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
