using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacturacionElectronicaDesktop.Modelo.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DatosProductos
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<Productos> ListadoProductos()
        {
            List<Productos> listadoProductos = new List<Productos>();
            SqlCommand cmd = new SqlCommand("select u.descripcion_unidad, p.codigo_producto,p.descripcion_producto, m.descripcion_moneda, p.valor_unitario, p.precio_unitario from Unidad_Medida u inner join Productos p on u.codigo_unidad = p.codigo_unidad inner join Moneda m on p.codigo_moneda = m.codigo_moneda ", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Productos p = new Productos();
                p.CodigoUnidadMedida = dr["descripcion_unidad"].ToString();
                p.CodigoProducto = dr["codigo_producto"].ToString();
                p.DescripcionProducto = dr["descripcion_producto"].ToString();
                p.CodigoMoneda = dr["descripcion_moneda"].ToString();
                p.ValorUnitario = dr["valor_unitario"].ToString();
                p.PrecioUnitario = dr["precio_unitario"].ToString();
                listadoProductos.Add(p);
            }
            dr.Close();
            cn.Close();

            return listadoProductos;
        }

        public string InsertarProductos(Productos objP)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Productos values(@cod_tipo,@cod_pro,@des_pro,@cod_mon,@val,@pre)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@cod_tipo", objP.CodigoUnidadMedida);
                cmd.Parameters.AddWithValue("@cod_pro", objP.CodigoProducto);
                cmd.Parameters.AddWithValue("@des_pro", objP.DescripcionProducto);
                cmd.Parameters.AddWithValue("@cod_mon", objP.CodigoMoneda);
                cmd.Parameters.AddWithValue("@val", objP.ValorUnitario);
                cmd.Parameters.AddWithValue("@pre", objP.PrecioUnitario);

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

        public string ModificarProductos(Productos objP)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("ActualizarProductos", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod_tipo", objP.CodigoUnidadMedida);
                cmd.Parameters.AddWithValue("@des_pro", objP.DescripcionProducto);
                cmd.Parameters.AddWithValue("@cod_mon", objP.CodigoMoneda);
                cmd.Parameters.AddWithValue("@val", objP.ValorUnitario);
                cmd.Parameters.AddWithValue("@pre", objP.PrecioUnitario);
                cmd.Parameters.AddWithValue("@cod_pro", objP.CodigoProducto);

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

        public string EliminarProductos(Productos objP)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("delete from Productos where codigo_producto = @cod_pro", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@cod_pro", objP.CodigoProducto);
                int cantidad = cmd.ExecuteNonQuery();
                mensaje = cantidad.ToString() + "Registros eliminado";
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


        public List<Productos> ListadoTablaProductos()
        {
            List<Productos> listadoProductos = new List<Productos>();
            SqlCommand cmd = new SqlCommand("select * from Productos", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Productos p = new Productos();
                p.CodigoUnidadMedida = dr["codigo_unidad"].ToString();
                p.CodigoProducto = dr["codigo_producto"].ToString();
                p.DescripcionProducto = dr["descripcion_producto"].ToString();
                p.CodigoMoneda = dr["codigo_moneda"].ToString();
                p.ValorUnitario =dr["valor_unitario"].ToString();
                p.PrecioUnitario = dr["precio_unitario"].ToString();
                listadoProductos.Add(p);
            }
            dr.Close();
            cn.Close();

            return listadoProductos;
        }


        public Productos BuscarProductos(string codigoProducto)
        {
            return ListadoTablaProductos().Where(p => p.CodigoProducto == codigoProducto).FirstOrDefault();
        }

        public List<Productos> ListadoPorNombre(string nombreProducto)
        {
            return ListadoProductos().Where(p => p.DescripcionProducto.ToLower().Contains(nombreProducto)).ToList();
        }

        public bool ConsultarValorUnitario(Productos objProducto)
        {
            bool hayRegistros;
            string find = "select valor_unitario from Productos where codigo_producto='" + objProducto.CodigoProducto + "'";
            try
            {
                SqlCommand comando = new SqlCommand(find, cn);
                cn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                hayRegistros = reader.Read();
                if (hayRegistros)
                {
                    objProducto.ValorUnitario = reader["valor_unitario"].ToString();

                }
                else
                {
                   
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
                
            }

            return hayRegistros;
        }

        

    }
}
