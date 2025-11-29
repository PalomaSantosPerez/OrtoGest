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
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

    }
}
