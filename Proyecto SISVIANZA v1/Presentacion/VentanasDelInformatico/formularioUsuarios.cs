using Google.Protobuf.WellKnownTypes;
using Proyecto_SISVIANZA_v1.Logica;
using System;
using System.Drawing;
using System.Text.RegularExpressions; // Para poder utilizar metodo Regex
using System.Windows.Forms;

namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelInformatico
{
    public partial class formularioUsuarios : Form
    {
        public formularioUsuarios()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la aplicacion por completo

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (txtCI.Text == "Ingrese cedula de identidad")
            {

                txtCI.Text = "";
                txtCI.ForeColor = Color.Black;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCI_Leave(object sender, EventArgs e)
        {
            if (txtCI.Text == "") //if condicion: Cuando el TextBox (txtUser) este vacio
            {
                txtCI.Text = "Ingrese cedula de identidad"; // el TextBox mostrara el mensaje "Ingrese su usuario"
                txtCI.ForeColor = Color.Silver; // se establece el color de primer plano (foreground color) del control TextBox user. El color de primer plano determina el color del texto que se muestra en el control.
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingrese contraseña")
            {

                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingrese contraseña";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtPassagain.Text == "Vuelva a ingresar contraseña")
            {

                txtPassagain.Text = "";
                txtPassagain.ForeColor = Color.Black;

            }
        }

        private void txtPassagain_Leave(object sender, EventArgs e)
        {
            if (txtPassagain.Text == "")
            {
                txtPassagain.Text = "Vuelva a ingresar contraseña";
                txtPassagain.ForeColor = Color.Silver;
            }
        }



        private void txtRol_Enter(object sender, EventArgs e)
        {
            if (txtRol.Text == "Ingrese rol")
            {

                txtRol.Text = "";
                txtRol.ForeColor = Color.Black;

            }
        }

        private void txtRol_Leave(object sender, EventArgs e)
        {
            if (txtRol.Text == "")
            {
                txtRol.Text = "Ingrese rol";
                txtRol.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e) //BOTÓN REGISTRAR
        {
            Registro reg = new Registro();

            string ci, pass, rol;

            //VERIFICACIÓN DE QUE NINGUN CAMPO ESTE VACIO.

            if (txtCI.Text == "Ingrese cedula de identidad" || txtPassword.Text == "Ingrese Contraseña" || txtPassagain.Text == "Vuelva a ingresar contraseña" || txtRol.Text == "Ingrese rol" || txtCI.Text == "" || txtPassword.Text == "" || txtPassagain.Text == "" || txtRol.Text == "")
            {
                MessageBox.Show("Ninguno de lo campos puede estar vacio.");
            }

            //VERIFICACIÓN DE CONTRASEÑAS IGUALES.
            else if (txtPassword.Text == txtPassagain.Text)
            {
                //VERIFICACIÓN DE CEDULA.

                bool esValida = Regex.IsMatch(txtCI.Text, @"^[0-9]+$"); // Esta expresión regular comprueba si la cadena contiene únicamente dígitos del 0 al 9.

                if (esValida)

                {

                    if (reg.Cidiff(txtCI.Text)) // metodo para validar que la cedula no se repita.
                    {
                        MessageBox.Show("La cedula de identidad ingresada ya existe.");
                    }
                    else
                    {

                        //VERIFICACIÓN DE ROL VALIDO.

                        if (reg.VerificarRol(txtRol.Text))
                        {
                            //El rol es válido. 
                            pass = txtPassword.Text;
                            ci = txtCI.Text;
                            rol = txtRol.Text;


                            reg.Registrar(ci, pass, rol); //metodo para insertar los datos en la tabla correspondiente, en este caso usuario.

                            MessageBox.Show("Usuario registrado correctamente!");
                        }

                        else
                        {
                            //El rol es inválido. 
                            MessageBox.Show("El rol ingresado es inválido, lista de roles permitidos ( Gerente, Administración, Jefe De Cocina, Encargado De Transporte, Atención Al público, Informático ). ");
                        }
                    }
                    //FIN -----------------------------------------------------------------
                }
                else
                {
                    MessageBox.Show("La cédula es inválida. No se permiten letras.");
                }


            }
            else
            {
                MessageBox.Show("Las contraseñas deben ser iguales.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ciValue;
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCI.Text) || string.IsNullOrEmpty(txtRol.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtCI.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(txtCI.Text, out ciValue))
            {
                MessageBox.Show("La cédula debe contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Usuario modificado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo
            }

        }




    private void button4_Click(object sender, EventArgs e)
        {
            int ciValue;
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCI.Text) || string.IsNullOrEmpty(txtRol.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtCI.Text.Length != 8)
            {
                MessageBox.Show("La cédula debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(txtCI.Text, out ciValue))
            {
                MessageBox.Show("La cédula debe contener únicamente números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                MessageBox.Show("Usuario modificado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resto del codigo
            }
        }





        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void txtPassagain_TextChanged(object sender, EventArgs e) { }
        private void txtRol_TextChanged(object sender, EventArgs e) { }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            formularioInformatico formularioInformatico = new formularioInformatico();
            formularioInformatico.Show();
            this.Close();
        }
    }
}
