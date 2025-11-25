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

        public List<Product> ObterProdutos()
        {
            return dal.ListarProdutos();
        }
    }
}
