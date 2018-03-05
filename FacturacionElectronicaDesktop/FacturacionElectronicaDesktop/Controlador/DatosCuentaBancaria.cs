using FacturacionElectronicaDesktop.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionElectronicaDesktop.Controlador
{
    public class DatosCuentaBancaria
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");

        public List<FacturacionElectronicaDesktop.Modelo.Entidades.TipoCuentaBancaria> ListadoTipoCuenta()
        {
            List<FacturacionElectronicaDesktop.Modelo.Entidades.TipoCuentaBancaria> listadoCuenta = new List<FacturacionElectronicaDesktop.Modelo.Entidades.TipoCuentaBancaria>();
            SqlCommand cmd = new SqlCommand("select * from TipoCuentaBancaria", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                FacturacionElectronicaDesktop.Modelo.Entidades.TipoCuentaBancaria td = new FacturacionElectronicaDesktop.Modelo.Entidades.TipoCuentaBancaria();
                td.IdTipoCuenta = dr["id_tipo"].ToString();
                td.DescripcionTipoCuenta = dr["descripcion_tipo"].ToString();
                listadoCuenta.Add(td);
            }
            dr.Close();
            cn.Close();

            return listadoCuenta;
        }

       
          
    }
}
