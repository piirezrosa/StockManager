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
    public partial class FrmCadastroFunc : Form
    {
        public FrmCadastroFunc()
        {
            InitializeComponent();
            CmbAcessoCadastroFunc.Items.Add("Admin");
            CmbAcessoCadastroFunc.Items.Add("Operador");
        }

        private void BtnCadastroFunc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxbNomeCadastroFunc.Text) ||
                string.IsNullOrWhiteSpace(TxbLoginCadastroFunc.Text) ||
                string.IsNullOrWhiteSpace(TxbSenhaCadastroFunc.Text) ||
                CmbAcessoCadastroFunc.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (Nome, Login, Senha, NivelAcesso) VALUES (@Nome, @Login, @Senha, @NivelAcesso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", TxbNomeCadastroFunc.Text);
                cmd.Parameters.AddWithValue("@Login", TxbLoginCadastroFunc.Text);
                cmd.Parameters.AddWithValue("@Senha", TxbSenhaCadastroFunc.Text); // depois pode aplicar hash
                cmd.Parameters.AddWithValue("@NivelAcesso", CmbAcessoCadastroFunc.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                LogHelper.RegistrarLog("Cadastrou usuário");
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }

            TxbNomeCadastroFunc.Clear();
            TxbLoginCadastroFunc.Clear();
            TxbSenhaCadastroFunc.Clear();
            CmbAcessoCadastroFunc.SelectedIndex = -1;
        }
    }
}
