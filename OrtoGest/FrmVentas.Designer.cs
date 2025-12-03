namespace OrtoGest
{
    partial class FrmVentas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDatosVentas = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecioUnit = new System.Windows.Forms.Label();
            this.txtPrecioUnit = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardaVenta = new System.Windows.Forms.Button();
            this.btnEditarVentas = new System.Windows.Forms.Button();
            this.btnLinpiarVentas = new System.Windows.Forms.Button();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Ventas";
            // 
            // lblDatosVentas
            // 
            this.lblDatosVentas.AutoSize = true;
            this.lblDatosVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosVentas.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDatosVentas.Location = new System.Drawing.Point(30, 80);
            this.lblDatosVentas.Name = "lblDatosVentas";
            this.lblDatosVentas.Size = new System.Drawing.Size(143, 21);
            this.lblDatosVentas.TabIndex = 1;
            this.lblDatosVentas.Text = "Datos de la Venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCliente.Location = new System.Drawing.Point(40, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 17);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente: ";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(160, 118);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(230, 25);
            this.cmbCliente.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProducto.Location = new System.Drawing.Point(40, 160);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 17);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(160, 160);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(230, 25);
            this.cmbProducto.TabIndex = 2;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCantidad.Location = new System.Drawing.Point(40, 200);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 17);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(160, 200);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(230, 25);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblPrecioUnit
            // 
            this.lblPrecioUnit.AutoSize = true;
            this.lblPrecioUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnit.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrecioUnit.Location = new System.Drawing.Point(474, 118);
            this.lblPrecioUnit.Name = "lblPrecioUnit";
            this.lblPrecioUnit.Size = new System.Drawing.Size(116, 17);
            this.lblPrecioUnit.TabIndex = 5;
            this.lblPrecioUnit.Text = "Precio Unitario (€):";
            // 
            // txtPrecioUnit
            // 
            this.txtPrecioUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPrecioUnit.Location = new System.Drawing.Point(633, 120);
            this.txtPrecioUnit.Name = "txtPrecioUnit";
            this.txtPrecioUnit.ReadOnly = true;
            this.txtPrecioUnit.Size = new System.Drawing.Size(130, 25);
            this.txtPrecioUnit.TabIndex = 6;
            this.txtPrecioUnit.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(474, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 17);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(633, 160);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 25);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFecha.Location = new System.Drawing.Point(474, 200);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 17);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(633, 200);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(130, 25);
            this.dtpFecha.TabIndex = 4;
            // 
            // btnGuardaVenta
            // 
            this.btnGuardaVenta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardaVenta.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardaVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaVenta.ForeColor = System.Drawing.Color.White;
            this.btnGuardaVenta.Location = new System.Drawing.Point(477, 250);
            this.btnGuardaVenta.Name = "btnGuardaVenta";
            this.btnGuardaVenta.Size = new System.Drawing.Size(120, 30);
            this.btnGuardaVenta.TabIndex = 9;
            this.btnGuardaVenta.Text = "Guardar";
            this.btnGuardaVenta.UseVisualStyleBackColor = false;
            this.btnGuardaVenta.Click += new System.EventHandler(this.btnGuardaVenta_Click);
            // 
            // btnEditarVentas
            // 
            this.btnEditarVentas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVentas.ForeColor = System.Drawing.Color.White;
            this.btnEditarVentas.Location = new System.Drawing.Point(643, 250);
            this.btnEditarVentas.Name = "btnEditarVentas";
            this.btnEditarVentas.Size = new System.Drawing.Size(120, 30);
            this.btnEditarVentas.TabIndex = 10;
            this.btnEditarVentas.Text = "Editar";
            this.btnEditarVentas.UseVisualStyleBackColor = false;
            this.btnEditarVentas.Click += new System.EventHandler(this.btnEditarVentas_Click);
            // 
            // btnLinpiarVentas
            // 
            this.btnLinpiarVentas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLinpiarVentas.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnLinpiarVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLinpiarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLinpiarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinpiarVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinpiarVentas.ForeColor = System.Drawing.Color.White;
            this.btnLinpiarVentas.Location = new System.Drawing.Point(477, 307);
            this.btnLinpiarVentas.Name = "btnLinpiarVentas";
            this.btnLinpiarVentas.Size = new System.Drawing.Size(120, 30);
            this.btnLinpiarVentas.TabIndex = 11;
            this.btnLinpiarVentas.Text = "Limpiar";
            this.btnLinpiarVentas.UseVisualStyleBackColor = false;
            this.btnLinpiarVentas.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminarVentas.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnEliminarVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVentas.ForeColor = System.Drawing.Color.White;
            this.btnEliminarVentas.Location = new System.Drawing.Point(643, 307);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarVentas.TabIndex = 12;
            this.btnEliminarVentas.Text = "Eliminar";
            this.btnEliminarVentas.UseVisualStyleBackColor = false;
            this.btnEliminarVentas.Click += new System.EventHandler(this.btnEliminarVentas_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(43, 365);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(720, 189);
            this.dgvVentas.TabIndex = 13;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnEliminarVentas);
            this.Controls.Add(this.btnLinpiarVentas);
            this.Controls.Add(this.btnEditarVentas);
            this.Controls.Add(this.btnGuardaVenta);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPrecioUnit);
            this.Controls.Add(this.lblPrecioUnit);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblDatosVentas);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVentas";
            this.Text = "Gestión de Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDatosVentas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecioUnit;
        private System.Windows.Forms.TextBox txtPrecioUnit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardaVenta;
        private System.Windows.Forms.Button btnEditarVentas;
        private System.Windows.Forms.Button btnLinpiarVentas;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}