using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
    internal class UserDAL
    {
        private readonly string connectionString =
            "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

        public string LoginVerification(string login, string senha)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    bool loginValido = SegurancaHelper.ValidarLogin(login, senha, conn);

                    if (loginValido)
                    {
                        // Recupera informações do usuário logado
                        string query = "SELECT id, Nome, NivelAcesso FROM Usuarios WHERE Login = @login";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@login", login);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Sessao.UsuarioId = Convert.ToInt32(reader["id"]);
                                    Sessao.NomeUsuario = reader["Nome"].ToString();
                                    Sessao.NivelAcesso = reader["NivelAcesso"].ToString();
                                }
                            }
                        }

                        LogHelper.RegistrarLog($"Login realizado com sucesso por {Sessao.NomeUsuario}");
                        return $"Bem-vindo {Sessao.NomeUsuario}!";
                    }

                    LogHelper.RegistrarLog($"Tentativa de login falhou para o usuário {login}");
                    return "Usuário ou senha inválidos!";
                }
            }
            catch (Exception ex)
            {
                LogHelper.RegistrarLog($"Erro ao tentar login: {ex.Message}");
                return "Ocorreu um erro ao processar o login.";
            }
        }
    }

}
