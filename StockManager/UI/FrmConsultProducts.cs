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

namespace StockManager
{
    public partial class FrmConsultProducts : Form
    {
        string usuario = Sessao.NomeUsuario;
        private string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";
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
            ProductBLL bll = new ProductBLL();
            DgvConsultProducts.DataSource = bll.ObterProdutos();
            CarregarProdutos(null);
            DgvConsultProducts.EnableHeadersVisualStyles = false;
            DgvConsultProducts.DefaultCellStyle.SelectionBackColor = Color.Blue;
            DgvConsultProducts.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void BtnRechargeConsultProducts_Click(object sender, EventArgs e)
        {
            TxbBuscarNome.Clear();
            CarregarProdutos(null);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarProdutos(TxbBuscarNome.Text?.Trim());
            string query = "SELECT * FROM RegistroProduto WHERE 1=1";

            if (!string.IsNullOrWhiteSpace(TxbBuscarNome.Text))
                query += " AND Produto LIKE @Nome";

            if (chkLowStock.Checked)
                query += " AND Quantidade < 10"; // exemplo de estoque baixo

            if (chkExpirySoon.Checked)
                query += " AND DataVal <= DATEADD(DAY, 30, GETDATE())"; // próximos 30 dias

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrWhiteSpace(TxbBuscarNome.Text))
                    cmd.Parameters.AddWithValue("@Nome", "%" + TxbBuscarNome.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvConsultProducts.DataSource = dt;
            }
            if(chkExpirySoon.Checked)
                ChangeCellColor();
        }

        private void ChangeCellColor()
        {
            foreach (DataGridViewRow row in DgvConsultProducts.Rows)
            {
                if (row.Cells[4] != null)
                {
                    DateTime validade;
                    DateTime.TryParse(row.Cells[4].Value.ToString(), out validade);

                    if (validade < DateTime.Now)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;       // Vencido
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (validade < DateTime.Now.AddDays(30))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;    // Perto de vencer
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }

            }
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
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = DgvConsultProducts.Rows[e.RowIndex];

                int id = int.Parse(row.Cells[0].Value.ToString());
                string produto = row.Cells[1].Value.ToString();
                int quantidade = int.Parse(row.Cells[2].Value.ToString());
                DateTime dataFab = DateTime.Parse(row.Cells[3].Value.ToString());
                DateTime dataVal = DateTime.Parse(row.Cells[4].Value.ToString());
                DateTime dataReceb = DateTime.Parse(row.Cells[5].Value.ToString());

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
                SecurityHelper.RegistrarLog($"Atualizou produto ID {id}");
                MessageBox.Show("Produto atualizado com sucesso!");

            }
        }

        private void DgvConsultProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsultProducts.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string produto = DgvConsultProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                int id = int.Parse(DgvConsultProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show($"Deseja excluir o produto {produto}?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SecurityHelper.RegistrarLog($"Excluiu produto ID {id}");
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
                    DgvConsultProducts.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Produto excluído com sucesso!");
                }
            }
        }
        private void DgvConsultProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsultProducts.Columns[e.ColumnIndex].Name == "DataVal")
            {
                DateTime validade;
                if (DateTime.TryParse(DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out validade))
                {
                    if (validade < DateTime.Now)
                    {
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;       // Vencido
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                    }
                    else if (validade < DateTime.Now.AddDays(30))
                    {
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;    // Perto de vencer
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void chkExpirySoon_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCellColor();
        }
    }
}
