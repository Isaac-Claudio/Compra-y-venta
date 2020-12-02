using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra_y_venta
{
    public partial class MAIN_SCREEN : Form
    {
        public MAIN_SCREEN()
        {
            InitializeComponent();
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STOCK_BUTTON_Click(object sender, EventArgs e)
        {
            if (this.Pantalla_principal.Controls.Count > 0)
                this.Pantalla_principal.Controls.RemoveAt(0);
            STOCK_FORM vista = new STOCK_FORM();
            vista.TopLevel = false;
            vista.Dock = DockStyle.Fill;
            this.Pantalla_principal.Controls.Add(vista);
            this.Pantalla_principal.Tag = vista;
            vista.Show();
        }

        private void COMPRAS_BUTTON_Click(object sender, EventArgs e)
        {
            if (this.Pantalla_principal.Controls.Count > 0)
                this.Pantalla_principal.Controls.RemoveAt(0);
            COMPRAS_FORM vista = new COMPRAS_FORM();
            vista.TopLevel = false;
            vista.Dock = DockStyle.Fill;
            this.Pantalla_principal.Controls.Add(vista);
            this.Pantalla_principal.Tag = vista;
            vista.Show();
        }

        private void VENTAS_BUTTON_Click(object sender, EventArgs e)
        {
            if (this.Pantalla_principal.Controls.Count > 0)
                this.Pantalla_principal.Controls.RemoveAt(0);
            VENTAS_FORM vista = new VENTAS_FORM();
            vista.TopLevel = false;
            vista.Dock = DockStyle.Fill;
            this.Pantalla_principal.Controls.Add(vista);
            this.Pantalla_principal.Tag = vista;
            vista.Show();
        }
    }
}
