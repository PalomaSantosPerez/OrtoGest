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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //BOTON CLIENTES
        private void btnClientes_Click(object sender, EventArgs e)
        {
           // btnClientes.BackColor = Color.SteelBlue;

        }

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.LightCyan;

        }


        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.Aquamarine;

        }

        //BOTON PRODUCTOS
        private void btnProductos_MouseEnter(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.LightCyan;
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.Aquamarine;
        }
        
        //BOTON VENTAS
        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.LightCyan;

        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.Aquamarine;

        }

        //BOTON SALIR
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.LightBlue;

        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.SteelBlue;

        }
    }
}
