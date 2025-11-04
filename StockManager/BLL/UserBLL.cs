using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManager.DAL;
using StockManager.Utils;

namespace StockManager.BLL
{
    public class UserBLL
    {
        private readonly UserDAL usuarioDAL = new UserDAL();

        public bool ValidarLogin(string usuario, string senha, SqlConnection conn)
        {
            string senhaHash = SecurityHelper.GerarHash(senha);

            string sql = "SELECT * FROM Usuarios WHERE Login=@usuario AND Senha=@senha";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senhaHash);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Sessao.IniciarSessao(Convert.ToInt32(reader["Id"]), reader["Nome"].ToString(), reader["NivelAcesso"].ToString());
                        // Log de login
                        SecurityHelper.RegistrarLog("Login realizado com sucesso");
                        return true;
                    }
                }
            }
            // Se não encontrou, registra tentativa
            SecurityHelper.RegistrarLog("Tentativa de login falhou");
            return false;
        }

        public void CadastrarUsuario(User u)
        {
            u.Password = Criptography.GerarHash(u.Password);
            usuarioDAL.InserirUsuario(u);
        }
    }
}
