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

namespace StockManager
{
    public partial class FrmConsultProducts : Form
    {
        public FrmConsultProducts()
        {
            InitializeComponent();
        }

        private void FrmConsultProducts_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void BtnRechargeConsultProducts_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nome = TxbBuscarNome.Text.Trim();
            CarregarProdutos(nome);
        }

        private void CarregarProdutos(string nome = "")
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=ExemploLoginDB;Integrated Security=True";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = @"SELECT Id, Produto, Quantidade, DataFab, DataVal, DataReceb 
                                     FROM Produtos
                                     WHERE Produto LIKE @nome";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexao);
                    adapter.SelectCommand.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    DgvConsultProducts.DataSource = tabela;
                    DgvConsultProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }
            }
        }
    }
}
