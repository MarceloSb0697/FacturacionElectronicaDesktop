using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FacturacionElectronicaDesktop.Controlador;


namespace FacturacionElectronicaDesktop.Vista
{
    public partial class Ventas : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        DatosNotaCredito dn = new DatosNotaCredito();
        FactronLCTEntities db = new FactronLCTEntities();
        public Ventas()
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

        private void Ventas_Load(object sender, EventArgs e)
        {
            dgFacturacion.DataSource = (from f in db.FacturacionElectronica
                                        join m in db.Moneda on f.codigo_moneda equals m.codigo_moneda
                                        join c in db.Cliente on f.numero_ruc equals c.numero_ruc

                                        select new
                                        {
                                            f.num_factura,
                                            f.fecha_emision,
                                            f.codigo_documentoElectronico,
                                            f.numero_serie,
                                            f.numero_correlativo,
                                            f.numero_ruc,
                                            c.razon_social,
                                            m.descripcion_moneda,
                                            f.total_boleta,
                                            f.estado
                                        }).ToList();

            dgFacturacion.Columns[0].HeaderText = "Numero Factura";
            dgFacturacion.Columns[1].HeaderText = "Fecha";
            dgFacturacion.Columns[2].HeaderText = "Tipo";
            dgFacturacion.Columns[3].HeaderText = "Serie";
            dgFacturacion.Columns[4].HeaderText = "Correlativo";
            dgFacturacion.Columns[5].HeaderText = "RUC";
            dgFacturacion.Columns[6].HeaderText = "Razón Social";
            dgFacturacion.Columns[7].HeaderText = "Moneda";
            dgFacturacion.Columns[8].HeaderText = "Total";
            dgFacturacion.Columns[9].HeaderText = "¿Pagado?";

 

            btnVolver.Enabled = false;
            btnNotaCredito.Enabled = false;
            btnNotaDebito.Enabled = false;


            cn.Open();
            SqlCommand query = new SqlCommand("select sum(total_boleta) from FacturacionElectronica where numero_serie like 'F%'");
            query.Connection = cn;
            object result = query.ExecuteScalar();
            lblFactura.Text = result.ToString();
            cn.Close();

            cn.Open();
            SqlCommand query1 = new SqlCommand("select sum(total_boleta) from FacturacionElectronica where numero_serie like 'B%'");
            query1.Connection = cn;
            object result1 = query1.ExecuteScalar();
            lblBoleta.Text = result1.ToString();
            cn.Close();

            cn.Open();
            SqlCommand query2 = new SqlCommand("select sum(total_boleta) from FacturacionElectronica where codigo_documentoElectronico = '07'");
            query2.Connection = cn;
            object result2 = query2.ExecuteScalar();
            lblTotalCredito.Text = result2.ToString();
            cn.Close();

            cn.Open();
            SqlCommand query3 = new SqlCommand("select sum(total_boleta) from FacturacionElectronica where codigo_documentoElectronico = '08'");
            query3.Connection = cn;
            object result3 = query3.ExecuteScalar();
            lblTotalDebito.Text = result3.ToString();
            cn.Close();


        }

