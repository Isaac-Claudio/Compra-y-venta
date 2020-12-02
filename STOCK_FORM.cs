using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compra_y_venta
{
    public partial class STOCK_FORM : Form
    {
        public STOCK_FORM()
        {
            InitializeComponent();
        }

        private void STOCK_FORM_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ;  database=COMVENT ; integrated security = true");
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from PRODUCTOS", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
