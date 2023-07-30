﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_SISVIANZA_v1.Presentacion;

namespace Proyecto_SISVIANZA_v1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void pass_TextChanged(object sender, EventArgs e) { }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            Logica.Ingreso ver = new Logica.Ingreso(); // instancie la clase verificacion
            //Guardado de datos desde los textBox a variables
            string nombre, contraseña;
            nombre = txtUser.Text;
            contraseña = txtPass.Text;
            //Realizar la validación a través del metodo Verifi
            bool usuarioValido = ver.Verificar(nombre, contraseña); // Guuardará lo que retorne el metodo Verifi en la variable usuarioValido, es decir un true o un false por ser un booleano.

            if (usuarioValido)
            {
                String rol = ver.ObtenerRol(nombre); //Llamara el metodo interfazUsuario con el valor nombre, y lo que retorne lo guardara en rol

                if (rol == "Gerente")
                {
                    formularioGerente formularioGerente = new formularioGerente();
                    formularioGerente.Show();
                    this.Hide();
                }
                else if (rol == "Administrador")
                {
                    formularioAdministrador formularioAdministrador = new formularioAdministrador();
                    formularioAdministrador.Show();
                    this.Hide();
                }
                else if (rol == "Jefe De Cocina")
                {
                    formularioJefeDeCocina formularioJefeDeCocina = new formularioJefeDeCocina();
                    formularioJefeDeCocina.Show();
                    this.Hide();
                }
                else if (rol == "Encargado De Transporte")
                {  
                    formularioEncargadoTransporte formularioEncargadoTransporte = new formularioEncargadoTransporte();
                    formularioEncargadoTransporte.Show();
                    this.Hide();
                }
                else if (rol == "Atención Al Público")
                {
               
                    formularioAtencionAlPublico formularioAtencionAlPublico = new formularioAtencionAlPublico();
                    formularioAtencionAlPublico.Show();
                    this.Hide();

                }
                else if (rol == "Informático")
                {
                    formularioInformatico infor = new formularioInformatico();
                    infor.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        }
        //----------------------------------------------------------------------------------------
        // Diseño interfaz
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la aplicacion por completo
        }

        private void txtUser_Leave_1(object sender, EventArgs e) //Puedes usar el evento "Leave" para realizar acciones o validaciones cuando el usuario deja un campo de texto.
        {
            if (txtUser.Text == "") //if condicion: Cuando el TextBox (txtUser) este vacio
            {
                txtUser.Text = "Ingrese su usuario"; // el TextBox mostrara el mensaje "Ingrese su usuario"
                txtUser.ForeColor = Color.Silver; // se establece el color de primer plano (foreground color) del control TextBox user. El color de primer plano determina el color del texto que se muestra en el control.
            }
        }

        private void txtUser_Enter_1(object sender, EventArgs e)// Puedes utilizar el evento "Enter" para realizar acciones o cambios en el control TextBox cuando el usuario lo selecciona o comienza a interactuar con él.
        {
            if (txtUser.Text == "Ingrese su usuario")
            {

                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;

            }
        }

        private void txtPass_Leave_1(object sender, EventArgs e)//Puedes usar el evento "Leave" para realizar acciones o validaciones cuando el usuario deja un campo de texto.
        {
            if (txtPass.Text == "") //if condicion: Cuando el TextBox (txtUser) este vacio
            {
                txtPass.Text = "Ingrese su contraseña"; // el TextBox mostrara el mensaje "Ingrese su contraseña"
                txtPass.ForeColor = Color.Silver; // se establece el color de primer plano (foreground color) del control TextBox user. El color de primer plano determina el color del texto que se muestra en el control.
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_Enter_1(object sender, EventArgs e)
        {
            if (txtPass.Text == "Ingrese su contraseña")
            {

                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void view_CheckedChanged_1(object sender, EventArgs e)
        {
            if (view.Checked) /*La propiedad Checked en un control CheckBox en C# indica si el CheckBox está marcado (seleccionado) o no.
                                 La propiedad Checked es de tipo bool, lo que significa que puede tener dos valores posibles: true o false. */
            {
                // Acciones a realizar cuando el CheckBox está marcado
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Acciones a realizar cuando el CheckBox no está marcado
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Verifica si la tecla presionada es "Enter"
            {
                // Ejecutar el botón automáticamente
                btnLogin.PerformClick(); // Simula un clic en el botón "btnLogin"
                e.SuppressKeyPress = true; // Suprime el sonido de "beep" al presionar "Enter"
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ejecutar el botón automáticamente
                btnLogin.PerformClick();
                e.SuppressKeyPress = true; // Suprimir el sonido de "beep" al presionar "Enter"
            }
        }

        private void view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ejecutar el botón automáticamente
                btnLogin.PerformClick();
                e.SuppressKeyPress = true; // Suprimir el sonido de "beep" al presionar "Enter"
            }
        }
    }
}


