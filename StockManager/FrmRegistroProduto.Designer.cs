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
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblDataFab = new System.Windows.Forms.Label();
            this.LblDataVal = new System.Windows.Forms.Label();
            this.LblDataReceb = new System.Windows.Forms.Label();
            this.PnlRegisterProduct = new System.Windows.Forms.Panel();
            this.DtpDataReceb = new System.Windows.Forms.DateTimePicker();
            this.DtpDataVal = new System.Windows.Forms.DateTimePicker();
            this.DtpDataFab = new System.Windows.Forms.DateTimePicker();
            this.PbxRegisterProduct = new System.Windows.Forms.PictureBox();
            this.registroProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3027597PR2DataSet = new StockManager.CJ3027597PR2DataSet();
            this.registroProdutoTableAdapter = new StockManager.CJ3027597PR2DataSetTableAdapters.RegistroProdutoTableAdapter();
            this.LblRegisterProduct = new System.Windows.Forms.Label();
            this.PnlRegisterProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRegisterProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027597PR2DataSet)).BeginInit();
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
            this.TxbProduct.Size = new System.Drawing.Size(135, 20);
            this.TxbProduct.TabIndex = 1;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(239, 67);
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
            this.TxbQuantity.Size = new System.Drawing.Size(135, 20);
            this.TxbQuantity.TabIndex = 3;
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
            // PnlRegisterProduct
            // 
            this.PnlRegisterProduct.BackColor = System.Drawing.SystemColors.Control;
            this.PnlRegisterProduct.Controls.Add(this.DtpDataReceb);
            this.PnlRegisterProduct.Controls.Add(this.DtpDataVal);
            this.PnlRegisterProduct.Controls.Add(this.DtpDataFab);
            this.PnlRegisterProduct.Controls.Add(this.TxbProduct);
            this.PnlRegisterProduct.Controls.Add(this.LblDataReceb);
            this.PnlRegisterProduct.Controls.Add(this.TxbQuantity);
            this.PnlRegisterProduct.Controls.Add(this.BtnRegister);
            this.PnlRegisterProduct.Controls.Add(this.LblQuantity);
            this.PnlRegisterProduct.Controls.Add(this.LblProduct);
            this.PnlRegisterProduct.Controls.Add(this.LblDataFab);
            this.PnlRegisterProduct.Controls.Add(this.LblDataVal);
            this.PnlRegisterProduct.Location = new System.Drawing.Point(229, 131);
            this.PnlRegisterProduct.Name = "PnlRegisterProduct";
            this.PnlRegisterProduct.Size = new System.Drawing.Size(327, 161);
            this.PnlRegisterProduct.TabIndex = 11;
            // 
            // DtpDataReceb
            // 
            this.DtpDataReceb.Location = new System.Drawing.Point(98, 127);
            this.DtpDataReceb.Name = "DtpDataReceb";
            this.DtpDataReceb.Size = new System.Drawing.Size(135, 20);
            this.DtpDataReceb.TabIndex = 17;
            // 
            // DtpDataVal
            // 
            this.DtpDataVal.Location = new System.Drawing.Point(98, 100);
            this.DtpDataVal.Name = "DtpDataVal";
            this.DtpDataVal.Size = new System.Drawing.Size(135, 20);
            this.DtpDataVal.TabIndex = 16;
            // 
            // DtpDataFab
            // 
            this.DtpDataFab.Location = new System.Drawing.Point(98, 69);
            this.DtpDataFab.Name = "DtpDataFab";
            this.DtpDataFab.Size = new System.Drawing.Size(135, 20);
            this.DtpDataFab.TabIndex = 15;
            // 
            // PbxRegisterProduct
            // 
            this.PbxRegisterProduct.Image = ((System.Drawing.Image)(resources.GetObject("PbxRegisterProduct.Image")));
            this.PbxRegisterProduct.Location = new System.Drawing.Point(627, 307);
            this.PbxRegisterProduct.Name = "PbxRegisterProduct";
            this.PbxRegisterProduct.Size = new System.Drawing.Size(216, 214);
            this.PbxRegisterProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxRegisterProduct.TabIndex = 12;
            this.PbxRegisterProduct.TabStop = false;
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
            // registroProdutoTableAdapter
            // 
            this.registroProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // LblRegisterProduct
            // 
            this.LblRegisterProduct.AutoSize = true;
            this.LblRegisterProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegisterProduct.Location = new System.Drawing.Point(307, 104);
            this.LblRegisterProduct.Name = "LblRegisterProduct";
            this.LblRegisterProduct.Size = new System.Drawing.Size(183, 24);
            this.LblRegisterProduct.TabIndex = 14;
            this.LblRegisterProduct.Text = "Registre o produto";
            // 
            // FrmRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRegisterProduct);
            this.Controls.Add(this.PbxRegisterProduct);
            this.Controls.Add(this.PnlRegisterProduct);
            this.Name = "FrmRegisterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Produtos";
            this.Load += new System.EventHandler(this.FrmRegisterProduct_Load);
            this.PnlRegisterProduct.ResumeLayout(false);
            this.PnlRegisterProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRegisterProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027597PR2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.TextBox TxbProduct;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TxbQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblDataFab;
        private System.Windows.Forms.Label LblDataVal;
        private System.Windows.Forms.Label LblDataReceb;
        private System.Windows.Forms.Panel PnlRegisterProduct;
        private System.Windows.Forms.PictureBox PbxRegisterProduct;
        private CJ3027597PR2DataSet cJ3027597PR2DataSet;
        private System.Windows.Forms.BindingSource registroProdutoBindingSource;
        private CJ3027597PR2DataSetTableAdapters.RegistroProdutoTableAdapter registroProdutoTableAdapter;
        private System.Windows.Forms.Label LblRegisterProduct;
        private System.Windows.Forms.DateTimePicker DtpDataFab;
        private System.Windows.Forms.DateTimePicker DtpDataReceb;
        private System.Windows.Forms.DateTimePicker DtpDataVal;
    }
}