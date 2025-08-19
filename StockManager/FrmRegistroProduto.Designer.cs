namespace StockManager
{
    partial class FrmRegisterProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterProduct));
            this.LblProduct = new System.Windows.Forms.Label();
            this.TxbProduct = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TxbQuantity = new System.Windows.Forms.TextBox();
            this.TxbDataFab = new System.Windows.Forms.TextBox();
            this.TxbDataVal = new System.Windows.Forms.TextBox();
            this.TxbDataReceb = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblDataFab = new System.Windows.Forms.Label();
            this.LblDataVal = new System.Windows.Forms.Label();
            this.LblDataReceb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvRegister = new System.Windows.Forms.DataGridView();
            this.cJ3027597PR2DataSet = new StockManager.CJ3027597PR2DataSet();
            this.registroProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroProdutoTableAdapter = new StockManager.CJ3027597PR2DataSetTableAdapters.RegistroProdutoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027597PR2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.Location = new System.Drawing.Point(34, 19);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(44, 13);
            this.LblProduct.TabIndex = 0;
            this.LblProduct.Text = "Produto";
            // 
            // TxbProduct
            // 
            this.TxbProduct.Location = new System.Drawing.Point(98, 16);
            this.TxbProduct.Name = "TxbProduct";
            this.TxbProduct.Size = new System.Drawing.Size(100, 20);
            this.TxbProduct.TabIndex = 1;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(204, 67);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "Registrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TxbQuantity
            // 
            this.TxbQuantity.Location = new System.Drawing.Point(98, 43);
            this.TxbQuantity.Name = "TxbQuantity";
            this.TxbQuantity.Size = new System.Drawing.Size(100, 20);
            this.TxbQuantity.TabIndex = 3;
            // 
            // TxbDataFab
            // 
            this.TxbDataFab.Location = new System.Drawing.Point(98, 70);
            this.TxbDataFab.Name = "TxbDataFab";
            this.TxbDataFab.Size = new System.Drawing.Size(100, 20);
            this.TxbDataFab.TabIndex = 4;
            // 
            // TxbDataVal
            // 
            this.TxbDataVal.Location = new System.Drawing.Point(98, 97);
            this.TxbDataVal.Name = "TxbDataVal";
            this.TxbDataVal.Size = new System.Drawing.Size(100, 20);
            this.TxbDataVal.TabIndex = 5;
            // 
            // TxbDataReceb
            // 
            this.TxbDataReceb.Location = new System.Drawing.Point(98, 124);
            this.TxbDataReceb.Name = "TxbDataReceb";
            this.TxbDataReceb.Size = new System.Drawing.Size(100, 20);
            this.TxbDataReceb.TabIndex = 6;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(34, 46);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(62, 13);
            this.LblQuantity.TabIndex = 7;
            this.LblQuantity.Text = "Quantidade";
            this.LblQuantity.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblDataFab
            // 
            this.LblDataFab.AutoSize = true;
            this.LblDataFab.Location = new System.Drawing.Point(34, 73);
            this.LblDataFab.Name = "LblDataFab";
            this.LblDataFab.Size = new System.Drawing.Size(51, 13);
            this.LblDataFab.TabIndex = 8;
            this.LblDataFab.Text = "Data Fab";
            // 
            // LblDataVal
            // 
            this.LblDataVal.AutoSize = true;
            this.LblDataVal.Location = new System.Drawing.Point(34, 100);
            this.LblDataVal.Name = "LblDataVal";
            this.LblDataVal.Size = new System.Drawing.Size(48, 13);
            this.LblDataVal.TabIndex = 9;
            this.LblDataVal.Text = "Data Val";
            // 
            // LblDataReceb
            // 
            this.LblDataReceb.AutoSize = true;
            this.LblDataReceb.Location = new System.Drawing.Point(34, 127);
            this.LblDataReceb.Name = "LblDataReceb";
            this.LblDataReceb.Size = new System.Drawing.Size(65, 13);
            this.LblDataReceb.TabIndex = 10;
            this.LblDataReceb.Text = "Data Receb";
            this.LblDataReceb.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TxbProduct);
            this.panel1.Controls.Add(this.LblDataReceb);
            this.panel1.Controls.Add(this.TxbQuantity);
            this.panel1.Controls.Add(this.LblQuantity);
            this.panel1.Controls.Add(this.LblProduct);
            this.panel1.Controls.Add(this.LblDataFab);
            this.panel1.Controls.Add(this.TxbDataVal);
            this.panel1.Controls.Add(this.TxbDataFab);
            this.panel1.Controls.Add(this.LblDataVal);
            this.panel1.Controls.Add(this.BtnRegister);
            this.panel1.Controls.Add(this.TxbDataReceb);
            this.panel1.Location = new System.Drawing.Point(249, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 161);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // DgvRegister
            // 
            this.DgvRegister.AutoGenerateColumns = false;
            this.DgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataFabDataGridViewTextBoxColumn,
            this.dataValDataGridViewTextBoxColumn,
            this.dataRecebDataGridViewTextBoxColumn});
            this.DgvRegister.DataSource = this.registroProdutoBindingSource;
            this.DgvRegister.Location = new System.Drawing.Point(12, 307);
            this.DgvRegister.Name = "DgvRegister";
            this.DgvRegister.Size = new System.Drawing.Size(543, 131);
            this.DgvRegister.TabIndex = 13;
            // 
            // cJ3027597PR2DataSet
            // 
            this.cJ3027597PR2DataSet.DataSetName = "CJ3027597PR2DataSet";
            this.cJ3027597PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroProdutoBindingSource
            // 
            this.registroProdutoBindingSource.DataMember = "RegistroProduto";
            this.registroProdutoBindingSource.DataSource = this.cJ3027597PR2DataSet;
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
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // dataFabDataGridViewTextBoxColumn
            // 
            this.dataFabDataGridViewTextBoxColumn.DataPropertyName = "DataFab";
            this.dataFabDataGridViewTextBoxColumn.HeaderText = "DataFab";
            this.dataFabDataGridViewTextBoxColumn.Name = "dataFabDataGridViewTextBoxColumn";
            // 
            // dataValDataGridViewTextBoxColumn
            // 
            this.dataValDataGridViewTextBoxColumn.DataPropertyName = "DataVal";
            this.dataValDataGridViewTextBoxColumn.HeaderText = "DataVal";
            this.dataValDataGridViewTextBoxColumn.Name = "dataValDataGridViewTextBoxColumn";
            // 
            // dataRecebDataGridViewTextBoxColumn
            // 
            this.dataRecebDataGridViewTextBoxColumn.DataPropertyName = "DataReceb";
            this.dataRecebDataGridViewTextBoxColumn.HeaderText = "DataReceb";
            this.dataRecebDataGridViewTextBoxColumn.Name = "dataRecebDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // FrmRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegisterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Produtos";
            this.Load += new System.EventHandler(this.FrmRegisterProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027597PR2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.TextBox TxbProduct;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TxbQuantity;
        private System.Windows.Forms.TextBox TxbDataFab;
        private System.Windows.Forms.TextBox TxbDataVal;
        private System.Windows.Forms.TextBox TxbDataReceb;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblDataFab;
        private System.Windows.Forms.Label LblDataVal;
        private System.Windows.Forms.Label LblDataReceb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvRegister;
        private CJ3027597PR2DataSet cJ3027597PR2DataSet;
        private System.Windows.Forms.BindingSource registroProdutoBindingSource;
        private CJ3027597PR2DataSetTableAdapters.RegistroProdutoTableAdapter registroProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}