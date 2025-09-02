namespace StockManager
{
    partial class FrmConsultProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultProducts));
            this.DgvConsultProducts = new System.Windows.Forms.DataGridView();
            this.registroProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3027597PR2DataSet = new StockManager.CJ3027597PR2DataSet();
            this.LblConsultProducts = new System.Windows.Forms.Label();
            this.BtnRechargeConsultProducts = new System.Windows.Forms.Button();
            this.PnlConsultProducts = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxbBuscarNome = new System.Windows.Forms.TextBox();
            this.PbxConsultProducts = new System.Windows.Forms.PictureBox();
            this.registroProdutoTableAdapter = new StockManager.CJ3027597PR2DataSetTableAdapters.RegistroProdutoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027597PR2DataSet)).BeginInit();
            this.PnlConsultProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxConsultProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultProducts
            // 
            this.DgvConsultProducts.AllowUserToAddRows = false;
            this.DgvConsultProducts.AutoGenerateColumns = false;
            this.DgvConsultProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataFabDataGridViewTextBoxColumn,
            this.dataValDataGridViewTextBoxColumn,
            this.dataRecebDataGridViewTextBoxColumn,
            this.Excluir});
            this.DgvConsultProducts.DataSource = this.registroProdutoBindingSource;
            this.DgvConsultProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvConsultProducts.Location = new System.Drawing.Point(21, 17);
            this.DgvConsultProducts.Name = "DgvConsultProducts";
            this.DgvConsultProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvConsultProducts.Size = new System.Drawing.Size(798, 191);
            this.DgvConsultProducts.TabIndex = 0;
            this.DgvConsultProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultProducts_CellContentClick);
            this.DgvConsultProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultProducts_CellValueChanged);
            // 
            // registroProdutoBindingSource
            // 
            this.registroProdutoBindingSource.DataMember = "RegistroProduto";
            this.registroProdutoBindingSource.DataSource = this.cJ3027597PR2DataSet;
            // 
            // cJ3027597PR2DataSet
            // 
            this.cJ3027597PR2DataSet.DataSetName = "CJ3027597PR2DataSet";
            this.cJ3027597PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblConsultProducts
            // 
            this.LblConsultProducts.AutoSize = true;
            this.LblConsultProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsultProducts.Location = new System.Drawing.Point(368, 9);
            this.LblConsultProducts.Name = "LblConsultProducts";
            this.LblConsultProducts.Size = new System.Drawing.Size(209, 24);
            this.LblConsultProducts.TabIndex = 1;
            this.LblConsultProducts.Text = "Consulta de produtos";
            // 
            // BtnRechargeConsultProducts
            // 
            this.BtnRechargeConsultProducts.Location = new System.Drawing.Point(824, 101);
            this.BtnRechargeConsultProducts.Name = "BtnRechargeConsultProducts";
            this.BtnRechargeConsultProducts.Size = new System.Drawing.Size(75, 23);
            this.BtnRechargeConsultProducts.TabIndex = 2;
            this.BtnRechargeConsultProducts.Text = "Recarregar";
            this.BtnRechargeConsultProducts.UseVisualStyleBackColor = true;
            // 
            // PnlConsultProducts
            // 
            this.PnlConsultProducts.BackColor = System.Drawing.SystemColors.Control;
            this.PnlConsultProducts.Controls.Add(this.BtnBuscar);
            this.PnlConsultProducts.Controls.Add(this.DgvConsultProducts);
            this.PnlConsultProducts.Controls.Add(this.TxbBuscarNome);
            this.PnlConsultProducts.Controls.Add(this.BtnRechargeConsultProducts);
            this.PnlConsultProducts.Location = new System.Drawing.Point(12, 36);
            this.PnlConsultProducts.Name = "PnlConsultProducts";
            this.PnlConsultProducts.Size = new System.Drawing.Size(902, 245);
            this.PnlConsultProducts.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(127, 214);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxbBuscarNome
            // 
            this.TxbBuscarNome.Location = new System.Drawing.Point(21, 214);
            this.TxbBuscarNome.Name = "TxbBuscarNome";
            this.TxbBuscarNome.Size = new System.Drawing.Size(100, 20);
            this.TxbBuscarNome.TabIndex = 5;
            // 
            // PbxConsultProducts
            // 
            this.PbxConsultProducts.Image = ((System.Drawing.Image)(resources.GetObject("PbxConsultProducts.Image")));
            this.PbxConsultProducts.Location = new System.Drawing.Point(786, 303);
            this.PbxConsultProducts.Name = "PbxConsultProducts";
            this.PbxConsultProducts.Size = new System.Drawing.Size(215, 225);
            this.PbxConsultProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxConsultProducts.TabIndex = 4;
            this.PbxConsultProducts.TabStop = false;
            // 
            // registroProdutoTableAdapter
            // 
            this.registroProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.Width = 250;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 75;
            // 
            // dataFabDataGridViewTextBoxColumn
            // 
            this.dataFabDataGridViewTextBoxColumn.DataPropertyName = "DataFab";
            this.dataFabDataGridViewTextBoxColumn.HeaderText = "DataFab";
            this.dataFabDataGridViewTextBoxColumn.Name = "dataFabDataGridViewTextBoxColumn";
            this.dataFabDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataValDataGridViewTextBoxColumn
            // 
            this.dataValDataGridViewTextBoxColumn.DataPropertyName = "DataVal";
            this.dataValDataGridViewTextBoxColumn.HeaderText = "DataVal";
            this.dataValDataGridViewTextBoxColumn.Name = "dataValDataGridViewTextBoxColumn";
            this.dataValDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataRecebDataGridViewTextBoxColumn
            // 
            this.dataRecebDataGridViewTextBoxColumn.DataPropertyName = "DataReceb";
            this.dataRecebDataGridViewTextBoxColumn.HeaderText = "DataReceb";
            this.dataRecebDataGridViewTextBoxColumn.Name = "dataRecebDataGridViewTextBoxColumn";
            this.dataRecebDataGridViewTextBoxColumn.Width = 110;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmConsultProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(948, 453);
            this.Controls.Add(this.PnlConsultProducts);
            this.Controls.Add(this.LblConsultProducts);
            this.Controls.Add(this.PbxConsultProducts);
            this.Name = "FrmConsultProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultProducts";
            this.Load += new System.EventHandler(this.FrmConsultProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027597PR2DataSet)).EndInit();
            this.PnlConsultProducts.ResumeLayout(false);
            this.PnlConsultProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxConsultProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsultProducts;
        private System.Windows.Forms.Label LblConsultProducts;
        private System.Windows.Forms.Button BtnRechargeConsultProducts;
        private System.Windows.Forms.Panel PnlConsultProducts;
        private System.Windows.Forms.PictureBox PbxConsultProducts;
        private CJ3027597PR2DataSet cJ3027597PR2DataSet;
        private System.Windows.Forms.BindingSource registroProdutoBindingSource;
        private CJ3027597PR2DataSetTableAdapters.RegistroProdutoTableAdapter registroProdutoTableAdapter;
        private System.Windows.Forms.TextBox TxbBuscarNome;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}