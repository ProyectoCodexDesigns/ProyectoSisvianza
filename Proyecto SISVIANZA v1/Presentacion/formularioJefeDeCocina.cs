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
    public partial class formularioJefeDeCocina : Form
    {
        public formularioJefeDeCocina()
        {
            InitializeComponent();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login cerarsecion = new login();
            cerarsecion.Show();
            this.Close();
        }

        private void formularioJefeDeCocina_Load(object sender, EventArgs e)
        {

        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            VentanasJefeDeCocina.formularioMenus formularioMenus = new VentanasJefeDeCocina.formularioMenus();
            formularioMenus.Show();
            this.Close();
        }

        private void btnViandas_Click(object sender, EventArgs e)
        {
            VentanasJefeDeCocina.formularioViandas formularioViandas = new VentanasJefeDeCocina.formularioViandas();
            formularioViandas.Show();
            this.Close();
        }
    }
}
