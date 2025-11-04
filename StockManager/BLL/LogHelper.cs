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
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;"))
                {
                    conn.Open();
                    string sql = "INSERT INTO Logs (UsuarioId, NomeUsuario, Acao, Datahora) VALUES (@UsuarioId, @NomeUsuario, @Acao, @Datahora)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioId", Sessao.UsuarioID); // Corrigido: removido o $
                        cmd.Parameters.AddWithValue("@NomeUsuario", Sessao.NomeUsuario); // Corrigido: removido o $
                        cmd.Parameters.AddWithValue("@Acao", descricao);
                        cmd.Parameters.AddWithValue("@Datahora", DateTime.Now); // Corrigido: DateTime.Now

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratamento de erro - você pode logar em arquivo ou mostrar mensagem
                Console.WriteLine($"Erro ao registrar log: {ex.Message}");
            }
        }
    }
}
