using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    public static class Sessao
    {
        public static int UsuarioID { get; private set; }
        public static string NomeUsuario { get; private set; }
        public static string NivelAcesso { get; private set; }

        public static void IniciarSessao(int id, string nome, string nivel)
        {
            UsuarioID = id;
            NomeUsuario = nome;           
            NivelAcesso = nivel;
        }

        public static void EncerrarSessao()
        {
            UsuarioID = 0;
            NomeUsuario = null;
            NivelAcesso = null;
        }

        public static bool SessaoAtiva()
        {
            return UsuarioID != 0;
        }
    }
}
