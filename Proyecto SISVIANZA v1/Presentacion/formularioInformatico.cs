using Proyecto_SISVIANZA_v1.Presentacion.VentanasDelInformatico;
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
    public partial class formularioInformatico : Form
    {
        public formularioInformatico()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            VentanasDelInformatico.formularioUsuarios formularioUsuarios = new VentanasDelInformatico.formularioUsuarios();
            formularioUsuarios.Show();
            this.Close();
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            VentanasDelInformatico.formularioSeguridad formularioSeguridad = new VentanasDelInformatico.formularioSeguridad();
            formularioSeguridad.Show();
            this.Close();
        }
        private void formularioInformatico_Load(object sender, EventArgs e)
        {

        }
    }
}
