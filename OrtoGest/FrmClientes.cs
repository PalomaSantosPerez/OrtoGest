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


namespace OrtoGest
{
    public partial class FrmClientes : Form
    {
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
    }
}
