using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasGerente
{
    public partial class formularioDatosEstadisticos : Form
    {
        public formularioDatosEstadisticos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();
            formularioGerente.Show();
            this.Close();
        }

        private void formularioDatosEstadisticos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación de selección de un solo checkbox usando XOR
            if (!(chkbxPedidosMes.Checked ^ chkbxPedidosPopulares.Checked ^ chkbxClientesFrecuentes.Checked ^ chkbxCancelacion.Checked))
            {
                MessageBox.Show("Seleccione solo un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se busco correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de selección de un solo checkbox usando XOR
            if (!(chkbxPedidosMes.Checked ^ chkbxPedidosPopulares.Checked ^ chkbxClientesFrecuentes.Checked ^ chkbxCancelacion.Checked))
            {
                MessageBox.Show("Seleccione solo un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                MessageBox.Show("Se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

}
