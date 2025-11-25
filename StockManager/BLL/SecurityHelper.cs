using System;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Net;

namespace StockManager
{
    public static class SecurityHelper
    {
        // 🔑 Gera um hash da senha
        public static string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        // 📝 Registra log
        public static void RegistrarLog(string acao)
        {
            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Logs 
                               (UsuarioId, NomeUsuario, Acao, DataHora, IpMaquina, NomeMaquina) 
                               VALUES (@UsuarioId, @NomeUsuario, @Acao, @DataHora, @IpMaquina, @NomeMaquina)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioId", Sessao.UsuarioID);
                        cmd.Parameters.AddWithValue("@NomeUsuario", Sessao.NomeUsuario ?? "Não logado");
                        cmd.Parameters.AddWithValue("@Acao", acao);
                        cmd.Parameters.AddWithValue("@DataHora", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IpMaquina", Dns.GetHostAddresses(Dns.GetHostName())[0].ToString());
                        cmd.Parameters.AddWithValue("@NomeMaquina", Environment.MachineName);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar log: {ex.Message}");
            }
        }
    }
}
