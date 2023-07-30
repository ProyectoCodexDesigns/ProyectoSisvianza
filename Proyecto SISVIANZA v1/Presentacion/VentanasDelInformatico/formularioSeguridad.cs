﻿using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelInformatico
{
    public partial class formularioSeguridad : Form
    {
        private GestorValidaciones gestorValidaciones;

        //Asignar                             //Crear manualmente esta carpeta: ( carpeta prueba)
      // rutaPrueba = @"C:\Users\TuUsuario\Desktop\CarpetaPrueba";



        public formularioSeguridad()
        {
            InitializeComponent();
            gestorValidaciones = new GestorValidaciones();    
        }

        private void formularioSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioInformatico formularioInformatico = new formularioInformatico();
            formularioInformatico.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRealizar_Click(object sender, EventArgs e)                                                             /* C:\Users\Esteban\Desktop\CarpetaPrueba*/
        {

          


            //Que lso campos noe sten vacios.
            if (string.IsNullOrEmpty(txtCarpeta.Text))
            {
                MessageBox.Show("Por favor, ingrese la ruta de la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Verificar si existe.          
            else if (!(Directory.Exists(txtCarpeta.Text)))
            {
                MessageBox.Show("La carpeta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validación de selección de un solo checkbox usando XOR
            else if (!(chkbxSi.Checked ^ chkbxNo.Checked))
            {
                MessageBox.Show("Seleccione solo un Checkbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                MessageBox.Show("Copia de seguridad realizada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Resto del codigo

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string carpeta = txtCarpeta.Text.Trim();
            //Que lso campos noe sten vacios.
            if (string.IsNullOrEmpty(carpeta))
            {
                MessageBox.Show("Por favor, ingrese la ruta de la carpeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Que la carpeta exista
            else if (!(Directory.Exists(txtCarpeta.Text)))
            {
                MessageBox.Show("La carpeta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Copia de seguridad eliminada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Resto del codigo

            }
        }
    }
}
