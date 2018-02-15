using FacturacionElectronicaDesktop.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosClientes
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<Cliente> ListadoCliente()
        {
            List<Cliente> listadoClientes = new List<Cliente>();
            SqlCommand cmd = new SqlCommand("select d.tipo_documento, c.numero_ruc, c.razon_social, c.direccion,c.email,c.telef_fijo,c.telef_movil from Documento d inner join Cliente c on c.codigo_documento = d.codigo_documento", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente c = new Cliente();
                c.CodigoDocumento = dr["tipo_documento"].ToString();
                c.NumeroRuc = dr["numero_ruc"].ToString();
                c.RazonSocial = dr["razon_social"].ToString();
                c.Direccion = dr["direccion"].ToString();
                c.Email = dr["email"].ToString();
                c.TelefonoFijo = dr["telef_fijo"].ToString();
                c.TelefonoMovil = dr["telef_movil"].ToString();
                listadoClientes.Add(c);
            }
            dr.Close();
            cn.Close();

            return listadoClientes;
        }

        public string ModificarCliente(Cliente objC)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("ActualizarCliente", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod_doc", objC.CodigoDocumento);
                cmd.Parameters.AddWithValue("@raz_soc", objC.RazonSocial);
                cmd.Parameters.AddWithValue("@dir", objC.Direccion);
                cmd.Parameters.AddWithValue("@email", objC.Email);
                cmd.Parameters.AddWithValue("@tel_mov", objC.TelefonoMovil);
                cmd.Parameters.AddWithValue("@tel_fijo", objC.TelefonoFijo);
                cmd.Parameters.AddWithValue("@num_ruc", objC.NumeroRuc);

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

        public List<Cliente> ListarTablaCliente()
        {
            List<Cliente> listadoClientes = new List<Cliente>();
            SqlCommand cmd = new SqlCommand("select * from Cliente", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente c = new Cliente();
                c.NumeroRuc = dr["numero_ruc"].ToString();
                c.CodigoDocumento = dr["codigo_documento"].ToString();
                c.RazonSocial = dr["razon_social"].ToString();
                c.Direccion = dr["direccion"].ToString();
                c.Email = dr["email"].ToString();
                c.TelefonoMovil = dr["telef_movil"].ToString();
                c.TelefonoFijo = dr["telef_fijo"].ToString();
                listadoClientes.Add(c);
            }
            dr.Close();
            cn.Close();

            return listadoClientes;
        }

        public string InsertarClientes(Cliente objC)
        {
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Cliente values(@num_ruc,@cod_doc,@raz_soc,@dir,@email,@tel_mov,@tel_fijo)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@num_ruc", objC.NumeroRuc);
                cmd.Parameters.AddWithValue("@cod_doc", objC.CodigoDocumento);
                cmd.Parameters.AddWithValue("@raz_soc", objC.RazonSocial);
                cmd.Parameters.AddWithValue("@dir", objC.Direccion);
                cmd.Parameters.AddWithValue("@email", objC.Email);
                cmd.Parameters.AddWithValue("@tel_mov", objC.TelefonoMovil);
                cmd.Parameters.AddWithValue("@tel_fijo", objC.TelefonoFijo);

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

        public string EliminarClientes(Cliente objC)
        {
           string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("delete from Cliente where numero_ruc = @num_ruc", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@num_ruc", objC.NumeroRuc);
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

        public Cliente BuscarCliente(string ruc)
        {
            return ListarTablaCliente().Where(c => c.NumeroRuc == ruc).FirstOrDefault();
        }
  
    }
}
