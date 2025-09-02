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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            string usuario = TxbNewUser.Text;
            string senha = TxbNewPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = "INSERT INTO Usuarios (Usuario, Senha) VALUES (@usuario, @senha)";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuário cadastrado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos
                        TxbNewUser.Clear();
                        TxbNewPassword.Clear();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // violação UNIQUE (usuário já existe)
                        MessageBox.Show("Este usuário já existe!");
                    else
                        MessageBox.Show("Erro no banco: " + ex.Message);
                }
            }
        }
    }
}
