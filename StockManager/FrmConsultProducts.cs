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

            this.Load += FrmConsultProducts_Load;
            BtnBuscar.Click += BtnBuscar_Click;
            BtnRechargeConsultProducts.Click += BtnRechargeConsultProducts_Click;

            TxbBuscarNome.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnBuscar.PerformClick(); };
        }

        private void FrmConsultProducts_Load(object sender, EventArgs e)
        {
            CarregarProdutos(null);
        }

        private void BtnRechargeConsultProducts_Click(object sender, EventArgs e)
        {
            TxbBuscarNome.Clear();
            CarregarProdutos(null);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarProdutos(TxbBuscarNome.Text?.Trim());
        }

        private void CarregarProdutos(string nome = "")
        {
            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = @"SELECT Id, Produto, Quantidade, DataFab, DataVal, DataReceb 
                                     FROM RegistroProduto
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
