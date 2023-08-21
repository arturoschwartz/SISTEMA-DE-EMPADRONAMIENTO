using pregistro.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace pregistro.Formas
{
    public partial class Frmbaja : Form
    {
        clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        
        
        
        public Frmbaja()
        {
            InitializeComponent();
        }

        private void txtplaca3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                objconexion = new clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "select * from matricula where vi_Numero=@vi_Numero";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@vi_Nombre", txtnombre2.Text);
                comando.Parameters.AddWithValue("@vi_Domicilio", txtdireccion2.Text);
                comando.Parameters.AddWithValue("@vi_Telefono", txttelefono2.Text);
                comando.Parameters.AddWithValue("@vi_Registro", txtregistro2.Text);
                comando.Parameters.AddWithValue("@vi_Vencimiento", txtvencimiento2.Text);
                comando.Parameters.AddWithValue("@vi_Marca", txtmarca2.Text);
                comando.Parameters.AddWithValue("@vi_Modelo", txtmodelo2.Text);
                comando.Parameters.AddWithValue("@vi_Linea", txtlinea2.Text);
                comando.Parameters.AddWithValue("@vi_Color", txtcolor2.Text);
                comando.Parameters.AddWithValue("@vi_Numero", txtplaca3.Text);
                comando.Parameters.AddWithValue("@vi_Oficina", txtregistro.Text);
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtnombre2.Text = leer["vi_Nombre"].ToString();
                    txtdireccion2.Text = leer["vi_Domicilio"].ToString();
                    txttelefono2.Text = leer["vi_Telefono"].ToString();
                    txtregistro2.Text = leer["vi_Registro"].ToString();
                    txtvencimiento2.Text = leer["vi_Vencimiento"].ToString();
                    txtmarca2.Text = leer["vi_Marca"].ToString();
                    txtmodelo2.Text = leer["vi_Modelo"].ToString();
                    txtlinea2.Text = leer["vi_Linea"].ToString();
                    txtcolor2.Text = leer["vi_Color"].ToString();
                    txtregistro.Text = leer["vi_Oficina"].ToString();
               
                }
                conexion.Close();
            }
            
        }

        private void btninicio2_Click(object sender, EventArgs e)
        {
            Formas.Frmlogin x = new Formas.Frmlogin();
            x.Show();
            this.Hide();
        }

        private void btnbaja2_Click(object sender, EventArgs e)
        {
            objconexion = new clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            //se abre la conexion
            conexion.Open();
            string query = "Delete  matricula  where vi_Numero=@vi_Numero";
            //asigo a comando el sql command
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@vi_Numero", txtplaca3.Text);
            

            if (MessageBox.Show("Seguro que quiere eliminar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("La matricula fue dada de baja con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            conexion.Close();
        }
        
    }
}   
