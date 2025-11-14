using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtoGest
{
    public partial class OrtoGestMain : Form
    {
        public OrtoGestMain()
        {
            InitializeComponent();
        }

        // =====================================================
        // 1. EVENTOS CLICK DEL MENÚ PRINCIPAL
        // =====================================================

        // BOTÓN CLIENTES
        private void btnClientes_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmClientes())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
            }
        }

        // BOTÓN PRODUCTOS
        private void btnProductos_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmProductos())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
            }
        }

        // BOTÓN VENTAS
        private void btnVentas_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmVentas())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
            }
        }

        // BOTÓN SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra solo esta ventana:
            // this.Close();

            // O cierra toda la aplicación:
            Application.Exit();
        }

        // =====================================================
        // 2. EFECTOS VISUALES (COLORES HOVER)
        // =====================================================

        // BOTÓN CLIENTES
        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.LightCyan;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.Aquamarine;
        }

        // BOTÓN PRODUCTOS
        private void btnProductos_MouseEnter(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.LightCyan;
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.Aquamarine;
        }

        // BOTÓN VENTAS
        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.LightCyan;
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.Aquamarine;
        }

        // BOTÓN SALIR
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.SteelBlue;
        }

        // =====================================================
        // 3. OTROS EVENTOS
        // =====================================================

       
    }
}

