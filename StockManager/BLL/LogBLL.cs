using StockManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.BLL
{
    public class LogBLL
    {
        private readonly LogDAL dal = new LogDAL();

        public void Registrar(string acao)
        {
            int usuarioId = Sessao.UsuarioID;
            string nomeUsuario = Sessao.NomeUsuario ?? "Não logado";

            dal.Registrar(acao, usuarioId, nomeUsuario);
        }
    }
}
