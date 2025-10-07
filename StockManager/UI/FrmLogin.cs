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
            string usuario = TxbLogin.Text.Trim();
            string senha = TxbPassword.Text.Trim();

            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    bool loginValido = SegurancaHelper.ValidarLogin(TxbLogin.Text, TxbPassword.Text, conn);

                    if (loginValido)
                    {
                        MessageBox.Show($"Bem-vindo {Sessao.NomeUsuario}!");
                        FrmMenu menu = new FrmMenu(Sessao.NivelAcesso, Sessao.UsuarioId, Sessao.NomeUsuario);
                        this.Hide();
                        menu.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");
                    }
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