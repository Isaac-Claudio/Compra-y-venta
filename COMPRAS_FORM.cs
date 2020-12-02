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
    public partial class COMPRAS_FORM : Form
    {
        public COMPRAS_FORM()
        {
            InitializeComponent();
        }

        public string llenar { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void COMPRAS_FORM_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ;  database=COMVENT ; integrated security = true");
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from COMPRAS", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void REGISTRAR_COMPRA_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ;  database=COMVENT ; integrated security = true");
            conexion.Open();
            string NOMBRE = INS_NOMBRE.Text;
            string PROVEEDOR = INS_PROVEEDOR.Text;
            string TIPO = INS_TIPO.Text;
            string PRECIO = INS_PRECIO.Text;
            string cadenaCOMPRAS = "insert into COMPRAS(NOMBRE_PROD, PROVEEDOR, TIPO_PROD, PRECIO, FECHA)values ('" + NOMBRE + "','" + PROVEEDOR + "','" + TIPO + "','" + PRECIO+ "', SYSDATETIME());" +
                " INSERT INTO PRODUCTOS(NOMBRE, PRECIO, TIPO, ID_COMPRA) SELECT '"+ NOMBRE + "','" + PRECIO + "','" + TIPO + "', COMPRA_ID FROM COMPRAS;";
            SqlCommand comando = new SqlCommand(cadenaCOMPRAS, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Compra realizada correctamente");
        }

        private void RECARGAR_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ;  database=COMVENT ; integrated security = true");
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from COMPRAS", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
