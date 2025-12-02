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
    public partial class FrmCadastroFunc : Form
    {
        private readonly UserBLL userBLL = new UserBLL();
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

            User newUser = new User()
            {
                Name = TxbNomeCadastroFunc.Text,
                Login = TxbLoginCadastroFunc.Text,
                Password = TxbSenhaCadastroFunc.Text,
                AccessLevel = CmbAcessoCadastroFunc.Text
            };

            try
            {
                userBLL.CadastrarUsuario(newUser);

                MessageBox.Show("Usuário cadastrado com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SecurityHelper.RegistrarLog("Cadastro de usuário realizado com sucesso!");
                TxbNomeCadastroFunc.Clear();
                TxbLoginCadastroFunc.Clear();
                TxbSenhaCadastroFunc.Clear();
                CmbAcessoCadastroFunc.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
