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
    public partial class FrmConsultProducts : Form
    {
        ProductBLL bll = new ProductBLL();
        public FrmConsultProducts()
        {
            InitializeComponent();

            this.Load += FrmConsultProducts_Load;
            BtnBuscar.Click += BtnBuscar_Click;
            BtnRechargeConsultProducts.Click += BtnRechargeConsultProducts_Click;

            TxbBuscarNome.KeyDown += (s, e) => 
            { if (e.KeyCode == Keys.Enter) 
                  BtnBuscar.PerformClick(); 
            };

            DgvConsultProducts.CellValueChanged += DgvConsultProducts_CellValueChanged;
            DgvConsultProducts.CellContentClick += DgvConsultProducts_CellContentClick;
        }

        private void FrmConsultProducts_Load(object sender, EventArgs e)
        {
            CarregarProdutos();

            DgvConsultProducts.EnableHeadersVisualStyles = false;
            DgvConsultProducts.DefaultCellStyle.SelectionBackColor = Color.Blue;
            DgvConsultProducts.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void BtnRechargeConsultProducts_Click(object sender, EventArgs e)
        {
            TxbBuscarNome.Clear();
            CarregarProdutos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarProdutos(TxbBuscarNome.Text?.Trim());
        }

        private void ChangeCellColor()
        {
            foreach (DataGridViewRow row in DgvConsultProducts.Rows)
            {
                if (row.Cells[4] != null)
                {
                    DateTime validade;
                    DateTime.TryParse(row.Cells[4].Value.ToString(), out validade);

                    if (validade < DateTime.Now)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;       // Vencido
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (validade < DateTime.Now.AddDays(30))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;    // Perto de vencer
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }

            }
        }

        private void CarregarProdutos(string filterName = "")
        {
            var lista = bll.ObtainProducts();

            if (!string.IsNullOrWhiteSpace(filterName))
                lista = lista.Where(p => !string.IsNullOrEmpty(p.Nome) && p.Nome.IndexOf(filterName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (chkLowStock.Checked)
                lista = lista.Where(p => p.Quantidade < 10).ToList();

            if (chkExpirySoon.Checked)
                lista = lista.Where(p => p.DataValidade <= DateTime.Now.AddDays(30)).ToList();
        
            DgvConsultProducts.DataSource = lista;

            if (chkExpirySoon.Checked)
                ChangeCellColor();
        }

        private void DgvConsultProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvConsultProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsultProducts.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string produto = DgvConsultProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                int id = int.Parse(DgvConsultProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show($"Deseja excluir o produto {produto}?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SecurityHelper.RegistrarLog($"Excluiu produto ID {id}");
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM RegistroProduto WHERE Produto = @Produto";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Produto", produto);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    DgvConsultProducts.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Produto excluído com sucesso!");
                }
            }
        }
        private void DgvConsultProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvConsultProducts.Columns[e.ColumnIndex].Name == "DataVal")
            {
                DateTime validade;
                if (DateTime.TryParse(DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out validade))
                {
                    if (validade < DateTime.Now)
                    {
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;       // Vencido
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                    }
                    else if (validade < DateTime.Now.AddDays(30))
                    {
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;    // Perto de vencer
                        DgvConsultProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void chkExpirySoon_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCellColor();
        }
    }
}
