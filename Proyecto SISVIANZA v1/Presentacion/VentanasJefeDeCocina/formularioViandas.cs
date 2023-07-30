using Google.Protobuf.WellKnownTypes;
using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasJefeDeCocina
{
    public partial class formularioViandas : Form
    {


        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public string TipoDieta { get; private set; }
        public string Tiempo { get; private set; }
        public string Postre { get; private set; }
        public string Estado { get; private set; }


        private Logica.GestorValidaciones gestorValidaciones;
        public formularioViandas()
        {
            InitializeComponent();
            gestorValidaciones = new Logica.GestorValidaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioJefeDeCocina formularioJefeDeCocina = new formularioJefeDeCocina();
            formularioJefeDeCocina.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void formularioViandas_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES.

            // QUE LOS CAMPOS NO ESTÉN VACÍOS.
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtTipo_Dieta.Text) || string.IsNullOrEmpty(txtFecha_Caducidad.Text) || string.IsNullOrEmpty(txtTiempo.Text) || string.IsNullOrEmpty(txtPostre.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // QUE LOS CAMPOS DE TEXTO SOLO TENGAN DATOS DE TIPO TEXTO.
            else if (!gestorValidaciones.ContieneSoloTexto(txtNombre.Text) || !gestorValidaciones.ContieneSoloTexto(txtDescripcion.Text) || !gestorValidaciones.ContieneSoloTexto(txtPostre.Text))
            {
                MessageBox.Show("Formato inválido, el NOMBRE, la DESCRIPCIÓN y el POSTRE solo aceptan caracteres alfabéticos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // PARSEAR LA FECHA DE ENTREGA.
            else if (!DateTime.TryParse(txtFecha_Caducidad.Text, out DateTime fechaCaducidad))
            {
                MessageBox.Show("Formato de fecha de caducidad inválida. Utilice el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // QUE EL TIEMPO SEA VÁLIDO.
            else if (!gestorValidaciones.Tiempo(txtTiempo.Text))
            {
                MessageBox.Show("Formato del tiempo inválido. Utilice el formato 00:00:00.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // VERIFICAR EL TIPO DE DIETA.
            else if (txtTipo_Dieta.Text != "Vegetariana" && txtTipo_Dieta.Text != "Baja Calorías" && txtTipo_Dieta.Text != "Celíacos")
            {
                MessageBox.Show("El tipo de dieta debe ser 'Vegetariana', 'Baja Calorías' o 'Celíacos'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SI TODAS LAS VALIDACIONES PASAN, GUARDAR LOS DATOS.

                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resto del código...
                // Id = GenerarID();
                // Nombre = txtNombre.Text;
                // Descripcion = txtDescripcion.Text;
                // TipoDieta = txtTipo_Dieta.Text;
                // Tiempo = txtTiempo.Text;
                // Postre = txtPostre.Text;
                // Estado = "Solicitada";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ////Que la id solo sea numerica.
            if (!gestorValidaciones.ContieneSoloNumeros(txtId.Text))
            {
                MessageBox.Show("El número de ID debe tener unicamente dígitos númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("El número de ID se busco correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Resto del codigo..


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DEJAR LOS CAMPOS EN SU ESTADO INICIAL
            txtId.Text = "";
            txtNombre.Text = "";
            txtTipo_Dieta.Text = "";
            txtTiempo.Text = "";
            txtPostre.Text = "";

            MessageBox.Show("Campos vaciados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
