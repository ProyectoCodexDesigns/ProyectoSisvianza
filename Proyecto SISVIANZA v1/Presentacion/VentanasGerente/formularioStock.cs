using Proyecto_SISVIANZA_v1.Logica;
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
    public partial class formularioStock : Form
    {
        private GestorValidaciones gestorValidaciones;
        public formularioStock()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioGerente formularioGerente = new formularioGerente();  
            formularioGerente.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int contadorIDs = 0;

            // Validación de campos vacíos y contar cuántas IDs se completaron
            if (!string.IsNullOrEmpty(txtIDPedido.Text))
            {
                contadorIDs++;
            }
            if (!string.IsNullOrEmpty(txtID_Menu.Text))
            {
                contadorIDs++;
            }
            if (!string.IsNullOrEmpty(txtID_Vianda.Text))
            {
                contadorIDs++;
            }

            // Comprobar que solo se complete una ID
            if (contadorIDs == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos una ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (contadorIDs > 1)
            {
                MessageBox.Show("Por favor, ingrese solo una ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los datos numéricos sean solo números.
            if (!string.IsNullOrEmpty(txtIDPedido.Text) && !gestorValidaciones.ContieneSoloNumeros(txtIDPedido.Text))
            {
                MessageBox.Show("La ID del pedido debe contener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtID_Menu.Text) && !gestorValidaciones.ContieneSoloNumeros(txtID_Menu.Text))
            {
                MessageBox.Show("La ID del menú debe contener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(txtID_Vianda.Text) && !gestorValidaciones.ContieneSoloNumeros(txtID_Vianda.Text))
            {
                MessageBox.Show("La ID de la vianda debe contener únicamente dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("La búsqueda se realizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Resto del código...
        }

        private void formularioStock_Load(object sender, EventArgs e)
        {

        }
    }
}
