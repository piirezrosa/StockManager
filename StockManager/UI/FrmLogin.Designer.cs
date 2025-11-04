namespace StockManager.UI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PbxLogin = new System.Windows.Forms.PictureBox();
            this.BtnCadastrarNovo = new System.Windows.Forms.Button();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxbLogin = new System.Windows.Forms.TextBox();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxLogin
            // 
            this.PbxLogin.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogin.Image")));
            this.PbxLogin.Location = new System.Drawing.Point(-8, -2);
            this.PbxLogin.Name = "PbxLogin";
            this.PbxLogin.Size = new System.Drawing.Size(613, 350);
            this.PbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogin.TabIndex = 5;
            this.PbxLogin.TabStop = false;
            // 
            // BtnCadastrarNovo
            // 
            this.BtnCadastrarNovo.Location = new System.Drawing.Point(24, 309);
            this.BtnCadastrarNovo.Name = "BtnCadastrarNovo";
            this.BtnCadastrarNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrarNovo.TabIndex = 3;
            this.BtnCadastrarNovo.Text = "Cadastre-se";
            this.BtnCadastrarNovo.UseVisualStyleBackColor = true;
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Location = new System.Drawing.Point(9, 293);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(114, 13);
            this.LblCadastro.TabIndex = 6;
            this.LblCadastro.Text = "Não tem um cadastro?";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(353, 226);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Fazer Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // TxbLogin
            // 
            this.TxbLogin.Location = new System.Drawing.Point(247, 216);
            this.TxbLogin.Name = "TxbLogin";
            this.TxbLogin.Size = new System.Drawing.Size(100, 20);
            this.TxbLogin.TabIndex = 0;
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(247, 242);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Size = new System.Drawing.Size(100, 20);
            this.TxbPassword.TabIndex = 1;
            this.TxbPassword.UseSystemPasswordChar = true;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(244, 197);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(110, 16);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login e Senha:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(602, 344);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.TxbLogin);
            this.Controls.Add(this.TxbPassword);
            this.Controls.Add(this.BtnCadastrarNovo);
            this.Controls.Add(this.PbxLogin);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PbxLogin;
        private System.Windows.Forms.Button BtnCadastrarNovo;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxbLogin;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label LblLogin;
    }
}

