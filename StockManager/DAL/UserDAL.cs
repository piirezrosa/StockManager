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
        public string LoginVerification(string login, string pass)
        {
            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    bool loginValido = SegurancaHelper.ValidarLogin(login, pass, conn);

                    if (loginValido)
                    {
                        return $"Bem-vindo {Sessao.NomeUsuario}!";
                    }
                 return "Usuário ou senha inválidos!";
                }
            }
        }
    }
}
