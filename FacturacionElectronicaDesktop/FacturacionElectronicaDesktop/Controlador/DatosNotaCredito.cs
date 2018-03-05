using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Controlador
{
    public class DatosNotaCredito
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<NotaCredito> ListadoNotaCredito()
        {
            List<NotaCredito> listadoDocumento = new List<NotaCredito>();
            SqlCommand cmd = new SqlCommand("select * from Tipo_NotaCredito", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NotaCredito nc = new NotaCredito();
                nc.CodigoNotaCredito = dr["codigo_TipoCredito"].ToString();
                nc.DescripcionNotaCredito = dr["descripcion_Tipo"].ToString();
                listadoDocumento.Add(nc);
            }
            dr.Close();
            cn.Close();

            return listadoDocumento;
        }

    }
}
