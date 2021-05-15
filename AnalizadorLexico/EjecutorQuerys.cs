using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    class EjecutorQuerys
    {
        string cadena = "Data Source=DESKTOP-NJIFA2O\\SQLEXPRESS; Initial Catalog = AUTOMATAS; User ID=automata; Password=12345;Integrated Security=False";
        public SqlConnection conectarbd = new SqlConnection();


        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public EjecutorQuerys()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-NJIFA2O\\SQLEXPRESS; Initial Catalog = AUTOMATAS; User ID=automata; Password=12345;Integrated Security=False");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());

            }

        }


        DataTable dt;
        SqlDataAdapter da;

        public void CargarSimbolos(DataGridView dgvSimbolos)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Matriz", cn); //se llena con la consulta.
                dt = new DataTable();
                da.Fill(dt); //se llena el dt.
                dgvSimbolos.DataSource = (dt); //el data table llena el data grid.

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el data grid", ex.ToString());
            }
        }
        


    }            
}