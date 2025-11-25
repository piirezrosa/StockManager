using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.BLL;
using StockManager.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockManager
{
    public partial class FrmRegisterProduct : Form
    {
        private readonly ProductBLL productBLL = new ProductBLL();

        public FrmRegisterProduct()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product
                {
                    Nome = TxbProduct.Text,
                    Quantidade = int.Parse(TxbQuantity.Text),
                    DataFabricacao = DtpDataFab.Value,
                    DataValidade = DtpDataVal.Value,
                    DataRecebimento = DtpDataReceb.Value
                };

                productBLL.RegisterProduct(p);

                MessageBox.Show("Produto cadastrado com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxbProduct.Clear();
                TxbQuantity.Clear();
                DtpDataFab.Value = DateTime.Now;
                DtpDataVal.Value = DateTime.Now;
                DtpDataReceb.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegisterProduct_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cJ3027597PR2DataSet.RegistroProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.registroProdutoTableAdapter.Fill(this.cJ3027597PR2DataSet.RegistroProduto);

        }
    }
}
