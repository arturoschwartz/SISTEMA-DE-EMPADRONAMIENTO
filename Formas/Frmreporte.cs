using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregistro.Formas
{
    public partial class Frmreporte : Form
    {
        public Frmreporte()
        {
            InitializeComponent();
        }

        private void Frmreporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vehiculosDataSet.matricula' Puede moverla o quitarla según sea necesario.
            this.matriculaTableAdapter.Fill(this.vehiculosDataSet.matricula);

        }
    }
}
