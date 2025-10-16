namespace OrtoGest
{
    partial class OrtoGestMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(303, 66);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 64);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "OrtoGest";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Aquamarine;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClientes.Location = new System.Drawing.Point(68, 214);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(150, 40);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseEnter += new System.EventHandler(this.btnClientes_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnClientes_MouseLeave);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Aquamarine;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnProductos.Location = new System.Drawing.Point(332, 214);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(150, 40);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.MouseEnter += new System.EventHandler(this.btnProductos_MouseEnter);
            this.btnProductos.MouseLeave += new System.EventHandler(this.btnProductos_MouseLeave);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Aquamarine;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnVentas.Location = new System.Drawing.Point(596, 214);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(150, 40);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.button3_Click);
            this.btnVentas.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Azure;
            this.btnSalir.Location = new System.Drawing.Point(332, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // OrtoGestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "OrtoGestMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrtoGest - Gestión de Ortopedias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSalir;
    }
}