        private void dgFacturacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "estado" &&
                e.RowIndex >= 0 &&
                dgv["estado", e.RowIndex].Value is int)
            {
                switch ((int)dgv["estado", e.RowIndex].Value)
                {
                    case 0:
                        e.Value = "Si";
                        e.FormattingApplied = true;
                        break;

                    case 1:
                        e.Value = "No";
                        e.FormattingApplied = true;
                        break;
                }
            }

            dgFacturacion.Columns[0].HeaderText = "Numero Factura";
            dgFacturacion.Columns[1].HeaderText = "Fecha";
            dgFacturacion.Columns[2].HeaderText = "Tipo";
            dgFacturacion.Columns[3].HeaderText = "Serie";
            dgFacturacion.Columns[4].HeaderText = "Correlativo";
            dgFacturacion.Columns[5].HeaderText = "RUC";
            dgFacturacion.Columns[6].HeaderText = "Razón Social";
            dgFacturacion.Columns[7].HeaderText = "Moneda";
            dgFacturacion.Columns[8].HeaderText = "Total";
            dgFacturacion.Columns[9].HeaderText = "¿Pagado?";

            if (dgFacturacion.CurrentRow.Cells[2].Value.ToString().Equals("07"))
            {
                btnNotaCredito.Enabled = false;
                btnNotaDebito.Enabled = false;
            }

            if (dgFacturacion.CurrentRow.Cells[2].Value.ToString().Equals("08"))
            {
                btnNotaCredito.Enabled = false;
                btnNotaDebito.Enabled = false;
            }

        

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = DateTime.Parse(dtDesde.Text);
            DateTime fecha2 = DateTime.Parse(dtHasta.Text);
            SqlCommand cmd = new SqlCommand("select f.num_factura, f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, c.numero_ruc, c.razon_social,m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc where  f.fecha_emision between'" + fecha1 + "' and '" + fecha2 + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (fecha1 > fecha2)
            {
                MessageBox.Show("La segunda fecha no puede ser menor a la primera");
            }
            else if (dt.Rows.Count > 0)
            {
                dgFacturacion.DataSource = dt;
                btnVolver.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron registros dentro de ese rango de fecha");
                btnVolver.Enabled = false;
            }

            

          
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarFactura inf = new InsertarFactura();
            inf.Closed += (s, args) => this.Close();
            inf.Show();
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarBoleta inb = new InsertarBoleta();
            inb.Closed += (s, args) => this.Close();
            inb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgFacturacion.DataSource = (from f in db.FacturacionElectronica
                                        join m in db.Moneda on f.codigo_moneda equals m.codigo_moneda
                                        join c in db.Cliente on f.numero_ruc equals c.numero_ruc

                                        select new
                                        {
                                            f.num_factura,
                                            f.fecha_emision,
                                            f.codigo_documentoElectronico,
                                            f.numero_serie,
                                            f.numero_correlativo,
                                            f.numero_ruc,
                                            c.razon_social,
                                            m.descripcion_moneda,
                                            f.total_boleta,
                                            f.estado
                                        }).ToList();


            dgFacturacion.Columns[0].HeaderText = "Numero Factura";
            dgFacturacion.Columns[1].HeaderText = "Fecha";
            dgFacturacion.Columns[2].HeaderText = "Tipo";
            dgFacturacion.Columns[3].HeaderText = "Serie";
            dgFacturacion.Columns[4].HeaderText = "Correlativo";
            dgFacturacion.Columns[5].HeaderText = "RUC";
            dgFacturacion.Columns[6].HeaderText = "Razón Social";
            dgFacturacion.Columns[7].HeaderText = "Moneda";
            dgFacturacion.Columns[8].HeaderText = "Total";
            dgFacturacion.Columns[9].HeaderText = "¿Pagado?";

            btnVolver.Enabled = false;
        }

        private void btnNotaCredito_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            InsertarNotaCredito inc = new InsertarNotaCredito();
            inc.Closed += (s, args) => this.Close();
            inc.Show();

            SqlCommand cmd = new SqlCommand("select f.ruc_emisor, f.razon_emisor, f.numero_ruc,f.razon_social, t.descripcion_documento,f.numero_serie,f.numero_correlativo, f.fecha_emision,o.codigo_operacion,o.tipo_operacion, m.codigo_moneda, m.descripcion_moneda, f.tipo_cambio, f.fecha_vencimiento, f.estado, f.exonerada, f.inafecta, f.gravada, f.igv, f.gratuita,f.total_boleta from FacturacionElectronica f inner join Cliente c on f.numero_ruc = c.numero_ruc inner join Tipo_DocumentoElectronico t on f.codigo_documentoElectronico = t.codigo_documentoElectronico inner join Tipo_Operacion o on o.codigo_operacion = f.codigo_operacion inner join Moneda m on f.codigo_moneda = m.codigo_moneda where num_factura = '" + dgFacturacion.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                inc.txtEmisor.Text = dr["ruc_emisor"].ToString();
                inc.txtRazonEmisor.Text = dr["razon_emisor"].ToString();
                inc.txtRucReceptor.Text = dr["numero_ruc"].ToString();
                inc.txtRazonReceptor.Text= dr["razon_social"].ToString();
                inc.txtSerie.Text = dr["numero_serie"].ToString();
                inc.txtCorrelativo.Text = dr["numero_correlativo"].ToString();
                inc.dtEmision.Text = dr["fecha_emision"].ToString();
                inc.txtCodigoOperacion.Text = dr["codigo_operacion"].ToString();
                inc.txtOperacion.Text = dr["tipo_operacion"].ToString();
                inc.txtCodigoMoneda.Text = dr["codigo_moneda"].ToString();
                inc.txtMoneda.Text = dr["descripcion_moneda"].ToString();
                inc.txtCambio.Text = dr["tipo_cambio"].ToString();
                inc.dtVencimiento.Text = dr["fecha_vencimiento"].ToString();
                inc.txtEstado.Text = dr["estado"].ToString();
                inc.txtExonerada.Text = dr["exonerada"].ToString();
                inc.txtInafecta.Text = dr["inafecta"].ToString();
                inc.txtGravada.Text = dr["gravada"].ToString();
                inc.txtIGV.Text = dr["igv"].ToString();
                inc.txtGratuita.Text = dr["gratuita"].ToString();
                inc.txtTotalBoleta.Text = dr["total_boleta"].ToString();
                inc.txtDocumentoModificar.Text = dr["descripcion_documento"].ToString();
                
                inc.txtSerieModificar.Text = dr["numero_serie"].ToString();
                inc.txtCorrelativoModificar.Text = dr["numero_correlativo"].ToString();

            }
            dr.Close();
            cn.Close();

            SqlConnection cn1 = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("select p.codigo_producto, p.descripcion_producto, d.cantidad, i.codigo_tipo_igv, i.tipo_igv,d.valor_unitario,d.subtotal,d.total_producto from DetalleFactura d inner join Productos p on p.codigo_producto = d.codigo_producto inner join Tipo_igv i on d.codigo_tipo_igv = i.codigo_tipo_igv where d.num_factura = '" + dgFacturacion.CurrentRow.Cells[0].Value.ToString() + "'", cn1);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                inc.dgDetalle.DataSource = dt;
              

            }
        }

        
        private void CabeceraReporte()
        {
            dgDetalleFacturacion.Columns[0].HeaderText = "Producto";
            dgDetalleFacturacion.Columns[1].HeaderText = "Cantidad";
            dgDetalleFacturacion.Columns[2].HeaderText = "Tipo IGV";
            dgDetalleFacturacion.Columns[3].HeaderText = "Valor Unitario";
            dgDetalleFacturacion.Columns[4].HeaderText = "Subtotal";
            dgDetalleFacturacion.Columns[5].HeaderText = "Total Producto";
       
        }

   
        private void dgFacturacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select p.descripcion_producto, d.cantidad, i.tipo_igv, d.valor_unitario, d.subtotal, d.total_producto from Productos p inner join DetalleFactura d on p.codigo_producto = d.codigo_producto inner join Tipo_igv i on i.codigo_tipo_igv = d.codigo_tipo_igv where d.num_factura = '" + dgFacturacion.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                dgDetalleFacturacion.DataSource = dt;
                CabeceraReporte();

            }
            else
            {
                MessageBox.Show("No se puede mostrar detalle");
                dgDetalleFacturacion.DataSource = "";
            }
                       

            btnNotaCredito.Enabled = true;
            btnNotaDebito.Enabled = true;
        }

        private void btnNotaDebito_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarNotaDebito inc = new InsertarNotaDebito();
            inc.Closed += (s, args) => this.Close();
            inc.Show();

            SqlCommand cmd = new SqlCommand("select f.ruc_emisor, f.razon_emisor, f.numero_ruc,f.razon_social, t.descripcion_documento,f.numero_serie,f.numero_correlativo, f.fecha_emision,o.codigo_operacion,o.tipo_operacion, m.codigo_moneda, m.descripcion_moneda, f.tipo_cambio, f.fecha_vencimiento, f.estado, f.exonerada, f.inafecta, f.gravada, f.igv, f.gratuita,f.total_boleta from FacturacionElectronica f inner join Cliente c on f.numero_ruc = c.numero_ruc inner join Tipo_DocumentoElectronico t on f.codigo_documentoElectronico = t.codigo_documentoElectronico inner join Tipo_Operacion o on o.codigo_operacion = f.codigo_operacion inner join Moneda m on f.codigo_moneda = m.codigo_moneda where num_factura = '" + dgFacturacion.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                inc.txtEmisor.Text = dr["ruc_emisor"].ToString();
                inc.txtRazonEmisor.Text = dr["razon_emisor"].ToString();
                inc.txtRucReceptor.Text = dr["numero_ruc"].ToString();
                inc.txtRazonReceptor.Text = dr["razon_social"].ToString();
                inc.txtSerie.Text = dr["numero_serie"].ToString();
                inc.txtCorrelativo.Text = dr["numero_correlativo"].ToString();
                inc.dtEmision.Text = dr["fecha_emision"].ToString();
                inc.txtCodigoOperacion.Text = dr["codigo_operacion"].ToString();
                inc.txtOperacion.Text = dr["tipo_operacion"].ToString();
                inc.txtCodigoMoneda.Text = dr["codigo_moneda"].ToString();
                inc.txtMoneda.Text = dr["descripcion_moneda"].ToString();
                inc.txtCambio.Text = dr["tipo_cambio"].ToString();
                inc.dtVencimiento.Text = dr["fecha_vencimiento"].ToString();
                inc.txtEstado.Text = dr["estado"].ToString();
                inc.txtExonerada.Text = dr["exonerada"].ToString();
                inc.txtInafecta.Text = dr["inafecta"].ToString();
                inc.txtGravada.Text = dr["gravada"].ToString();
                inc.txtIGV.Text = dr["igv"].ToString();
                inc.txtGratuita.Text = dr["gratuita"].ToString();
                inc.txtTotalBoleta.Text = dr["total_boleta"].ToString();
                inc.txtDocumentoModificar.Text = dr["descripcion_documento"].ToString();

                inc.txtSerieModificar.Text = dr["numero_serie"].ToString();
                inc.txtCorrelativoModificar.Text = dr["numero_correlativo"].ToString();

            }
            dr.Close();
            cn.Close();

            SqlConnection cn1 = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("select p.codigo_producto, p.descripcion_producto, d.cantidad, i.codigo_tipo_igv, i.tipo_igv,d.valor_unitario,d.subtotal,d.total_producto from DetalleFactura d inner join Productos p on p.codigo_producto = d.codigo_producto inner join Tipo_igv i on d.codigo_tipo_igv = i.codigo_tipo_igv where d.num_factura = '" + dgFacturacion.CurrentRow.Cells[0].Value.ToString() + "'", cn1);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                inc.dgDetalle.DataSource = dt;


            }
        }

        private void dgFacturacion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgFacturacion.ClearSelection();
        }
    }
}
