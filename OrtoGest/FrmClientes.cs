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
        SQLiteConnection conexion = new SQLiteConnection();
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

                    MessageBox.Show("Usando BD en:\n" + System.IO.Path.GetFullPath("ortogest.db"));


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


    }
}
