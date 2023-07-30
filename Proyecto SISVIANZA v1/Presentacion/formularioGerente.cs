using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion
{
    public partial class formularioGerente : Form
    {
        public formularioGerente()
        {
            InitializeComponent();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioStock formularioStock = new VentanasGerente.formularioStock();
            formularioStock.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioReporte formularioReporte = new VentanasGerente.formularioReporte();
            formularioReporte.Show();
            this.Close();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            VentanasGerente.formularioDatosEstadisticos formularioDatosEstadisticos = new VentanasGerente.formularioDatosEstadisticos();
            formularioDatosEstadisticos.Show(); 
            this.Close();   
        }
    }
}
