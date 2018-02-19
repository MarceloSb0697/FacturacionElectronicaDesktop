using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FacturacionElectronicaDesktop.Vista;

namespace FacturacionElectronicaDesktop
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=FactronLCT;Integrated Security=True");
            cn.Open();
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select * from Usuarios where usuario = '"+ usuario +"' and password = '"+ password +"'",cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Index i = new Index();
                i.Closed += (s, args) => this.Close();
                i.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos");
            }
            cn.Close();
        }
    }
}
