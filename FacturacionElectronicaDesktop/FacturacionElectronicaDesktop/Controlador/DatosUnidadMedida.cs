using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FacturacionElectronicaDesktop.Entidades;

namespace CapaDatos
{
    public class DatosUnidadMedida
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<UnidadMedida> ListadoUnidades()
        {
            List<UnidadMedida> listadoUnidades = new List<UnidadMedida>();
            SqlCommand cmd = new SqlCommand("select * from Unidad_Medida order by descripcion_unidad asc;", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UnidadMedida u = new UnidadMedida();
                u.CodigoUnidadMedida = dr["codigo_unidad"].ToString();
                u.DescripcionUnidadMedida = dr["descripcion_unidad"].ToString();
                listadoUnidades.Add(u);
            }
            dr.Close();
            cn.Close();

            return listadoUnidades;
        }

        public string ModificarUnidad(UnidadMedida objM)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("Update Unidad_Medida set descripcion_unidad=@des where codigo_unidad=@cod_uni", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@des", objM.DescripcionUnidadMedida);
                cmd.Parameters.AddWithValue("@cod_uni", objM.CodigoUnidadMedida);

                int cantidad = cmd.ExecuteNonQuery();
                mensaje = cantidad.ToString() + "Registros modificados";
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

        public string InsertarUnidad(UnidadMedida objM)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Unidad_Medida values(@cod_uni,@des)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@cod_uni", objM.CodigoUnidadMedida);
                cmd.Parameters.AddWithValue("@des", objM.DescripcionUnidadMedida);

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

        public string EliminarUnidad(UnidadMedida objM)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("delete from Unidad_Medida where codigo_unidad=@cod_uni", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@cod_uni", objM.CodigoUnidadMedida);

                int cantidad = cmd.ExecuteNonQuery();
                mensaje = cantidad.ToString() + "Registros eliminados";
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

        public UnidadMedida BuscarUnidad(string codigoUnidad)
        {
            return ListadoUnidades().Where(u => u.CodigoUnidadMedida == codigoUnidad).FirstOrDefault();
        }
    }
}
