using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection.Emit;


namespace OrtoGest
{
    public partial class FrmClientes : Form
    {

        //variable para saber qué cliente editar, crud editar
        private int idClienteSeleccionado = -1;

        public FrmClientes()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar:\n" + ex.Message);
            }
        }

        public void CargarClientes()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    MessageBox.Show("Guardando en: " + OrtoGestMain.cadenaConexion);

                    // MessageBox.Show("Usando BD en:\n" + System.IO.Path.GetFullPath("ortogest.db"));
                    //tras un fallo en la conexion con este mensaje localizamos direccion bd

                    string consulta = "SELECT * FROM Clientes";
                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvClientes.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtDNI.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtPoblacion.Text = "";
            txtCP.Text = "";
            txtObservaciones.Text = "";
            txtAlta.Text = "";
            idClienteSeleccionado = -1;
        }

        //crud guardar clientes
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"INSERT INTO Clientes
                    (Nombre, Apellido1, Apellido2, DNI, Edad, Telefono, Email,
                    Direccion, Poblacion, CP, Observaciones, FechaAlta)
                    VALUES (@Nombre, @Apellido1, @Apellido2, @DNI, @Edad, @Telefono,
                    @Email, @Direccion, @Poblacion, @CP, @Observaciones, @FechaAlta)";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido1", txtApellido1.Text);
                        cmd.Parameters.AddWithValue("@Apellido2", txtApellido2.Text);
                        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
                        cmd.Parameters.AddWithValue("@Edad", txtEdad.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Poblacion", txtPoblacion.Text);
                        cmd.Parameters.AddWithValue("@CP", txtCP.Text);
                        cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);

                        // fecha actual
                        cmd.Parameters.AddWithValue("@FechaAlta", DateTime.Now.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                    }
                }

                txtAlta.Text = DateTime.Now.ToString("yyyy-MM-dd");

                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientes(); // refrescar la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //evento cellClicK para que al seleccionar un cliente se cargen todos los datos en los
        //text box
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                // Guarda el ID del cliente seleccionado
                idClienteSeleccionado = Convert.ToInt32(fila.Cells["IdCliente"].Value);

                // Rellena los TextBox
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido1.Text = fila.Cells["Apellido1"].Value.ToString();
                txtApellido2.Text = fila.Cells["Apellido2"].Value.ToString();
                txtDNI.Text = fila.Cells["DNI"].Value.ToString();
                txtEdad.Text = fila.Cells["Edad"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtPoblacion.Text = fila.Cells["Poblacion"].Value.ToString();
                txtCP.Text = fila.Cells["CP"].Value.ToString();
                txtObservaciones.Text = fila.Cells["Observaciones"].Value.ToString();
                txtAlta.Text = fila.Cells["FechaAlta"].Value.ToString();
            }
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un cliente antes de editar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(OrtoGestMain.cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"UPDATE Clientes SET 
                                Nombre = @Nombre,
                                Apellido1 = @Apellido1,
                                Apellido2 = @Apellido2,
                                DNI = @DNI,
                                Edad = @Edad,
                                Telefono = @Telefono,
                                Email = @Email,
                                Direccion = @Direccion,
                                Poblacion = @Poblacion,
                                CP = @CP,
                                Observaciones = @Observaciones,
                                FechaAlta = @FechaAlta
                                WHERE IdCliente = @IdCliente";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido1", txtApellido1.Text);
                        cmd.Parameters.AddWithValue("@Apellido2", txtApellido2.Text);
                        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
                        cmd.Parameters.AddWithValue("@Edad", txtEdad.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Poblacion", txtPoblacion.Text);
                        cmd.Parameters.AddWithValue("@CP", txtCP.Text);
                        cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
                        cmd.Parameters.AddWithValue("@FechaAlta", txtAlta.Text);

                        cmd.Parameters.AddWithValue("@IdCliente", idClienteSeleccionado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cliente actualizado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar cliente:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un cliente antes de eliminar.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Confirmación
                DialogResult result = MessageBox.Show(
                    "¿Seguro que desea eliminar este cliente?",
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

                      string consulta = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";

                    using (SQLiteCommand cmd = new SQLiteCommand(consulta, conexion))
                    {
                            cmd.Parameters.AddWithValue("@IdCliente", idClienteSeleccionado);
                            cmd.ExecuteNonQuery();
                    }
                }

                txtAlta.Text = DateTime.Parse(txtAlta.Text).ToString("yyyy-MM-dd");

                MessageBox.Show("Cliente eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar tabla
                    CargarClientes();

                    // Limpiar los campos
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar cliente:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

