using CapaDatos;
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
    public partial class InsertarBoleta : Form
    {
        public class Estado
        {
            public Estado(string name, int id)
            {
                this.Name = name; this.Id = id;
            }
            public string Name { get; set; }
            public int Id { get; set; }
        }

        DatosClientes dc = new DatosClientes();
        DatosOperacion dao = new DatosOperacion();
        DatosMoneda dm = new DatosMoneda();
        DatosProductos dp = new DatosProductos();
        DatosIGV di = new DatosIGV();
        DatoDocumentoElectronico dd = new DatoDocumentoElectronico();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public InsertarBoleta()
        {
            InitializeComponent();
        }
        private BindingList<Estado> estado = new BindingList<Estado>();

        private void InsertarBoleta_Load(object sender, EventArgs e)
        {
            cboCliente.DataSource = dc.ListarTablaCliente();
            cboCliente.ValueMember = "NumeroRuc";
            cboCliente.DisplayMember = "NumeroRuc";

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

            cboDocumento.DataSource = dd.ListadoBoleta();
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
            cboCliente.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            cboIGV.SelectedIndex = -1;


            txtEmisor.Text = "20522040119";
            txtRazonEmisor.Text = "Logistica Contable y Tributaria S.A.C";

            btnEliminar.Enabled = false;

            dgDetalle.Columns[5].DefaultCellStyle.Format = "N2";
            dgDetalle.Columns[6].DefaultCellStyle.Format = "N2";
            dgDetalle.Columns[7].DefaultCellStyle.Format = "N2";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarCliente inc = new InsertarCliente();
            inc.Closed += (s, args) => this.Close();
            inc.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas v = new Ventas();
            v.Closed += (s, args) => this.Close();
            v.Show();
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

                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {


                if (cboProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un producto");
                }

                if (txtCantidad.Text == "")
                {
                    MessageBox.Show("Debe ingresar una cantidad");
                    txtCantidad.Focus();

                }

                if (cboIGV.SelectedIndex == -1)
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

                dgDetalle.Rows.Add(idproducto, producto, cantidad, idIGV, tipoIGV, valorUnitario, subtotal, total);

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
                        gravada += subtotal;
                        calculoIGV += igv;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        txtGravada.Text = string.Format("{0:n2}", (Math.Truncate(gravada * 100) / 100));
                        txtIGV.Text = string.Format("{0:n2}", (Math.Truncate(calculoIGV * 100) / 100));
                        break;

                    case 7:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        exonerada += totalProducto;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        txtExonerada.Text = string.Format("{0:n2}", (Math.Truncate(exonerada * 100) / 100));
                        break;

                    case 9:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        inafecta += totalProducto;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        txtInafecta.Text = string.Format("{0:n2}", (Math.Truncate(inafecta * 100) / 100));
                        break;

                    case 16:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        inafecta += totalProducto;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        txtInafecta.Text = string.Format("{0:n2}", (Math.Truncate(inafecta * 100) / 100));
                        break;

                    default:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        gratuita += totalProducto;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                        break;
                }
                totalBoleta = exonerada + inafecta + gravada + calculoIGV;
                txtTotalBoleta.Text = string.Format("{0:n2}", (Math.Truncate(totalBoleta * 100) / 100));


                cboIGV.SelectedIndex = -1;
                txtCantidad.Text = "";
                cboProducto.SelectedIndex = -1;
                txtValorUnitario.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar elemento");
            }
        }

        private void cboIGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
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
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        break;

                    case 7:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        break;

                    case 9:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        break;

                    case 16:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        break;

                    default:
                        subtotal = cantidad * valorUnitario;
                        totalProducto = subtotal;
                        txtSubtotal.Text = string.Format("{0:n2}", (Math.Truncate(subtotal * 100) / 100));
                        txtTotal.Text = string.Format("{0:n2}", (Math.Truncate(totalProducto * 100) / 100));
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo realizar el calculo");
                cboIGV.SelectedIndex = -1;
                cboProducto.SelectedIndex = -1;

            }
        }

        private void dgDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            try
            {
                int cantidad = Int32.Parse(txtCantidad.Text);
                double valorUnitario = Double.Parse(txtValorUnitario.Text);
                double subtotal = 0;
                double igv = 0;
                double totalProducto = 0;
                double exonerada = Double.Parse(txtExonerada.Text);
                double gravada = Double.Parse(txtGravada.Text);
                double calculoIGV = Double.Parse(txtIGV.Text);
                double gratuita = Double.Parse(txtGratuita.Text);
                double inafecta = Double.Parse(txtInafecta.Text);
                double totalBoleta = Double.Parse(txtTotalBoleta.Text);

                int rowIndex = dgDetalle.CurrentCell.RowIndex;
                dgDetalle.Rows.RemoveAt(rowIndex);

                if (dgDetalle.Rows.Count == 0)
                {
                    dgDetalle.Enabled = false;
                    btnEliminar.Enabled = false;

                    txtExonerada.Text = "0.00";
                    txtGravada.Text = "0.00";
                    txtGratuita.Text = "0.00";
                    txtInafecta.Text = "0.00";
                    txtIGV.Text = "0.00";
                    txtTotalBoleta.Text = "0.00";

                    cboIGV.SelectedIndex = -1;
                    txtCantidad.Text = "";
                    cboProducto.SelectedIndex = -1;
                    txtValorUnitario.Text = "";
                    txtSubtotal.Text = "";
                    txtTotal.Text = "";
                }

                else
                {

                    switch (cboIGV.SelectedIndex)
                    {
                        case 0:
                            subtotal = cantidad * valorUnitario;
                            igv = subtotal * 0.18;
                            totalProducto = subtotal + igv;
                            gravada -= subtotal;
                            calculoIGV -= igv;
                            txtGravada.Text = string.Format("{0:n2}", (Math.Truncate(gravada * 100) / 100));
                            txtIGV.Text = string.Format("{0:n2}", (Math.Truncate(calculoIGV * 100) / 100));
                            break;

                        case 7:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            exonerada -= totalProducto;
                            txtExonerada.Text = string.Format("{0:n2}", (Math.Truncate(exonerada * 100) / 100));
                            break;
                        case 9:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            inafecta -= totalProducto;
                            txtInafecta.Text = string.Format("{0:n2}", (Math.Truncate(inafecta * 100) / 100));
                            break;

                        case 16:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            inafecta -= totalProducto;
                            txtInafecta.Text = string.Format("{0:n2}", (Math.Truncate(inafecta * 100) / 100));
                            break;

                        case 1:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;

                        case 2:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 3:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 4:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 5:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 6:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 8:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 10:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 11:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 12:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 13:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 14:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;
                        case 15:
                            subtotal = cantidad * valorUnitario;
                            totalProducto = subtotal;
                            gratuita -= totalProducto;
                            txtGratuita.Text = string.Format("{0:n2}", (Math.Truncate(gratuita * 100) / 100));
                            break;

                    }
                    totalBoleta = exonerada + inafecta + gravada + calculoIGV;
                    txtTotalBoleta.Text = string.Format("{0:n2}", (Math.Truncate(totalBoleta * 100) / 100));

                }

                cboIGV.SelectedIndex = -1;
                txtCantidad.Text = "";
                cboProducto.SelectedIndex = -1;
                txtValorUnitario.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha seleccionado un registro");
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string numerofac = "";
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarFactura", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_ruc", cboCliente.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@razon_social", txtRazonReceptor.Text);
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

                reader.Close();

                for (int i = 0; i < dgDetalle.Rows.Count; i++)
                {
                    SqlConnection cn1 = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");
                    SqlCommand cmd1 = new SqlCommand("InsertarDetalle", cn);

                    cn1.Open();
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@num_fac", numerofac);
                    cmd1.Parameters.AddWithValue("@cod_pro", dgDetalle.CurrentRow.Cells[0].Value.ToString());
                    cmd1.Parameters.AddWithValue("@cantidad", dgDetalle.CurrentRow.Cells[2].Value.ToString());
                    cmd1.Parameters.AddWithValue("@tipo_igv", dgDetalle.CurrentRow.Cells[3].Value.ToString());
                    cmd1.Parameters.AddWithValue("@valor", dgDetalle.CurrentRow.Cells[5].Value.ToString());
                    cmd1.Parameters.AddWithValue("@subtotal", dgDetalle.CurrentRow.Cells[6].Value.ToString());
                    cmd1.Parameters.AddWithValue("@tot_pro", dgDetalle.CurrentRow.Cells[7].Value.ToString());


                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    reader1.Close();
                    cn1.Close();

                    


                }

                DialogResult dialog = MessageBox.Show("Boleta Insertada");
                if (dialog == DialogResult.OK)
                {
                    this.Hide();
                    Ventas v = new Ventas();
                    v.Closed += (s, args) => this.Close();
                    v.Show();
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar boleta");
            }
            finally
            {
                cn.Close();
            }
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True"))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("select razon_social from Cliente where numero_ruc='" + cboCliente.SelectedValue.ToString() + "'", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtRazonReceptor.Text = dr["razon_social"].ToString();

                }

            }
        }
    }
}
