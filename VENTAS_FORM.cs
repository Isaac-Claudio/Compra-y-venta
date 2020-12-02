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
    public partial class VENTAS_FORM : Form
    {
        public VENTAS_FORM()
        {
            InitializeComponent();
        }

        private void INS_TIPO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VENDER_BUTTON_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ;  database=COMVENT ; integrated security = true");
            conexion.Open();
            string ID = INS_ID.Text;
            string PRECIO = INS_PRECIO.Text;
            string TIPO = INS_TIPO_PAGO.Text;
            string cadenaCOMPRAS = "insert into VENTAS(NOMBRE_PROD, PRECIO, TIPO_PAGO, FECHA)SELECT  NOMBRE_PROD,'" + PRECIO + "','" + TIPO + "', SYSDATETIME() FROM COMPRAS WHERE COMPRA_ID = '" + ID + "';" +
                " DELETE FROM PRODUCTOS WHERE ID_COMPRA = '" + ID + "'";
            SqlCommand comando = new SqlCommand(cadenaCOMPRAS, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Venta registrada correctamente");
        }

        private void RECARGAR_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ;  database=COMVENT ; integrated security = true");
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from VENTAS", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            VENTAS.DataSource = tabla;
            conexion.Close();
        }

        private void VENTAS_FORM_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ;  database=COMVENT ; integrated security = true");
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from VENTAS", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            VENTAS.DataSource = tabla;
            conexion.Close();
        }
    }
}
