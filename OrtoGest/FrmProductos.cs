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
    public partial class FrmProductos : Form
    {
        public int idProductoSeleccionado = -1;

        public FrmProductos()
        {
            InitializeComponent();
        }
       

        public void CargarProductos()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM Productos";

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvProductos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreProducto.Text = "";
            combCategoria.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCodigoProducto.Text = "";
            txtMarca.Text = "";
            txtProveedor.Text = "";
            txtDescripcion.Text = "";

            idProductoSeleccionado = -1;
        }


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un producto antes de editar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"UPDATE Productos SET 
                Nombre = @Nombre,
                Categoria = @Categoria,
                Precio = @Precio,
                Stock = @Stock,
                CodigoProducto = @CodigoProducto,
                Marca = @Marca,
                Proveedor = @Proveedor,
                Descripcion = @Descripcion
                WHERE IdProducto = @IdProducto";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                        cmd.Parameters.AddWithValue("@Categoria", combCategoria.Text);
                        cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                        cmd.Parameters.AddWithValue("@CodigoProducto", txtCodigoProducto.Text);
                        cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@Proveedor", txtProveedor.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                        cmd.Parameters.AddWithValue("@IdProducto", idProductoSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto actualizado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar producto:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                 DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                 idProductoSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);

                 txtNombreProducto.Text = fila.Cells["Nombre"].Value.ToString();
                 combCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                 txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                 txtStock.Text = fila.Cells["Stock"].Value.ToString();
                 txtCodigoProducto.Text = fila.Cells["CodigoProducto"].Value.ToString();
                 txtMarca.Text = fila.Cells["Marca"].Value.ToString();
                 txtProveedor.Text = fila.Cells["Proveedor"].Value.ToString();
                 txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            }
            

        }

        private void btnGuardarProd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"INSERT INTO Productos
            (Nombre, Categoria, Precio, Stock, CodigoProducto, Marca, Proveedor, Descripcion)
            VALUES (@Nombre, @Categoria, @Precio, @Stock, @CodigoProducto, @Marca, @Proveedor, @Descripcion)";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                        cmd.Parameters.AddWithValue("@Categoria", combCategoria.Text);
                        cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                        cmd.Parameters.AddWithValue("@CodigoProducto", txtCodigoProducto.Text);
                        cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@Proveedor", txtProveedor.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un producto antes de eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Seguro que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                    SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@IdProducto", idProductoSeleccionado);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto eliminado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
