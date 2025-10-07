using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    public static class LogHelper
    {
        public static void RegistrarLog(string descricao)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;"))
            {
                conn.Open();
                string sql = "INSERT INTO Logs (UsuarioId, NomeUsuario, Acao, DataHora) VALUES (@UsuarioId, @NomeUsuario, @Acao, @DataHora)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UsuarioId", Sessao.UsuarioId);
                cmd.Parameters.AddWithValue("@NomeUsuario", Sessao.NomeUsuario);
                cmd.Parameters.AddWithValue("@Acao", descricao);
                cmd.Parameters.AddWithValue("@DataHora", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
