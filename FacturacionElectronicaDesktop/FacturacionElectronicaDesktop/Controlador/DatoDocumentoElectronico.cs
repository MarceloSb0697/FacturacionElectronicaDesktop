using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DatoDocumentoElectronico
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<TipoDocumentoElectronico> ListadoTipoDocumento()
        {
            List<TipoDocumentoElectronico> listadoDocumento = new List<TipoDocumentoElectronico>();
            SqlCommand cmd = new SqlCommand("select * from Tipo_DocumentoElectronico where codigo_documentoElectronico = '01'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TipoDocumentoElectronico td = new TipoDocumentoElectronico();
                td.CodigoDocumentElectronico = dr["codigo_documentoElectronico"].ToString();
                td.DescripcionDocumentoElectronico = dr["descripcion_documento"].ToString();
                listadoDocumento.Add(td);
            }
            dr.Close();
            cn.Close();

            return listadoDocumento;
        }
    }
}
