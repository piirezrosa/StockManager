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
    public partial class FrmRegisterProduct : Form
    {
        public FrmRegisterProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string Product = TxbProduct.Text;
            string Quantity = TxbQuantity.Text;
            string Data_Fab = TxbDataFab.Text;
            string Data_Val = TxbDataVal.Text;
            string Data_Receb = TxbDataReceb.Text;
            MessageBox.Show(
                $"Produto registrado com sucesso!",
                "Dados Digitados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FrmRegisterProduct_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cJ3027597PR2DataSet.RegistroProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.registroProdutoTableAdapter.Fill(this.cJ3027597PR2DataSet.RegistroProduto);

        }
    }
}
