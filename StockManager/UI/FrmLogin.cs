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

        private async void BtnProduct_Click(object sender, EventArgs e)
        {
            BtnLogin.Enabled = false;

            string usuario = TxbLogin.Text.Trim();
            string senha = TxbPassword.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                BtnLogin.Enabled = true;
                return;
            }

            UserDAL userDAL = new UserDAL();

            // Executa o login em outra thread (sem travar a interface)
            string messageReturned = await Task.Run(() => userDAL.LoginVerification(usuario, senha));

            MessageBox.Show(messageReturned);

            if (Sessao.UsuarioId != 0)
            {
                FrmMenu menu = new FrmMenu(Sessao.NivelAcesso, Sessao.UsuarioId, Sessao.NomeUsuario);
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }

            BtnLogin.Enabled = true;
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