namespace StockManager
{
    partial class FrmStock
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxbLogin = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.PbxLogin = new System.Windows.Forms.PictureBox();
            this.BtnCadastrarNovo = new System.Windows.Forms.Button();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnConsultProducts = new System.Windows.Forms.Button();
            this.LblConsultProducts = new System.Windows.Forms.Label();
            this.PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(24, 18);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(79, 13);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login e Senha:";
            // 
            // TxbLogin
            // 
            this.TxbLogin.Location = new System.Drawing.Point(14, 34);
            this.TxbLogin.Name = "TxbLogin";
            this.TxbLogin.Size = new System.Drawing.Size(100, 20);
            this.TxbLogin.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(120, 44);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Fazer Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(14, 60);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Size = new System.Drawing.Size(100, 20);
            this.TxbPassword.TabIndex = 3;
            this.TxbPassword.UseSystemPasswordChar = true;
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.SystemColors.Control;
            this.PnlLogin.Controls.Add(this.LblLogin);
            this.PnlLogin.Controls.Add(this.TxbPassword);
            this.PnlLogin.Controls.Add(this.TxbLogin);
            this.PnlLogin.Controls.Add(this.BtnLogin);
            this.PnlLogin.Location = new System.Drawing.Point(189, 233);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(200, 100);
            this.PnlLogin.TabIndex = 4;
            // 
            // PbxLogin
            // 
            this.PbxLogin.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogin.Image")));
            this.PbxLogin.Location = new System.Drawing.Point(189, 35);
            this.PbxLogin.Name = "PbxLogin";
            this.PbxLogin.Size = new System.Drawing.Size(200, 192);
            this.PbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogin.TabIndex = 5;
            this.PbxLogin.TabStop = false;
            // 
            // BtnCadastrarNovo
            // 
            this.BtnCadastrarNovo.Location = new System.Drawing.Point(489, 365);
            this.BtnCadastrarNovo.Name = "BtnCadastrarNovo";
            this.BtnCadastrarNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrarNovo.TabIndex = 4;
            this.BtnCadastrarNovo.Text = "Cadastre-se";
            this.BtnCadastrarNovo.UseVisualStyleBackColor = true;
            this.BtnCadastrarNovo.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Location = new System.Drawing.Point(471, 349);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(114, 13);
            this.LblCadastro.TabIndex = 6;
            this.LblCadastro.Text = "Não tem um cadastro?";
            // 
            // BtnConsultProducts
            // 
            this.BtnConsultProducts.Location = new System.Drawing.Point(39, 365);
            this.BtnConsultProducts.Name = "BtnConsultProducts";
            this.BtnConsultProducts.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultProducts.TabIndex = 7;
            this.BtnConsultProducts.Text = "Consultar";
            this.BtnConsultProducts.UseVisualStyleBackColor = true;
            this.BtnConsultProducts.Click += new System.EventHandler(this.BtnConsultProducts_Click);
            // 
            // LblConsultProducts
            // 
            this.LblConsultProducts.AutoSize = true;
            this.LblConsultProducts.Location = new System.Drawing.Point(12, 348);
            this.LblConsultProducts.Name = "LblConsultProducts";
            this.LblConsultProducts.Size = new System.Drawing.Size(150, 13);
            this.LblConsultProducts.TabIndex = 8;
            this.LblConsultProducts.Text = "Deseja consultar os produtos?";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(597, 400);
            this.Controls.Add(this.LblConsultProducts);
            this.Controls.Add(this.BtnConsultProducts);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.BtnCadastrarNovo);
            this.Controls.Add(this.PbxLogin);
            this.Controls.Add(this.PnlLogin);
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Estoque";
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TxbLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.PictureBox PbxLogin;
        private System.Windows.Forms.Button BtnCadastrarNovo;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Button BtnConsultProducts;
        private System.Windows.Forms.Label LblConsultProducts;
    }
}

