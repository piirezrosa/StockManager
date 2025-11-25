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
    public partial class FrmCadastro : Form
    {
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
                string.IsNullOrWhiteSpace(CmbNivelAcesso.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!");
                return;
            }
            User u = new User
            {
                Name = TxbNewName.Text,
                Login = TxbNewLogin.Text,
                Password = TxbNewPassword.Text,
                AccessLevel = CmbNivelAcesso.Text
            };

            try
            {
                UserBLL bll = new UserBLL();
                bll.CadastrarUsuario(u);
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
