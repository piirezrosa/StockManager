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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            string usuario = TxbLogin.Text;
            string senha = TxbPassword.Text;

            // String de conexão (ajuste Data Source para o nome/instância do seu SQL Server)
            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@usuario AND Senha=@senha";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        // Evita SQL Injection
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            FrmRegisterProduct product = new FrmRegisterProduct();
                            this.Visible = false;
                            product.ShowDialog();
                            this.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco: " + ex.Message);
                }
            }
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}