using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturacionElectronicaDesktop.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DatosFactura
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<FacturacionElectronica> ListadoFacturas()
        {
            List<FacturacionElectronica> listaFacturas = new List<FacturacionElectronica>();
            SqlCommand cmd = new SqlCommand("select f.num_factura, f.fecha_emision,f.codigo_documentoElectronico,f.numero_serie,f.numero_correlativo, f.numero_ruc, m.descripcion_moneda, f.total_boleta, f.estado from FacturacionElectronica f inner join Moneda m on f.codigo_moneda = m.codigo_moneda inner join Cliente c on f.numero_ruc = c.numero_ruc", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                FacturacionElectronica f = new FacturacionElectronica();
                Cliente c = new Cliente();
                f.NumeroFactura = Int32.Parse(dr["num_factura"].ToString());
                f.FechaEmision = DateTime.Parse(dr["fecha_emision"].ToString());
                f.CodigoDocumentElectronico = dr["codigo_documentoElectronico"].ToString();
                f.NumeroSerie = dr["numero_serie"].ToString();
                f.NumeroCorrelativo = dr["numero_correlativo"].ToString();
                f.NumeroRuc = dr["numero_ruc"].ToString();
                f.CodigoMoneda = dr["descripcion_moneda"].ToString();
                f.TotalBoleta = dr["total_boleta"].ToString();
                f.Estado = dr["estado"].ToString();
                listaFacturas.Add(f);
            }
            dr.Close();
            cn.Close();

            return listaFacturas;
        }

        public List<FacturacionElectronica> FiltroPorFechas(DateTime fecha1, DateTime fecha2)
        {
            return ListadoFacturas().Where(f => Convert.ToDateTime(f.FechaEmision) >= fecha1 && Convert.ToDateTime(f.FechaEmision) <= fecha2).ToList();
        }

        public string InsertarFactura(FacturacionElectronica objF)
        {
            string mensaje = "";
            string numerofac = "";
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarFactura", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_ruc", objF.NumeroRuc);
                cmd.Parameters.AddWithValue("@cod_doc", objF.CodigoDocumentElectronico);
                cmd.Parameters.AddWithValue("@num_serie", objF.NumeroSerie);
                cmd.Parameters.AddWithValue("@num_cor", objF.NumeroCorrelativo);
                cmd.Parameters.AddWithValue("@fec_em", objF.FechaEmision);
                cmd.Parameters.AddWithValue("@cod_op", objF.CodigoOperacion);
                cmd.Parameters.AddWithValue("@cod_mon", objF.CodigoMoneda);
                cmd.Parameters.AddWithValue("@tipo", objF.TipoCambio);
                cmd.Parameters.AddWithValue("@fec_ven", objF.FechaVencimiento);
                cmd.Parameters.AddWithValue("@estado", objF.Estado);
                cmd.Parameters.AddWithValue("@exo", objF.Exonerada);
                cmd.Parameters.AddWithValue("@inf", objF.Inafecta);
                cmd.Parameters.AddWithValue("@gra", objF.Gravada);
                cmd.Parameters.AddWithValue("@igv", objF.IGV);
                cmd.Parameters.AddWithValue("@gratuita", objF.Gratuita);
                cmd.Parameters.AddWithValue("@tot_bol", objF.TotalBoleta);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    numerofac = reader[0].ToString();
                }
            }
            catch (SqlException e)
            {
                mensaje = e.Message;
            }
            finally
            {
                cn.Close();
            }

            return numerofac;

        }

        public string InsertarDetalle(DetalleFactura objD)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarDetalle", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@num_fac", objD.NumeroFactura);
                cmd.Parameters.AddWithValue("@cod_pro", objD.CodigoProducto);
                cmd.Parameters.AddWithValue("@cantidad", objD.Cantidad);
                cmd.Parameters.AddWithValue("@tipo_igv", objD.CodigoTipoIGV);
                cmd.Parameters.AddWithValue("@valor", objD.ValorUnitario);
                cmd.Parameters.AddWithValue("@subtotal", objD.Subtotal);
                cmd.Parameters.AddWithValue("@tot_pro", objD.TotalProducto);

                int cantidad = cmd.ExecuteNonQuery();
                mensaje = cantidad.ToString() + "Registros agregados";
            }
            catch (SqlException e)
            {
                mensaje = e.Message;
            }
            finally
            {
                cn.Close();
            }

            return mensaje;

        }


    }

}
