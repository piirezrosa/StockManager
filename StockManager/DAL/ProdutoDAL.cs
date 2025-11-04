using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManager.Models;

namespace StockManager.DAL
{
        public class ProdutoDAL
        {
            private readonly ConexaoBD conexao = new ConexaoBD();

            public void InserirProduto(Product p)
            {
                using (var conn = conexao.AbrirConexao())
                {
                    string sql = @"INSERT INTO Produtos (Nome, Quantidade, DataFabricacao, DataValidade, DataRecebimento)
                               VALUES (@n, @q, @df, @dv, @dr)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", p.Nome);
                        cmd.Parameters.AddWithValue("@q", p.Quantidade);
                        cmd.Parameters.AddWithValue("@df", p.DataFabricacao);
                        cmd.Parameters.AddWithValue("@dv", p.DataValidade);
                        cmd.Parameters.AddWithValue("@dr", p.DataRecebimento);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public List<Product> ListarProdutos()
            {
                List<Product> lista = new List<Product>();
                using (var conn = conexao.AbrirConexao())
                {
                    string sql = "SELECT * FROM Produtos";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lista.Add(new Product
                            {
                                Id = (int)dr["Id"],
                                Nome = dr["Nome"].ToString(),
                                Quantidade = (int)dr["Quantidade"],
                                DataFabricacao = (DateTime)dr["DataFabricacao"],
                                DataValidade = (DateTime)dr["DataValidade"],
                                DataRecebimento = (DateTime)dr["DataRecebimento"]
                            });
                        }
                    }
                }
                return lista;
            }
        }
}
