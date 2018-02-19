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

namespace FacturacionElectronicaDesktop.Vista
{
    public partial class InsertarFactura : Form
    {
        public class Estado
        {
            public Estado(string name, int id)
            {
                this.Name = name; this.Id = id;
            }
            public string Name {get; set; }
            public int Id { get; set; }
        }

        DatosClientes dc = new DatosClientes();
        DatosOperacion dao = new DatosOperacion();
        DatosMoneda dm = new DatosMoneda();
        DatosProductos dp = new DatosProductos();
        DatosIGV di = new DatosIGV();
        DatoDocumentoElectronico dd = new DatoDocumentoElectronico();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public InsertarFactura()
        {
            InitializeComponent();

        }
        private BindingList<Estado> estado = new BindingList<Estado>();

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas v = new Ventas();
            v.Closed += (s, args) => this.Close();
            v.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarCliente inc = new InsertarCliente();
            inc.Closed += (s, args) => this.Close();
            inc.Show();
        }

        private void InsertarFactura_Load(object sender, EventArgs e)
        {
            cboCliente.DataSource = dc.ListarTablaCliente();
            cboCliente.ValueMember = "NumeroRuc";
            cboCliente.DisplayMember = "RazonSocial";

            cboOperacion.DataSource = dao.ListadoOperaciones();
            cboOperacion.ValueMember = "CodigoOperacion";
            cboOperacion.DisplayMember = "Tipo_Operacion";

            cboMoneda.DataSource = dm.ListadoMonedas();
            cboMoneda.ValueMember = "CodigoMoneda";
            cboMoneda.DisplayMember = "DescripcionMoneda";

            cboProducto.DataSource = dp.ListadoTablaProductos();
            cboProducto.ValueMember = "CodigoProducto";
            cboProducto.DisplayMember = "DescripcionProducto";
            cboProducto.Text = "Seleccionar Producto";

            cboIGV.DataSource = di.ListadoIGV();
            cboIGV.ValueMember = "CodigoTipoIGV";
            cboIGV.DisplayMember = "Tipo_IGV";
            cboIGV.Text = "Seleccionar IGV";

            cboDocumento.DataSource = dd.ListadoTipoDocumento();
            cboDocumento.ValueMember = "CodigoDocumentElectronico";
            cboDocumento.DisplayMember = "DescripcionDocumentoElectronico";

            estado.Add(new Estado("Si", 0));
            estado.Add(new Estado("No", 1));
            this.cboEstado.DataSource = estado;
            this.cboEstado.DisplayMember = "Name";
            this.cboEstado.ValueMember = "Id";

            txtExonerada.Text = "0.00";
            txtInafecta.Text = "0.00";
            txtGravada.Text = "0.00";
            txtGratuita.Text = "0.00";
            txtTotalBoleta.Text = "0.00";
            txtIGV.Text = "0.00";

            btnEliminar.Enabled = false;

            
        }

        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True"))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("select valor_unitario from Productos where codigo_producto='" + cboProducto.SelectedValue.ToString() + "'", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtValorUnitario.Text = dr["valor_unitario"].ToString();
                    /*if (txtValorUnitario.Text.Contains(','))
                    {
                        txtValorUnitario.Text = txtValorUnitario.Text.Replace(',', '.');
                        txtValorUnitario.SelectionStart = txtValorUnitario.Text.IndexOf('.') + 1;
                        txtValorUnitario.SelectionLength = 0;
                        txtValorUnitario.Focus();
                    }*/
                }
                
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProducto.Text == "Seleccionar Producto")
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad");
                txtCantidad.Focus();

            }

            if (cboIGV.Text == "Seleccionar IGV")
            {
                MessageBox.Show("Debe seleccionar un IGV");
            }

            dgDetalle.Enabled = true;

            string idproducto = cboProducto.SelectedValue.ToString();
            string producto = cboProducto.Text;
            int cantidad = Int32.Parse(txtCantidad.Text);
            string idIGV = cboIGV.SelectedValue.ToString();
            string tipoIGV = cboIGV.Text;
            double valorUnitario = Double.Parse(txtValorUnitario.Text);
            double subtotal = Double.Parse(txtSubtotal.Text);
            double total = Double.Parse(txtTotal.Text);

            dgDetalle.Rows.Add(idproducto,producto, cantidad, idIGV, tipoIGV, valorUnitario, subtotal, total);

            double igv = 0;
            double totalProducto = 0;
            double exonerada = Double.Parse(txtExonerada.Text);
            double gravada = Double.Parse(txtGravada.Text);
            double calculoIGV = Double.Parse(txtIGV.Text);
            double gratuita = Double.Parse(txtGratuita.Text);
            double inafecta = Double.Parse(txtInafecta.Text);
            double totalBoleta = Double.Parse(txtTotalBoleta.Text);

            switch (cboIGV.SelectedIndex)
            {

                case 0:
                    subtotal = cantidad * valorUnitario;
                    igv = subtotal * 0.18;
                    totalProducto = subtotal + igv;
                    gravada += totalProducto;
                    calculoIGV += igv;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    txtGravada.Text = gravada.ToString();
                    txtIGV.Text = calculoIGV.ToString();
                    break;

                case 7:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    exonerada += totalProducto;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    txtExonerada.Text = exonerada.ToString();
                    break;

                case 9:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    inafecta += totalProducto;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    txtInafecta.Text = inafecta.ToString();
                    break;

                case 16:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    inafecta += totalProducto;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    txtInafecta.Text = inafecta.ToString();
                    break;

                default:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    gratuita += totalProducto;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    txtGratuita.Text = gratuita.ToString();
                    break;
            }
            totalBoleta = exonerada + inafecta + gratuita + gravada + igv;
            txtTotalBoleta.Text = totalBoleta.ToString();



            cboProducto.Text = "Seleccionar Producto";
            txtCantidad.Text = "";
            cboIGV.Text = "Seleccionar IGV";
            txtValorUnitario.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";


        }
        
        private void cboIGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(txtCantidad.Text);
            double valorUnitario = Double.Parse(txtValorUnitario.Text);
            double subtotal = 0;
            double igv = 0;
            double totalProducto = 0;
           
            switch (cboIGV.SelectedIndex)
            {

                case 0:
                    subtotal = cantidad * valorUnitario;
                    igv = subtotal * 0.18;
                    totalProducto = subtotal + igv;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    break;

                case 7:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    break;

                case 9:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    break;

                case 16:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    break;

                default:
                    subtotal = cantidad * valorUnitario;
                    totalProducto = subtotal;
                    txtSubtotal.Text = subtotal.ToString();
                    txtTotal.Text = totalProducto.ToString();
                    break;
            }

        }

        private void dgDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboProducto.Text = dgDetalle.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dgDetalle.CurrentRow.Cells[2].Value.ToString();
            cboIGV.Text = dgDetalle.CurrentRow.Cells[4].Value.ToString();
            txtValorUnitario.Text = dgDetalle.CurrentRow.Cells[5].Value.ToString();
            txtSubtotal.Text = dgDetalle.CurrentRow.Cells[6].Value.ToString();
            txtTotal.Text = dgDetalle.CurrentRow.Cells[7].Value.ToString();
            btnEliminar.Enabled = true;

          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int rowIndex = dgDetalle.CurrentCell.RowIndex;
            dgDetalle.Rows.RemoveAt(rowIndex);

            if (dgDetalle.Rows.Count == 0)
            {
                dgDetalle.Enabled = false;
            }

            cboProducto.Text = "Seleccionar Producto";
            txtCantidad.Text = "";
            cboIGV.Text = "Seleccionar IGV";
            txtValorUnitario.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            string numerofac = "";
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarFactura", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_ruc", cboCliente.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@cod_doc", cboDocumento.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@num_serie", txtSerie.Text);
                cmd.Parameters.AddWithValue("@num_cor", txtCorrelativo.Text);
                cmd.Parameters.AddWithValue("@fec_em", dtEmision.Text);
                cmd.Parameters.AddWithValue("@cod_op", cboOperacion.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@cod_mon", cboMoneda.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@tipo", txtCambio.Text);
                cmd.Parameters.AddWithValue("@fec_ven", dtVencimiento.Text);
                cmd.Parameters.AddWithValue("@estado", cboEstado.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@exo", txtExonerada.Text);
                cmd.Parameters.AddWithValue("@inf", txtInafecta.Text);
                cmd.Parameters.AddWithValue("@gra", txtGravada.Text);
                cmd.Parameters.AddWithValue("@igv", txtIGV.Text);
                cmd.Parameters.AddWithValue("@gratuita", txtGratuita.Text);
                cmd.Parameters.AddWithValue("@tot_bol", txtTotalBoleta.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    numerofac = reader[0].ToString();
                }

                for (int i = 0; i < dgDetalle.Rows.Count; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("InsertarDetalle", cn);
                    cn.Open();
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@num_fac", numerofac);
                    cmd1.Parameters.AddWithValue("@cod_pro", dgDetalle.CurrentRow.Cells[0].Value.ToString());
                    cmd1.Parameters.AddWithValue("@cantidad", dgDetalle.CurrentRow.Cells[2].Value.ToString());
                    cmd1.Parameters.AddWithValue("@tipo_igv", dgDetalle.CurrentRow.Cells[3].Value.ToString());
                    cmd1.Parameters.AddWithValue("@valor", dgDetalle.CurrentRow.Cells[5].Value.ToString());
                    cmd1.Parameters.AddWithValue("@subtotal", dgDetalle.CurrentRow.Cells[6].Value.ToString());
                    cmd1.Parameters.AddWithValue("@tot_pro", dgDetalle.CurrentRow.Cells[7].Value.ToString());
                    
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                }
            }
            catch (SqlException ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
