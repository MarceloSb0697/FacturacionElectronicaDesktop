using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Controlador
{
    public class DatosNotaDebito
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<NotaDebito> ListadoNotaDebito()
        {
            List<NotaDebito> listadoDocumento = new List<NotaDebito>();
            SqlCommand cmd = new SqlCommand("select * from Tipo_NotaDebito", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NotaDebito nc = new NotaDebito();
                nc.CodigoNotaDebito = dr["codigo_TipoDebito"].ToString();
                nc.DescripcionNotaDebito = dr["descripcion_Tipo"].ToString();
                listadoDocumento.Add(nc);
            }
            dr.Close();
            cn.Close();

            return listadoDocumento;
        }
    }
}
