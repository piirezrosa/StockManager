using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Models;
using StockManager.DAL;
namespace StockManager.DAL
{
    public class UserDAL
    {
        private readonly ConexaoBD conexao = new ConexaoBD();

        public User ObterUsuarioPorLogin(string login)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string sql = "SELECT * FROM Usuarios WHERE Login = @login";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return new User
                        {
                            Id = (int)dr["Id"],
                            Name = dr["Nome"].ToString(),
                            Login = dr["Login"].ToString(),
                            Password = dr["Senha"].ToString(),
                            AccessLevel = dr["NivelAcesso"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public void InserirUsuario(User u)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string sql = "INSERT INTO Usuarios (Nome, Login, Senha, NivelAcesso) VALUES (@n, @l, @s, @a)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@n", u.Name);
                    cmd.Parameters.AddWithValue("@l", u.Login);
                    cmd.Parameters.AddWithValue("@s", u.Password);
                    cmd.Parameters.AddWithValue("@a", u.AccessLevel);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}