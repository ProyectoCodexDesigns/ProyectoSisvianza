namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasGerente
{
    partial class formularioDatosEstadisticos
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
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.chkbxPedidosMes = new System.Windows.Forms.CheckBox();
            this.chkbxCancelacion = new System.Windows.Forms.CheckBox();
            this.chkbxClientesFrecuentes = new System.Windows.Forms.CheckBox();
            this.chkbxPedidosPopulares = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(9, 237);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(559, 316);
            this.dgvNotificaciones.TabIndex = 31;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Arial Black", 15F);
            this.lblDatos.Location = new System.Drawing.Point(4, 202);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(82, 28);
            this.lblDatos.TabIndex = 33;
            this.lblDatos.Text = "Datos:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(10, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 23);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(489, 559);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(79, 23);
            this.btnVolver.TabIndex = 45;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblDato2.Location = new System.Drawing.Point(8, 26);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(93, 24);
            this.lblDato2.TabIndex = 39;
            this.lblDato2.Text = "Generar:";
            // 
            // chkbxPedidosMes
            // 
            this.chkbxPedidosMes.AutoSize = true;
            this.chkbxPedidosMes.Location = new System.Drawing.Point(12, 63);
            this.chkbxPedidosMes.Name = "chkbxPedidosMes";
            this.chkbxPedidosMes.Size = new System.Drawing.Size(194, 17);
            this.chkbxPedidosMes.TabIndex = 47;
            this.chkbxPedidosMes.Text = "Cantidad total de pedidos en el mes";
            this.chkbxPedidosMes.UseVisualStyleBackColor = true;
            // 
            // chkbxCancelacion
            // 
            this.chkbxCancelacion.AutoSize = true;
            this.chkbxCancelacion.Location = new System.Drawing.Point(12, 132);
            this.chkbxCancelacion.Name = "chkbxCancelacion";
            this.chkbxCancelacion.Size = new System.Drawing.Size(197, 17);
            this.chkbxCancelacion.TabIndex = 48;
            this.chkbxCancelacion.Text = "Motivos de cancelacion de pedidos.";
            this.chkbxCancelacion.UseVisualStyleBackColor = true;
            // 
            // chkbxClientesFrecuentes
            // 
            this.chkbxClientesFrecuentes.AutoSize = true;
            this.chkbxClientesFrecuentes.Location = new System.Drawing.Point(12, 109);
            this.chkbxClientesFrecuentes.Name = "chkbxClientesFrecuentes";
            this.chkbxClientesFrecuentes.Size = new System.Drawing.Size(116, 17);
            this.chkbxClientesFrecuentes.TabIndex = 50;
            this.chkbxClientesFrecuentes.Text = "Clientes frecuentes";
            this.chkbxClientesFrecuentes.UseVisualStyleBackColor = true;
            // 
            // chkbxPedidosPopulares
            // 
            this.chkbxPedidosPopulares.AutoSize = true;
            this.chkbxPedidosPopulares.Location = new System.Drawing.Point(12, 86);
            this.chkbxPedidosPopulares.Name = "chkbxPedidosPopulares";
            this.chkbxPedidosPopulares.Size = new System.Drawing.Size(135, 17);
            this.chkbxPedidosPopulares.TabIndex = 51;
            this.chkbxPedidosPopulares.Text = "Pedidos mas populares";
            this.chkbxPedidosPopulares.UseVisualStyleBackColor = true;
            // 
            // formularioDatosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 587);
            this.Controls.Add(this.chkbxPedidosPopulares);
            this.Controls.Add(this.chkbxClientesFrecuentes);
            this.Controls.Add(this.chkbxCancelacion);
            this.Controls.Add(this.chkbxPedidosMes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.dgvNotificaciones);
            this.Name = "formularioDatosEstadisticos";
            this.Text = "formularioDatosEstadisticos";
            this.Load += new System.EventHandler(this.formularioDatosEstadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.CheckBox chkbxPedidosMes;
        private System.Windows.Forms.CheckBox chkbxCancelacion;
        private System.Windows.Forms.CheckBox chkbxClientesFrecuentes;
        private System.Windows.Forms.CheckBox chkbxPedidosPopulares;
    }
}