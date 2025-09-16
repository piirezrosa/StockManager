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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockManager
{
    public partial class FrmRegisterProduct : Form
    {
        public FrmRegisterProduct()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string produto = TxbProduct.Text;
            int quantidade;

            // validações
            if (string.IsNullOrWhiteSpace(produto))
            {
                MessageBox.Show("Informe o nome do produto!");
                return;
            }

            if (!int.TryParse(TxbQuantity.Text, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida!");
                return;
            }

            DateTime dataFab = DtpDataFab.Value;
            DateTime dataVal = DtpDataVal.Value;
            DateTime dataReceb = DtpDataReceb.Value;

            if (dataFab > DateTime.Now)
            {
                MessageBox.Show("A data de fabricação não pode ser no futuro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataVal <= dataFab)
            {
                MessageBox.Show("A data de validade deve ser maior que a data de fabricação!");
                return;
            }

            if (dataReceb > DateTime.Now)
            {
                MessageBox.Show("A data de recebimento não pode ser no futuro!"); ;
                return;
            }

            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = @"INSERT INTO RegistroProduto (Produto, Quantidade, DataFab, DataVal, DataReceb) 
                                     VALUES (@produto, @quantidade, @dataFab, @dataVal, @dataReceb)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@produto", produto);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@dataFab", dataFab);
                        cmd.Parameters.AddWithValue("@dataVal", dataVal);
                        cmd.Parameters.AddWithValue("@dataReceb", dataReceb);
                        cmd.ExecuteNonQuery();
                        LogHelper.RegistrarLog("Registrou Produto");
                        MessageBox.Show("Produto cadastrado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // limpa campos
                        TxbProduct.Clear();
                        TxbQuantity.Clear();
                        DtpDataFab.Value = DateTime.Now;
                        DtpDataVal.Value = DateTime.Now;
                        DtpDataReceb.Value = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar produto: " + ex.Message);
                }
            }
        }

        private void FrmRegisterProduct_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cJ3027597PR2DataSet.RegistroProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.registroProdutoTableAdapter.Fill(this.cJ3027597PR2DataSet.RegistroProduto);

        }
    }
}
