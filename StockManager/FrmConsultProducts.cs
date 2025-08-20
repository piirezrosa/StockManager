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

        private void CarregarProdutos()
        {
            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT Id, Produto, Quantidade, DataFab, DataVal, DataReceb FROM Produtos";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexao);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    DgvConsultProducts.DataSource = tabela;

                    // Ajusta colunas automaticamente
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
