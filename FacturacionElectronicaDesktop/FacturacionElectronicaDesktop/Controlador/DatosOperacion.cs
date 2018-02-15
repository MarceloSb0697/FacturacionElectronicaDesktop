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
    public class DatosOperacion
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<TipoOperacion> ListadoOperaciones()
        {
            List<TipoOperacion> listadoOperaciones = new List<TipoOperacion>();
            SqlCommand cmd = new SqlCommand("select * from Tipo_Operacion", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TipoOperacion to = new TipoOperacion();
                to.CodigoOperacion = dr["codigo_operacion"].ToString();
                to.Tipo_Operacion = dr["tipo_operacion"].ToString();
                listadoOperaciones.Add(to);
            }
            dr.Close();
            cn.Close();

            return listadoOperaciones;
        }
    }
}
