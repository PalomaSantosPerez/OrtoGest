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


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
