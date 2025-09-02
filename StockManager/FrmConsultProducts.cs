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
        private string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";
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

        private void DgvConsultProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Pega a linha alterada
            if (e.RowIndex >0 ) {
            DataGridViewRow row = DgvConsultProducts.Rows[e.RowIndex];

                int id = int.Parse(row.Cells[0].Value.ToString());
                string produto = row.Cells[1].Value.ToString();
                int quantidade = int.Parse(row.Cells[2].Value.ToString());
                DateTime dataFab = DateTime.Parse(row.Cells[3].Value.ToString());
                DateTime dataVal = DateTime.Parse(row.Cells[4].Value.ToString());
                DateTime dataReceb = DateTime.Parse(row.Cells[5].Value.ToString());

                // Atualiza o banco
                string query = @"UPDATE RegistroProduto 
                     SET Produto = @Produto, Quantidade = @Quantidade, DataFab = @DataFab, DataVal = @DataVal, DataReceb = @DataReceb
                     WHERE Id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Produto", produto);
                        cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@DataFab", dataFab);
                        cmd.Parameters.AddWithValue("@DataVal", dataVal);
                        cmd.Parameters.AddWithValue("@DataReceb", dataReceb);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Produto atualizado com sucesso!");

            }
        }

        private void DgvConsultProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsultProducts.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string produto = DgvConsultProducts.Rows[e.RowIndex].Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show($"Deseja excluir o produto {produto}?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove do banco
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM RegistroProduto WHERE Produto = @Produto";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Produto", produto);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Remove da grid
                    DgvConsultProducts.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Produto excluído com sucesso!");
                }
            }
        }
    }
}
