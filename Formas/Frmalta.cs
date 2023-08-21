using pregistro.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace pregistro.Formas
{
    public partial class Frmalta : Form
    {
        clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        public Frmalta()
        {
            InitializeComponent();
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            if (existe == 0) 
            {
                objconexion = new clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "insert into matricula values (@vi_Nombre, @vi_Domicilio, @vi_Telefono, @vi_Registro, @vi_Vencimiento, @vi_Marca, @vi_Modelo, @vi_Linea, @vi_Color, @vi_Numero, @vi_Oficina)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@vi_Nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@vi_Domicilio", this.txtdireccion.Text);
                comando.Parameters.AddWithValue("@vi_Telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@vi_Registro", this.txtregistro.Text);
                comando.Parameters.AddWithValue("@vi_Vencimiento", this.txtvencimiento.Text);
                comando.Parameters.AddWithValue("@vi_Marca", this.txtmarca.Text);
                comando.Parameters.AddWithValue("@vi_Modelo", this.txtmodelo.Text);
                comando.Parameters.AddWithValue("@vi_Linea", this.txtlinea.Text);
                comando.Parameters.AddWithValue("@vi_Color", this.txtcolor.Text);
                comando.Parameters.AddWithValue("@vi_Numero", this.txtplaca.Text);
                comando.Parameters.AddWithValue("@vi_Oficina", this.cboxoficina.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("REGISTRO EXITOSO", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnombre.Clear();
                txtdireccion.Clear();
                txttelefono.Clear();
                txtregistro.Clear();
                txtvencimiento.Clear();
                txtmarca.Clear();
                txtmodelo.Clear();
                txtlinea.Clear();
                txtcolor.Clear();
                txtplaca.Clear();
                txtregistro.Clear();
                txtnombre.Focus();
            }
            conexion.Close();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Formas.Frmlogin x = new Formas.Frmlogin();
            x.Show();
            this.Hide();
        }

        private void cboxoficina_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from matricula";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxoficina.DataSource = dt;
            //defino los campos de la tabla
            this.cboxoficina.ValueMember = "vi_Oficina";
            //cierro conexion
            conexion.Close();
        }
    }
}
