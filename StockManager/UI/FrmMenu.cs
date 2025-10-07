using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
    public partial class FrmMenu : Form
    {
        private string nivelAcesso;
        private int usuarioId;
        private string nomeUsuario;
        public FrmMenu(string nivel, int id, string nome)
        {
            InitializeComponent();
            this.nivelAcesso = nivel;
            this.usuarioId = id;
            this.nomeUsuario = nome;
        }
        private void FrmMenu_Load_1(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuário: {nomeUsuario} ({nivelAcesso})";

            if (nivelAcesso == "Operador")
            {
                menuCadastrarProduto.Enabled = false;
                menuCadastrarUsuario.Enabled = false;
            }
        }
        private void menuCadastrarProduto_Click_1(object sender, EventArgs e)
        {
            FrmRegisterProduct frm = new FrmRegisterProduct();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void menuConsultarProduto_Click_1(object sender, EventArgs e)
        {
            FrmConsultProducts frm = new FrmConsultProducts();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void menuSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuCadastrarUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastroFunc frm = new FrmCadastroFunc();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
