using DGVPrinterHelper;
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
    public partial class Consulta : Form
    {
        FactronLCTEntities db = new FactronLCTEntities();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");
        public Consulta()
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

        private void cboSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSeleccion.SelectedIndex == 0)
            {
                btnBuscar.Enabled = true;
                dtDesde.Enabled = true;
                dtHasta.Enabled = true;
                dgConsulta.DataSource = null;
                dgConsulta.Rows.Clear();

            }
            if(cboSeleccion.SelectedIndex == 1)
            {
                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                dgConsulta.DataSource = null;
                dgConsulta.Rows.Clear();
                btnImprimir.Enabled = false;
                btnExportar.Enabled = false;
            }
            if (cboSeleccion.SelectedIndex == 2)
            {
                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                dgConsulta.DataSource = null;
                dgConsulta.Rows.Clear();
                btnImprimir.Enabled = false;
                btnExportar.Enabled = false;
            }
            if (cboSeleccion.SelectedIndex == 3)
            {
                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                dgConsulta.DataSource = null;
                dgConsulta.Rows.Clear();
                btnImprimir.Enabled = false;
                btnExportar.Enabled = false;
            }
            if (cboSeleccion.SelectedIndex == 4)
            {
                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                dgConsulta.DataSource = null;
                dgConsulta.Rows.Clear();
                btnImprimir.Enabled = false;
                btnExportar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            if(cboSeleccion.SelectedIndex == 0)
            {
                btnImprimir.Enabled = false;
                btnExportar.Enabled = false;
                btnBuscar.Enabled = true;
                dtDesde.Enabled = true;
                dtHasta.Enabled = true;
                DateTime fecha1 = DateTime.Parse(dtDesde.Text);
                DateTime fecha2 = DateTime.Parse(dtHasta.Text);
                SqlCommand cmd = new SqlCommand("select f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, f.numero_ruc, c.razon_social, m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc where  f.fecha_emision between'" + fecha1 + "' and '" + fecha2 + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    dgConsulta.DataSource = dt;
                    CabeceraReporte();
                    btnExportar.Enabled = true;
                    btnImprimir.Enabled = true;

                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            if (cboSeleccion.SelectedIndex == 1)
            {
            
                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                DateTime fecha1 = DateTime.Parse(dtDesde.Text);
                DateTime fecha2 = DateTime.Parse(dtHasta.Text);
                SqlCommand cmd = new SqlCommand("select f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, f.numero_ruc, c.razon_social, m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc where numero_serie like 'F%'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                 
                    dgConsulta.DataSource = dt;
                    CabeceraReporte();
                    btnExportar.Enabled = true;
                    btnImprimir.Enabled = true;

                }
                else
                {
                    MessageBox.Show("No se encontraron facturas");
                }
            }
            if (cboSeleccion.SelectedIndex == 2)
            {
            
                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                DateTime fecha1 = DateTime.Parse(dtDesde.Text);
                DateTime fecha2 = DateTime.Parse(dtHasta.Text);
                SqlCommand cmd = new SqlCommand("select f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, f.numero_ruc, c.razon_social, m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc where numero_serie like 'B%'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    dgConsulta.DataSource = dt;
                    CabeceraReporte();
                    btnExportar.Enabled = true;
                    btnImprimir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron boletas");
                }
            }
            if (cboSeleccion.SelectedIndex == 3)
            {
           
                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                DateTime fecha1 = DateTime.Parse(dtDesde.Text);
                DateTime fecha2 = DateTime.Parse(dtHasta.Text);
                SqlCommand cmd = new SqlCommand(" select f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, f.numero_ruc, c.razon_social, m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc where f.codigo_documentoElectronico = '07'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    dgConsulta.DataSource = dt;
                    CabeceraReporte();
                    btnExportar.Enabled = true;
                    btnImprimir.Enabled = true;

                }
                else
                {
                    MessageBox.Show("No se encontraron notas de credito");
                }
            }
            else
            {

                btnBuscar.Enabled = true;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                DateTime fecha1 = DateTime.Parse(dtDesde.Text);
                DateTime fecha2 = DateTime.Parse(dtHasta.Text);
                SqlCommand cmd = new SqlCommand(" select f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, f.numero_ruc, c.razon_social, m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc where f.codigo_documentoElectronico = '08'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    dgConsulta.DataSource = dt;
                    CabeceraReporte();
                    btnExportar.Enabled = true;
                    btnImprimir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron notas de debito");
                }
            }
        }

        private void dgConsulta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
        }

       private void CabeceraReporte()
        {
            dgConsulta.Columns[0].HeaderText = "Fecha";
            dgConsulta.Columns[1].HeaderText = "Tipo";
            dgConsulta.Columns[2].HeaderText = "Serie";
            dgConsulta.Columns[3].HeaderText = "Correlativo";
            dgConsulta.Columns[4].HeaderText = "RUC";
            dgConsulta.Columns[5].HeaderText = "Razón Social";
            dgConsulta.Columns[6].HeaderText = "Moneda";
            dgConsulta.Columns[7].HeaderText = "Total";
            dgConsulta.Columns[8].HeaderText = "¿Pagado?";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte de consulta";
            printer.SubTitle = string.Format("Fecha: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Logistica Contable y Tributaria S.A.C";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dgConsulta);
           


        }

        private void dgConsulta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgConsulta.ClearSelection();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
            btnExportar.Enabled = false;
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgConsulta.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgConsulta.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgConsulta.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgConsulta.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
