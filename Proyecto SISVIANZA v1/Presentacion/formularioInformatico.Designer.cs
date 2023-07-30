namespace Proyecto_SISVIANZA_v1.Presentacion
{
    partial class formularioInformatico
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
            this.lblSeguridad = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.btnCerrarSecion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.lblInformatico = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeguridad
            // 
            this.lblSeguridad.AutoSize = true;
            this.lblSeguridad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguridad.Location = new System.Drawing.Point(18, 103);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size = new System.Drawing.Size(218, 19);
            this.lblSeguridad.TabIndex = 39;
            this.lblSeguridad.Text = "Ir al apartado de seguridad:";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(18, 78);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(208, 19);
            this.lblUsuarios.TabIndex = 38;
            this.lblUsuarios.Text = "Ir al apartado de usuarios:";
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRechazar.Location = new System.Drawing.Point(277, 137);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(75, 23);
            this.btnRechazar.TabIndex = 37;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAprobar.Location = new System.Drawing.Point(171, 137);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 36;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.Location = new System.Drawing.Point(14, 141);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(118, 19);
            this.lblNotificaciones.TabIndex = 35;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizar.Location = new System.Drawing.Point(479, 135);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 25);
            this.btnActualizar.TabIndex = 34;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(19, 170);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(642, 323);
            this.dgvNotificaciones.TabIndex = 33;
            // 
            // btnCerrarSecion
            // 
            this.btnCerrarSecion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrarSecion.Location = new System.Drawing.Point(528, 499);
            this.btnCerrarSecion.Name = "btnCerrarSecion";
            this.btnCerrarSecion.Size = new System.Drawing.Size(133, 23);
            this.btnCerrarSecion.TabIndex = 32;
            this.btnCerrarSecion.Text = "Cerrar sesión";
            this.btnCerrarSecion.UseVisualStyleBackColor = false;
            this.btnCerrarSecion.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnUsuarios.Location = new System.Drawing.Point(232, 74);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarios.TabIndex = 31;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAdministrador.Location = new System.Drawing.Point(-93, -54);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(425, 46);
            this.lblAdministrador.TabIndex = 30;
            this.lblAdministrador.Text = "Ventana Administrador";
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeguridad.Location = new System.Drawing.Point(242, 103);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(75, 23);
            this.btnSeguridad.TabIndex = 29;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // lblInformatico
            // 
            this.lblInformatico.AutoSize = true;
            this.lblInformatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblInformatico.Location = new System.Drawing.Point(4, 18);
            this.lblInformatico.Name = "lblInformatico";
            this.lblInformatico.Size = new System.Drawing.Size(376, 46);
            this.lblInformatico.TabIndex = 41;
            this.lblInformatico.Text = "Ventana informatico";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrar.Location = new System.Drawing.Point(371, 135);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 25);
            this.btnBorrar.TabIndex = 98;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // formularioInformatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(667, 527);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblInformatico);
            this.Controls.Add(this.lblSeguridad);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.btnCerrarSecion);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.btnSeguridad);
            this.Name = "formularioInformatico";
            this.Text = "formulario Informatico";
            this.Load += new System.EventHandler(this.formularioInformatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeguridad;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Button btnCerrarSecion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Label lblInformatico;
        private System.Windows.Forms.Button btnBorrar;
    }
}