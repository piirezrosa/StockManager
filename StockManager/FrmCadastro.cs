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
        string usuario = Sessao.NomeUsuario;
        public FrmCadastro()
        {
            InitializeComponent();
            CmbNivelAcesso.Items.Add("Admin");
            CmbNivelAcesso.Items.Add("Operador");
        }
        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxbNewName.Text) ||
                string.IsNullOrWhiteSpace(TxbNewLogin.Text) ||
                string.IsNullOrWhiteSpace(TxbNewPassword.Text) ||
                CmbNivelAcesso.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string connectionString =
                "Data Source=sqlexpress;Initial Catalog=CJ3027597PR2;User Id=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (Nome, Login, Senha, NivelAcesso) VALUES (@Nome, @Login, @Senha, @NivelAcesso)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", TxbNewName.Text);
                cmd.Parameters.AddWithValue("@Login", TxbNewLogin.Text);
                cmd.Parameters.AddWithValue("@Senha", TxbNewPassword.Text); // depois pode aplicar hash
                cmd.Parameters.AddWithValue("@NivelAcesso", CmbNivelAcesso.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }

            TxbNewName.Clear();
            TxbNewLogin.Clear();
            TxbNewPassword.Clear();
            CmbNivelAcesso.SelectedIndex = -1;
        }
    }
}
