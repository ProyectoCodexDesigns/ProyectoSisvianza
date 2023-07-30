namespace Proyecto_SISVIANZA_v1.Presentacion.VentanasGerente
{
    partial class formularioStock
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnListar_Pedidos = new System.Windows.Forms.Button();
            this.lblID_Menu = new System.Windows.Forms.Label();
            this.txtID_Menu = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtIDPedido = new System.Windows.Forms.TextBox();
            this.btnListar_Menus = new System.Windows.Forms.Button();
            this.lblID_Vianda = new System.Windows.Forms.Label();
            this.txtID_Vianda = new System.Windows.Forms.TextBox();
            this.btnListar_Viandas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(428, 428);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(121, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(8, 187);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(495, 235);
            this.dgvLista.TabIndex = 30;
            // 
            // btnListar_Pedidos
            // 
            this.btnListar_Pedidos.Location = new System.Drawing.Point(353, 37);
            this.btnListar_Pedidos.Name = "btnListar_Pedidos";
            this.btnListar_Pedidos.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Pedidos.TabIndex = 29;
            this.btnListar_Pedidos.Text = "Listar Pedidos";
            this.btnListar_Pedidos.UseVisualStyleBackColor = true;
            // 
            // lblID_Menu
            // 
            this.lblID_Menu.AutoSize = true;
            this.lblID_Menu.Font = new System.Drawing.Font("Arial", 10F);
            this.lblID_Menu.Location = new System.Drawing.Point(8, 65);
            this.lblID_Menu.Name = "lblID_Menu";
            this.lblID_Menu.Size = new System.Drawing.Size(86, 16);
            this.lblID_Menu.TabIndex = 35;
            this.lblID_Menu.Text = "ID del Menu:";
            // 
            // txtID_Menu
            // 
            this.txtID_Menu.Location = new System.Drawing.Point(121, 65);
            this.txtID_Menu.Name = "txtID_Menu";
            this.txtID_Menu.Size = new System.Drawing.Size(207, 20);
            this.txtID_Menu.TabIndex = 34;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPedido.Location = new System.Drawing.Point(8, 39);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(95, 16);
            this.lblPedido.TabIndex = 37;
            this.lblPedido.Text = "ID del Pedido:";
            // 
            // txtIDPedido
            // 
            this.txtIDPedido.Location = new System.Drawing.Point(121, 39);
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.Size = new System.Drawing.Size(207, 20);
            this.txtIDPedido.TabIndex = 36;
            // 
            // btnListar_Menus
            // 
            this.btnListar_Menus.Location = new System.Drawing.Point(353, 63);
            this.btnListar_Menus.Name = "btnListar_Menus";
            this.btnListar_Menus.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Menus.TabIndex = 38;
            this.btnListar_Menus.Text = "Listar Menus";
            this.btnListar_Menus.UseVisualStyleBackColor = true;
            // 
            // lblID_Vianda
            // 
            this.lblID_Vianda.AutoSize = true;
            this.lblID_Vianda.Font = new System.Drawing.Font("Arial", 10F);
            this.lblID_Vianda.Location = new System.Drawing.Point(8, 91);
            this.lblID_Vianda.Name = "lblID_Vianda";
            this.lblID_Vianda.Size = new System.Drawing.Size(107, 16);
            this.lblID_Vianda.TabIndex = 41;
            this.lblID_Vianda.Text = "ID de la Vianda:";
            // 
            // txtID_Vianda
            // 
            this.txtID_Vianda.Location = new System.Drawing.Point(121, 91);
            this.txtID_Vianda.Name = "txtID_Vianda";
            this.txtID_Vianda.Size = new System.Drawing.Size(207, 20);
            this.txtID_Vianda.TabIndex = 40;
            // 
            // btnListar_Viandas
            // 
            this.btnListar_Viandas.Location = new System.Drawing.Point(353, 89);
            this.btnListar_Viandas.Name = "btnListar_Viandas";
            this.btnListar_Viandas.Size = new System.Drawing.Size(150, 23);
            this.btnListar_Viandas.TabIndex = 42;
            this.btnListar_Viandas.Text = "Listar viandas";
            this.btnListar_Viandas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Lista:";
            // 
            // formularioStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 459);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnListar_Viandas);
            this.Controls.Add(this.lblID_Vianda);
            this.Controls.Add(this.txtID_Vianda);
            this.Controls.Add(this.btnListar_Menus);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.txtIDPedido);
            this.Controls.Add(this.lblID_Menu);
            this.Controls.Add(this.txtID_Menu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnListar_Pedidos);
            this.Controls.Add(this.btnVolver);
            this.Name = "formularioStock";
            this.Text = "formularioStock";
            this.Load += new System.EventHandler(this.formularioStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnListar_Pedidos;
        private System.Windows.Forms.Label lblID_Menu;
        private System.Windows.Forms.TextBox txtID_Menu;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtIDPedido;
        private System.Windows.Forms.Button btnListar_Menus;
        private System.Windows.Forms.Label lblID_Vianda;
        private System.Windows.Forms.TextBox txtID_Vianda;
        private System.Windows.Forms.Button btnListar_Viandas;
        private System.Windows.Forms.Label label5;
    }
}