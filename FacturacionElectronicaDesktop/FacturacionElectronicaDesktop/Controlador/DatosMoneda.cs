using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosMoneda
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<Moneda> ListadoMonedas()
        {
            List<Moneda> listadoMonedas = new List<Moneda>();
            SqlCommand cmd = new SqlCommand("select * from Moneda", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Moneda m = new Moneda();
                m.CodigoMoneda = dr["codigo_moneda"].ToString();
                m.DescripcionMoneda = dr["descripcion_moneda"].ToString();
                listadoMonedas.Add(m);
            }
            dr.Close();
            cn.Close();

            return listadoMonedas;
        }
    }
}
