﻿namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasEncargadoDeTransporte
{
    partial class formularioAsignarRuta
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
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtId_Pedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCi = new System.Windows.Forms.Label();
            this.txtId_Vehiculo = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtId_Ruta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDuracion_Estimada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipo_Calle = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnListar_Vehiculos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId_Caja = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDireccion.Location = new System.Drawing.Point(43, 129);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(95, 16);
            this.lblDireccion.TabIndex = 39;
            this.lblDireccion.Text = "ID del Pedido:";
            // 
            // txtId_Pedido
            // 
            this.txtId_Pedido.Location = new System.Drawing.Point(144, 125);
            this.txtId_Pedido.Name = "txtId_Pedido";
            this.txtId_Pedido.Size = new System.Drawing.Size(207, 20);
            this.txtId_Pedido.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Asignar pedido:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label4.Location = new System.Drawing.Point(370, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "Buscar Vehiculo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(542, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 29);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCi.Location = new System.Drawing.Point(34, 100);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(104, 16);
            this.lblCi.TabIndex = 57;
            this.lblCi.Text = "ID del Vehiculo:";
            // 
            // txtId_Vehiculo
            // 
            this.txtId_Vehiculo.Location = new System.Drawing.Point(144, 99);
            this.txtId_Vehiculo.Name = "txtId_Vehiculo";
            this.txtId_Vehiculo.Size = new System.Drawing.Size(207, 20);
            this.txtId_Vehiculo.TabIndex = 56;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(143, 403);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(83, 29);
            this.btnAsignar.TabIndex = 63;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(143, 280);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(207, 20);
            this.txtOrigen.TabIndex = 68;
            // 
            // txtId_Ruta
            // 
            this.txtId_Ruta.Location = new System.Drawing.Point(143, 251);
            this.txtId_Ruta.Name = "txtId_Ruta";
            this.txtId_Ruta.Size = new System.Drawing.Size(207, 20);
            this.txtId_Ruta.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Ruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(49, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "ID de la ruta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(83, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(83, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Destino:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(143, 312);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(207, 20);
            this.txtDestino.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(13, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Duracion estimada:";
            // 
            // txtDuracion_Estimada
            // 
            this.txtDuracion_Estimada.Location = new System.Drawing.Point(143, 364);
            this.txtDuracion_Estimada.Name = "txtDuracion_Estimada";
            this.txtDuracion_Estimada.Size = new System.Drawing.Size(207, 20);
            this.txtDuracion_Estimada.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(62, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Tipo calle :";
            // 
            // txtTipo_Calle
            // 
            this.txtTipo_Calle.Location = new System.Drawing.Point(143, 338);
            this.txtTipo_Calle.Name = "txtTipo_Calle";
            this.txtTipo_Calle.Size = new System.Drawing.Size(207, 20);
            this.txtTipo_Calle.TabIndex = 77;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 29);
            this.button3.TabIndex = 79;
            this.button3.Text = "Abortar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "Asignar ruta del vehiculo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 24);
            this.label12.TabIndex = 82;
            this.label12.Text = "Asignar pedido al vehiculo:";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(374, 143);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(647, 343);
            this.dgvLista.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label11.Location = new System.Drawing.Point(648, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 24);
            this.label11.TabIndex = 86;
            this.label11.Text = "Listar todos los vehiculos:";
            // 
            // btnListar_Vehiculos
            // 
            this.btnListar_Vehiculos.Location = new System.Drawing.Point(908, 87);
            this.btnListar_Vehiculos.Name = "btnListar_Vehiculos";
            this.btnListar_Vehiculos.Size = new System.Drawing.Size(113, 30);
            this.btnListar_Vehiculos.TabIndex = 83;
            this.btnListar_Vehiculos.Text = "Listar Vehiculos";
            this.btnListar_Vehiculos.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(938, 492);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 29);
            this.btnVolver.TabIndex = 88;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F);
            this.label13.Location = new System.Drawing.Point(43, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 90;
            this.label13.Text = "ID de la Caja:";
            // 
            // txtId_Caja
            // 
            this.txtId_Caja.Location = new System.Drawing.Point(144, 151);
            this.txtId_Caja.Name = "txtId_Caja";
            this.txtId_Caja.Size = new System.Drawing.Size(207, 20);
            this.txtId_Caja.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(370, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 19);
            this.label14.TabIndex = 91;
            this.label14.Text = "Lista:";
            // 
            // formularioAsignarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 535);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtId_Caja);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnListar_Vehiculos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTipo_Calle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDuracion_Estimada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId_Ruta);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCi);
            this.Controls.Add(this.txtId_Vehiculo);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtId_Pedido);
            this.Name = "formularioAsignarRuta";
            this.Text = "formularioAsignarRuta";
            this.Load += new System.EventHandler(this.formularioAsignarRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtId_Pedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtId_Vehiculo;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtId_Ruta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDuracion_Estimada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipo_Calle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnListar_Vehiculos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtId_Caja;
        private System.Windows.Forms.Label label14;
    }
}