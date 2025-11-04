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
using StockManager.DAL;

namespace StockManager.UI
{
    public partial class FrmLogin : Form
    {
        private readonly UserBLL _usuarioBLL = new UserBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click_1(object sender, EventArgs e)
        {
            // Desabilita o botão para evitar múltiplos cliques
            BtnLogin.Enabled = false;

            string login = TxbLogin.Text.Trim(); // Corrigido: TxtLogin
            string senha = TxbPassword.Text.Trim(); // Corrigido: TxtSenha

            // Validação de campos obrigatórios
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnLogin.Enabled = true;
                return;
            }

            try
            {
                // CORREÇÃO: Criar conexão e passar como parâmetro
                using (var conexao = new ConexaoBD().AbrirConexao())
                {
                    bool loginValido = await Task.Run(() =>
                        _usuarioBLL.ValidarLogin(login, senha, conexao));

                    if (loginValido)
                    {
                        // Abre o menu principal
                        FrmMenu menu = new FrmMenu(Sessao.NivelAcesso, Sessao.UsuarioID, Sessao.NomeUsuario);
                        this.Hide();
                        menu.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar login: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reabilita o botão independente do resultado
                BtnLogin.Enabled = true;
            }
        }
    }
}