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
        public int idVentaSeleccionada = -1;

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

        private void LimpiarCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            txtPrecioUnit.Text = "";
            txtTotal.Text = "";
            dtpFecha.Value = DateTime.Now;

            idVentaSeleccionada = -1; // (si usas este campo)
        }

        private int BuscarIdClientePorNombre(string nombre)
        {
            foreach (DataRowView row in cmbCliente.Items)
            {
                if (row["Nombre"].ToString() == nombre)
                    return Convert.ToInt32(row["IdCliente"]);
            }
            return -1;
        }

        private int BuscarIdProductoPorNombre(string nombre)
        {
            foreach (DataRowView row in cmbProducto.Items)
            {
                if (row["Nombre"].ToString() == nombre)
                    return Convert.ToInt32(row["IdProducto"]);
            }
            return -1;
        }


        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
            CargarClientes();
            CargarProductosEnCombo();
        }

        private void btnGuardaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"INSERT INTO Ventas
            (IdCliente, IdProducto, Cantidad, PrecioUnitario, Total, FechaVenta)
            VALUES (@IdCliente, @IdProducto, @Cantidad, @PrecioUnitario, @Total, @FechaVenta)";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@IdProducto", cmbProducto.SelectedValue);
                        cmd.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnit.Text);
                        cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                        cmd.Parameters.AddWithValue("@FechaVenta", dtpFecha.Value.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarVentas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar venta:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];

                idVentaSeleccionada = Convert.ToInt32(fila.Cells["IdVenta"].Value);

                cmbCliente.SelectedValue = BuscarIdClientePorNombre(fila.Cells["Cliente"].Value.ToString());
                cmbProducto.SelectedValue = BuscarIdProductoPorNombre(fila.Cells["Producto"].Value.ToString());
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txtPrecioUnit.Text = fila.Cells["PrecioUnitario"].Value.ToString();
                txtTotal.Text = fila.Cells["Total"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaVenta"].Value);
            }
        }

        private void btnEditarVentas_Click(object sender, EventArgs e)
        {
            if (idVentaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una venta antes de editar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"UPDATE Ventas SET
                                IdCliente = @IdCliente,
                                IdProducto = @IdProducto,
                                Cantidad = @Cantidad,
                                PrecioUnitario = @PrecioUnitario,
                                Total = @Total,
                                FechaVenta = @FechaVenta
                                WHERE IdVenta = @IdVenta";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@IdProducto", cmbProducto.SelectedValue);
                        cmd.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnit.Text);
                        cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                        cmd.Parameters.AddWithValue("@FechaVenta", dtpFecha.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@IdVenta", idVentaSeleccionada);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta actualizada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarVentas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar venta:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarVentas_Click(object sender, EventArgs e)
        {
            if (idVentaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una venta antes de eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            DialogResult result = MessageBox.Show(
                "¿Seguro que desea eliminar esta venta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "DELETE FROM Ventas WHERE IdVenta = @IdVenta";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdVenta", idVentaSeleccionada);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta eliminada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarVentas();     // refresca la tabla
                LimpiarCampos();   // limpia los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar venta:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
