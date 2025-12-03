using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockManager.DAL
{
    public class ConexaoBD
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CJ3027597PR2;Integrated Security=True;";

        public SqlConnection AbrirConexao()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                return conn;
        }
    }
}