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

namespace pregistro.Formas
{
    public partial class Frmlogin : Form
    {
        
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            Formas.Frmalta x = new Formas.Frmalta();
            x.Show();
            this.Hide();
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            Formas.Frmbaja x = new Formas.Frmbaja();
            x.Show();
            this.Hide();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            Formas.Frmreporte x = new Formas.Frmreporte();
            x.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
