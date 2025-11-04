using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Utils
{
    public static class Criptography
    {
        public static string GerarHash(string senha)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerificarSenha(string senhaDigitada, string hashBanco)
        {
            return GerarHash(senhaDigitada) == hashBanco;
        }
    }
}
