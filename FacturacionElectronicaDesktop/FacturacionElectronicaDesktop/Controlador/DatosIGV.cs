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
    public class DatosIGV
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<TipoIGV> ListadoIGV()
        {
            List<TipoIGV> listadoIGV = new List<TipoIGV>();
            SqlCommand cmd = new SqlCommand("select * from Tipo_igv", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TipoIGV ti = new TipoIGV();
                ti.CodigoTipoIGV = dr["codigo_tipo_igv"].ToString();
                ti.Tipo_IGV = dr["tipo_igv"].ToString();
                listadoIGV.Add(ti);
            }
            dr.Close();
            cn.Close();

            return listadoIGV;
        }
    }
}
