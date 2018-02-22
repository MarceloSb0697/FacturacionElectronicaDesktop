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

namespace FacturacionElectronicaDesktop.Vista
{
    public partial class Ventas : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

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


            dgFacturacion.Columns[0].HeaderText = "Fecha";
            dgFacturacion.Columns[1].HeaderText = "Tipo";
            dgFacturacion.Columns[2].HeaderText = "Serie";
            dgFacturacion.Columns[3].HeaderText = "Correlativo";
            dgFacturacion.Columns[4].HeaderText = "RUC";
            dgFacturacion.Columns[5].HeaderText = "Razón Social";
            dgFacturacion.Columns[6].HeaderText = "Moneda";
            dgFacturacion.Columns[7].HeaderText = "Total";
            dgFacturacion.Columns[8].HeaderText = "¿Pagado?";

            btnVolver.Enabled = false;

           
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

            dgFacturacion.Columns[0].HeaderText = "Fecha";
            dgFacturacion.Columns[1].HeaderText = "Tipo";
            dgFacturacion.Columns[2].HeaderText = "Serie";
            dgFacturacion.Columns[3].HeaderText = "Correlativo";
            dgFacturacion.Columns[4].HeaderText = "RUC";
            dgFacturacion.Columns[5].HeaderText = "Razón Social";
            dgFacturacion.Columns[6].HeaderText = "Moneda";
            dgFacturacion.Columns[7].HeaderText = "Total";
            dgFacturacion.Columns[8].HeaderText = "¿Pagado?";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = DateTime.Parse(dtDesde.Text);
            DateTime fecha2 = DateTime.Parse(dtHasta.Text);
            SqlCommand cmd = new SqlCommand("select f.num_factura, f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, f.numero_ruc, m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc where  f.fecha_emision between'" + fecha1 + "' and '" + fecha2 + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgFacturacion.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No se encontraron registros dentro de ese rango de fecha");
            }

            btnVolver.Enabled = true;
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


            dgFacturacion.Columns[0].HeaderText = "Fecha";
            dgFacturacion.Columns[1].HeaderText = "Tipo";
            dgFacturacion.Columns[2].HeaderText = "Serie";
            dgFacturacion.Columns[3].HeaderText = "Correlativo";
            dgFacturacion.Columns[4].HeaderText = "RUC";
            dgFacturacion.Columns[5].HeaderText = "Razón Social";
            dgFacturacion.Columns[6].HeaderText = "Moneda";
            dgFacturacion.Columns[7].HeaderText = "Total";
            dgFacturacion.Columns[8].HeaderText = "¿Pagado?";

            btnVolver.Enabled = false;
        }
    }
}
