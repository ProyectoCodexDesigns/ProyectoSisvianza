﻿namespace Proyecto_SISVIANZA_v1.Presentacion
{
    partial class formularioAtencionAlPublico
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
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.lblAltas = new System.Windows.Forms.Label();
            this.lblEstados = new System.Windows.Forms.Label();
            this.btnEstados = new System.Windows.Forms.Button();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnCerrarSecion = new System.Windows.Forms.Button();
            this.lblAtencion = new System.Windows.Forms.Label();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.Location = new System.Drawing.Point(16, 140);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(118, 19);
            this.lblNotificaciones.TabIndex = 28;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(16, 172);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(645, 325);
            this.dgvNotificaciones.TabIndex = 27;
            // 
            // lblAltas
            // 
            this.lblAltas.AutoSize = true;
            this.lblAltas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltas.Location = new System.Drawing.Point(12, 105);
            this.lblAltas.Name = "lblAltas";
            this.lblAltas.Size = new System.Drawing.Size(241, 19);
            this.lblAltas.TabIndex = 38;
            this.lblAltas.Text = "Ir al apartado de solicitar altas:";
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(12, 74);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(202, 19);
            this.lblEstados.TabIndex = 37;
            this.lblEstados.Text = "Ir al apartado de estados:";
            // 
            // btnEstados
            // 
            this.btnEstados.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEstados.Location = new System.Drawing.Point(220, 74);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(75, 23);
            this.btnEstados.TabIndex = 32;
            this.btnEstados.Text = "Estados";
            this.btnEstados.UseVisualStyleBackColor = false;
            this.btnEstados.Click += new System.EventHandler(this.btnEstados_Click);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSolicitar.Location = new System.Drawing.Point(259, 101);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btnSolicitar.TabIndex = 31;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // btnCerrarSecion
            // 
            this.btnCerrarSecion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrarSecion.Location = new System.Drawing.Point(542, 503);
            this.btnCerrarSecion.Name = "btnCerrarSecion";
            this.btnCerrarSecion.Size = new System.Drawing.Size(119, 25);
            this.btnCerrarSecion.TabIndex = 39;
            this.btnCerrarSecion.Text = "Cerrar secion";
            this.btnCerrarSecion.UseVisualStyleBackColor = false;
            this.btnCerrarSecion.Click += new System.EventHandler(this.btnCerrarSecion_Click);
            // 
            // lblAtencion
            // 
            this.lblAtencion.AutoSize = true;
            this.lblAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblAtencion.Location = new System.Drawing.Point(12, 9);
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(522, 46);
            this.lblAtencion.TabIndex = 40;
            this.lblAtencion.Text = "Ventana Atencion al Publico";
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRechazar.Location = new System.Drawing.Point(256, 140);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(78, 25);
            this.btnRechazar.TabIndex = 113;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAprobar.Location = new System.Drawing.Point(155, 140);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(78, 25);
            this.btnAprobar.TabIndex = 112;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizar.Location = new System.Drawing.Point(464, 140);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 25);
            this.btnActualizar.TabIndex = 111;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrar.Location = new System.Drawing.Point(362, 140);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 25);
            this.btnBorrar.TabIndex = 110;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // formularioAtencionAlPublico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(670, 540);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblAtencion);
            this.Controls.Add(this.btnCerrarSecion);
            this.Controls.Add(this.lblAltas);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.btnEstados);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.dgvNotificaciones);
            this.Name = "formularioAtencionAlPublico";
            this.Text = "formulario Atencion Al Publico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNotificaciones;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Label lblAltas;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnCerrarSecion;
        private System.Windows.Forms.Label lblAtencion;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}