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
    public partial class ResumenBoleta : Form
    {
        public ResumenBoleta()
        {
            InitializeComponent();
        }
        FactronLCTEntities db = new FactronLCTEntities();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select f.fecha_emision, t.descripcion_documento, f.numero_serie, f.numero_correlativo,f.numero_ruc, m.descripcion_moneda, f.total_boleta from FacturacionElectronica f inner join Tipo_DocumentoElectronico t on f.codigo_documentoElectronico = t.codigo_documentoElectronico inner join Moneda m on m.codigo_moneda = f.codigo_moneda where f.fecha_emision = '" + dgResumen.CurrentRow.Cells[0].Value.ToString() + "' and f.codigo_documentoElectronico = '07' or f.fecha_emision = '" + dgResumen.CurrentRow.Cells[0].Value.ToString() + "' and f.codigo_documentoElectronico = '08'  ", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        this.Hide();
                        DetalleResumen i = new DetalleResumen();
                        i.Closed += (s, args) => this.Close();
                        i.Show();

                        i.dgDetalleResumen.DataSource = dt;

                        i.dgDetalleResumen.Columns[0].HeaderText = "Fecha de Emision";
                        i.dgDetalleResumen.Columns[1].HeaderText = "Documento";
                        i.dgDetalleResumen.Columns[2].HeaderText = "Serie";
                        i.dgDetalleResumen.Columns[3].HeaderText = "Correlativo";
                        i.dgDetalleResumen.Columns[4].HeaderText = "RUC";
                        i.dgDetalleResumen.Columns[5].HeaderText = "Moneda";
                        i.dgDetalleResumen.Columns[6].HeaderText = "Total Boleta";


                    }

                } catch(Exception ex)
                {
                    MessageBox.Show("No existen registros en esa fecha");
                }
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index i = new Index();
            i.Closed += (s, args) => this.Close();
            i.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string q = "insert into ResumenBoleta(fecha_generacion,fecha_emision) values (GETDATE(),GETDATE())";
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.ExecuteNonQuery();
            cn.Close();

            SqlCommand cmd1 = new SqlCommand("select distinct fecha_emision, fecha_generacion from ResumenBoleta", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                dgResumen.DataSource = dt;
                btnInsertar.Enabled = false;


            }


        }

        private void ResumenBoleta_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select distinct fecha_emision, fecha_generacion from ResumenBoleta", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                dgResumen.DataSource = dt;
                btnInsertar.Enabled = true;


            }

            dgResumen.Columns[0].HeaderText = "Fecha de Emision";
            dgResumen.Columns[1].HeaderText = "Fecha de generacion";

            dgResumen.Columns[0].Width = 160;
            dgResumen.Columns[1].Width = 160;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgResumen.Columns.Add(btn);
            btn.HeaderText = "Documento";
            btn.Width = 160;
            btn.Text = "Ver documentos";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void dgResumen_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgResumen.ClearSelection();
        }
    }
}
