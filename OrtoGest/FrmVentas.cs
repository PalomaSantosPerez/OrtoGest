using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtoGest
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        public void CargarVentas()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"
                SELECT v.IdVenta, c.Nombre AS Cliente, p.Nombre AS Producto,
                       v.Cantidad, v.PrecioUnitario, v.Total, v.FechaVenta
                FROM Ventas v
                JOIN Clientes c ON v.IdCliente = c.IdCliente
                JOIN Productos p ON v.IdProducto = p.IdProducto
            ";

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvVentas.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarClientes()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT IdCliente, Nombre FROM Clientes";
                SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable tabla = new DataTable();
                da.Fill(tabla);

                cmbCliente.DataSource = tabla;
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "IdCliente";
            }
        }

        private void CargarProductosEnCombo()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT IdProducto, Nombre, Precio FROM Productos";
                SQLiteDataAdapter da = new SQLiteDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                da.Fill(tabla);

                cmbProducto.DataSource = tabla;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "IdProducto";
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedValue == null) return;

            DataRowView fila = cmbProducto.SelectedItem as DataRowView;

            if (fila != null)
            {
                txtPrecioUnit.Text = fila["Precio"].ToString();
            }
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (double.TryParse(txtPrecioUnit.Text, out double precio) &&
                int.TryParse(txtCantidad.Text, out int cantidad))
            {
                txtTotal.Text = (precio * cantidad).ToString("0.00");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
            CargarClientes();
            CargarProductosEnCombo();
        }

    }
}
