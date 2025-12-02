using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManager.DAL;
using StockManager.Models;

namespace StockManager.BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL dal = new ProductDAL();

        public void RegisterProduct(Product p)
        {
            if(string.IsNullOrWhiteSpace(p.Nome))
                throw new Exception("Nome do produto é obrigatório.");

            if (p.Quantidade <= 0)
                throw new Exception("A quantidade deve ser maior que zero.");

            if (p.DataFabricacao > DateTime.Now)
                throw new Exception("A data de fabricação não pode ser no futuro.");

            if (p.DataValidade <= p.DataFabricacao)
                throw new Exception("A data de validade deve ser maior do que a data de fabricação.");

            if(p.DataRecebimento > DateTime.Now)
                throw new Exception("Data de recebimento inválida.");

            dal.InserirProduto(p);

            SecurityHelper.RegistrarLog($"Produto '{p.Nome}' cadastrado.");
        }

        public List<Product> ObtainProducts(string name = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                return dal.ListarProdutos();

            return dal.SearchPerName(name);
        }

        public void UpdateProduct(Product p)
        {
            if (string.IsNullOrWhiteSpace(p.Nome))
                throw new Exception("O nome não pode ser vazio.");

            if (p.Quantidade <= 0)
                throw new Exception("Quantidade inválida.");

            if (p.DataValidade <= p.DataFabricacao)
                throw new Exception("A validade deve ser maior que a fabricação.");

            dal.UpdateProduct(p);

            SecurityHelper.RegistrarLog($"Atualizou produto ID {p.Id}");
        }

        public void DeleteProduct(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para exclusão.");

            dal.DeleteProduct(id);

            SecurityHelper.RegistrarLog($"Excluiu produto ID {id}");
        }
    }
}
