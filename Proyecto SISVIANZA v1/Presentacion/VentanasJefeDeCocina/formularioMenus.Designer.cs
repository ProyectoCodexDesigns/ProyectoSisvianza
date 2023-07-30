namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasJefeDeCocina
{
    partial class formularioMenus
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblListar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.btnListar_Menus = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtStock_Minimo = new System.Windows.Forms.TextBox();
            this.lblStock_Minimo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(931, 383);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 29);
            this.btnVolver.TabIndex = 89;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(6, 148);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(161, 24);
            this.lblDatos.TabIndex = 115;
            this.lblDatos.Text = "Datos del menu:";
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblListar.Location = new System.Drawing.Point(455, 50);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(227, 24);
            this.lblListar.TabIndex = 113;
            this.lblListar.Text = "Listar todos los menus:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(146, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 23);
            this.btnBuscar.TabIndex = 112;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(386, 81);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.Size = new System.Drawing.Size(628, 296);
            this.dgvNotificaciones.TabIndex = 109;
            // 
            // btnListar_Menus
            // 
            this.btnListar_Menus.Location = new System.Drawing.Point(688, 50);
            this.btnListar_Menus.Name = "btnListar_Menus";
            this.btnListar_Menus.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Menus.TabIndex = 108;
            this.btnListar_Menus.Text = "Listar Menus";
            this.btnListar_Menus.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(278, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 107;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtStock_Minimo
            // 
            this.txtStock_Minimo.Location = new System.Drawing.Point(146, 233);
            this.txtStock_Minimo.Name = "txtStock_Minimo";
            this.txtStock_Minimo.Size = new System.Drawing.Size(207, 20);
            this.txtStock_Minimo.TabIndex = 105;
            // 
            // lblStock_Minimo
            // 
            this.lblStock_Minimo.AutoSize = true;
            this.lblStock_Minimo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStock_Minimo.Location = new System.Drawing.Point(46, 237);
            this.lblStock_Minimo.Name = "lblStock_Minimo";
            this.lblStock_Minimo.Size = new System.Drawing.Size(94, 16);
            this.lblStock_Minimo.TabIndex = 104;
            this.lblStock_Minimo.Text = "Stock Minimo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTipo.Location = new System.Drawing.Point(98, 268);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 103;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(146, 267);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(207, 20);
            this.txtTipo.TabIndex = 102;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 10F);
            this.lblId.Location = new System.Drawing.Point(55, 86);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(86, 16);
            this.lblId.TabIndex = 99;
            this.lblId.Text = "ID del menu:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(146, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(207, 20);
            this.txtId.TabIndex = 98;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStock.Location = new System.Drawing.Point(94, 204);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 16);
            this.lblStock.TabIndex = 95;
            this.lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(146, 204);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(207, 20);
            this.txtStock.TabIndex = 94;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(146, 313);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 90;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(278, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 116;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 117;
            this.label5.Text = "Lista:";
            // 
            // formularioMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 434);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.btnListar_Menus);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtStock_Minimo);
            this.Controls.Add(this.lblStock_Minimo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnVolver);
            this.Name = "formularioMenus";
            this.Text = "formularioMenus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.Button btnListar_Menus;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtStock_Minimo;
        private System.Windows.Forms.Label lblStock_Minimo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
    }
}