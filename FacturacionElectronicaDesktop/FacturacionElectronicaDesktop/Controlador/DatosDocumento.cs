using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturacionElectronicaDesktop.Entidades;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosDocumento
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<Documento> ListadoDocumento()
        {
            List<Documento> listadoDocumento = new List<Documento>();
            SqlCommand cmd = new SqlCommand("select * from Documento;", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Documento d = new Documento();
                d.CodigoDocumento = dr["codigo_documento"].ToString();
                d.TipoDocumento = dr["tipo_documento"].ToString();
                listadoDocumento.Add(d);
            }
            dr.Close();
            cn.Close();

            return listadoDocumento;
        }
    }
}
