namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasDelInformatico
{
    partial class formularioUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtPassagain = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblPedidos);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(453, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCI
            // 
            this.txtCI.BackColor = System.Drawing.Color.White;
            this.txtCI.ForeColor = System.Drawing.Color.Silver;
            this.txtCI.Location = new System.Drawing.Point(60, 66);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(179, 20);
            this.txtCI.TabIndex = 6;
            this.txtCI.Text = "Ingrese cedula de identidad";
            this.txtCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCI.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtCI.Enter += new System.EventHandler(this.textBox6_Enter);
            this.txtCI.Leave += new System.EventHandler(this.txtCI_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(60, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "Ingrese contraseña";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.Color.White;
            this.txtRol.ForeColor = System.Drawing.Color.Silver;
            this.txtRol.Location = new System.Drawing.Point(60, 187);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(179, 20);
            this.txtRol.TabIndex = 16;
            this.txtRol.Text = "Ingrese rol";
            this.txtRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRol.TextChanged += new System.EventHandler(this.txtRol_TextChanged);
            this.txtRol.Enter += new System.EventHandler(this.txtRol_Enter);
            this.txtRol.Leave += new System.EventHandler(this.txtRol_Leave);
            // 
            // txtPassagain
            // 
            this.txtPassagain.BackColor = System.Drawing.Color.White;
            this.txtPassagain.ForeColor = System.Drawing.Color.Silver;
            this.txtPassagain.Location = new System.Drawing.Point(60, 148);
            this.txtPassagain.Name = "txtPassagain";
            this.txtPassagain.Size = new System.Drawing.Size(179, 20);
            this.txtPassagain.TabIndex = 17;
            this.txtPassagain.Text = "Vuelva a ingresar contraseña";
            this.txtPassagain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassagain.TextChanged += new System.EventHandler(this.txtPassagain_TextChanged);
            this.txtPassagain.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtPassagain.Leave += new System.EventHandler(this.txtPassagain_Leave);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(278, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 44);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar usuario";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 44);
            this.button4.TabIndex = 19;
            this.button4.Text = "Eliminar usuario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(403, 235);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(71, 22);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 26F);
            this.lblPedidos.Location = new System.Drawing.Point(52, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(323, 40);
            this.lblPedidos.TabIndex = 60;
            this.lblPedidos.Text = "Formulario Usuarios";
            // 
            // formularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 269);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPassagain);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtPassagain;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPedidos;
    }
}