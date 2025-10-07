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
            UserDAL userDAL = new UserDAL();
            string messageReturned = userDAL.LoginVerification(usuario, senha);
            MessageBox.Show(messageReturned);
            if (Sessao.UsuarioId != 0)
            {
                FrmMenu menu = new FrmMenu(Sessao.NivelAcesso, Sessao.UsuarioId, Sessao.NomeUsuario);
                this.Hide();
                menu.ShowDialog();
                this.Show();
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