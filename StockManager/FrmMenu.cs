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
        private readonly bool isAdmin;
        public FrmMenu(string usuario)
        {
            InitializeComponent();

            if (usuario.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                isAdmin = true;
            else
                isAdmin = false;
        }
        private void FrmMenu_Load_1(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                menuCadastrarProduto.Enabled = false;
                menuCadastrarProduto.Visible = false;
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

    }
}
