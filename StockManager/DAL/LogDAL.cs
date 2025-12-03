using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.DAL
{
    public class LogDAL
    {
        private readonly ConexaoBD _conexao = new ConexaoBD();

        public void Registrar(string acao, int usuarioId, string nomeUsuario)
        {
            using (SqlConnection conn = _conexao.AbrirConexao())
            {
                if (conn == null) return;

                string sql = @"INSERT INTO Logs
                               (UsuarioId, NomeUsuario, Acao, DataHora, IpMaquina, NomeMaquina)
                               VALUES (@UsuarioId, @NomeUsuario, @Acao, @DataHora, @IpMaquina, @NomeMaquina)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                    cmd.Parameters.AddWithValue("@Acao", acao);
                    cmd.Parameters.AddWithValue("@DataHora", DateTime.Now);

                    // IP da máquina
                    var ip = Dns.GetHostAddresses(Dns.GetHostName());
                    cmd.Parameters.AddWithValue("@IpMaquina", ip.Length > 0 ? ip[0].ToString() : "N/D");

                    // Nome da máquina
                    cmd.Parameters.AddWithValue("@NomeMaquina", Environment.MachineName);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
