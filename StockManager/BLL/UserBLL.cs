using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
            var user = usuarioDAL.ObterUsuarioPorLogin(usuario);
            if (user == null)
            {
                SecurityHelper.RegistrarLog("Usuário não encontrado");
                return false;
            }

            string senhaHash = SecurityHelper.GerarHash(senha);

            if (user.Password != senhaHash)
            {
                SecurityHelper.RegistrarLog("Senha incorreta");
                return false;
            }
            Sessao.IniciarSessao(user.Id, user.Name, user.AccessLevel);
            SecurityHelper.RegistrarLog("Login realizado com sucesso");
            return true;
        }

        public void CadastrarUsuario(User u)
        {
            u.Password = SecurityHelper.GerarHash(u.Password);
            if (usuarioDAL.ObterUsuarioPorLogin(u.Login) != null)
            {
                throw new Exception("Este login já existe!");
            }
            usuarioDAL.InserirUsuario(u);
            SecurityHelper.RegistrarLog($"Usuário cadastrado: {u.Login}");
        }
    }
}
