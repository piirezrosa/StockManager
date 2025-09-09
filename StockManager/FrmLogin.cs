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

            // String de conexão (ajuste Data Source para o nome/instância do seu SQL Server)
            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@usuario AND Senha=@senha";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    query = "SELECT * FROM Usuarios WHERE Login = @Login AND Senha = @Senha";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Login", TxbLogin.Text);
                    cmd.Parameters.AddWithValue("@Senha", TxbPassword.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nivel = reader["NivelAcesso"].ToString();
                        int usuarioId = Convert.ToInt32(reader["Id"]);
                        string nomeUsuario = reader["Nome"].ToString();

                        MessageBox.Show($"Bem-vindo, {nomeUsuario}!");

                        FrmMenu formMenu = new FrmMenu(nivel, usuarioId, nomeUsuario);
                        this.Visible = false;
                        formMenu.ShowDialog();
                        this.Visible = true;
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