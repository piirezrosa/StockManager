using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if(TxbLogin.Text == "Admin" && TxbPassword.Text == "Admin")
            {
                string user = TxbLogin.Text;
                string password = TxbPassword.Text;
                MessageBox.Show(
                $"Usuário: {user}\nSenha: {password}",
                "Dados Digitados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                FrmRegister product = new FrmRegister();
                this.Visible = false;
                product.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Você errou seu login ou senha");
            }
        }
    }
}