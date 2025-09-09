namespace StockManager
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.PbxNewUser = new System.Windows.Forms.PictureBox();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxbNewLogin = new System.Windows.Forms.TextBox();
            this.TxbNewName = new System.Windows.Forms.TextBox();
            this.TxbNewPassword = new System.Windows.Forms.TextBox();
            this.CmbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblNivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxNewUser
            // 
            this.PbxNewUser.Image = ((System.Drawing.Image)(resources.GetObject("PbxNewUser.Image")));
            this.PbxNewUser.Location = new System.Drawing.Point(-1, 0);
            this.PbxNewUser.Name = "PbxNewUser";
            this.PbxNewUser.Size = new System.Drawing.Size(732, 412);
            this.PbxNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNewUser.TabIndex = 1;
            this.PbxNewUser.TabStop = false;
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(310, 169);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(107, 20);
            this.LblCadastro.TabIndex = 7;
            this.LblCadastro.Text = "Cadastre-se";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(402, 218);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click_1);
            // 
            // TxbNewLogin
            // 
            this.TxbNewLogin.Location = new System.Drawing.Point(274, 218);
            this.TxbNewLogin.Name = "TxbNewLogin";
            this.TxbNewLogin.Size = new System.Drawing.Size(100, 20);
            this.TxbNewLogin.TabIndex = 5;
            // 
            // TxbNewName
            // 
            this.TxbNewName.Location = new System.Drawing.Point(274, 192);
            this.TxbNewName.Name = "TxbNewName";
            this.TxbNewName.Size = new System.Drawing.Size(100, 20);
            this.TxbNewName.TabIndex = 4;
            // 
            // TxbNewPassword
            // 
            this.TxbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNewPassword.Location = new System.Drawing.Point(274, 245);
            this.TxbNewPassword.Name = "TxbNewPassword";
            this.TxbNewPassword.PasswordChar = '*';
            this.TxbNewPassword.Size = new System.Drawing.Size(100, 20);
            this.TxbNewPassword.TabIndex = 8;
            this.TxbNewPassword.UseSystemPasswordChar = true;
            // 
            // CmbNivelAcesso
            // 
            this.CmbNivelAcesso.FormattingEnabled = true;
            this.CmbNivelAcesso.Location = new System.Drawing.Point(274, 272);
            this.CmbNivelAcesso.Name = "CmbNivelAcesso";
            this.CmbNivelAcesso.Size = new System.Drawing.Size(121, 21);
            this.CmbNivelAcesso.TabIndex = 9;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(225, 199);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(43, 13);
            this.LblNome.TabIndex = 10;
            this.LblNome.Text = "Nome:";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(225, 223);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(42, 13);
            this.LblLogin.TabIndex = 11;
            this.LblLogin.Text = "Login:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(221, 248);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(47, 13);
            this.LblSenha.TabIndex = 12;
            this.LblSenha.Text = "Senha:";
            // 
            // LblNivel
            // 
            this.LblNivel.AutoSize = true;
            this.LblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivel.Location = new System.Drawing.Point(216, 275);
            this.LblNivel.Name = "LblNivel";
            this.LblNivel.Size = new System.Drawing.Size(52, 13);
            this.LblNivel.TabIndex = 13;
            this.LblNivel.Text = "Acesso:";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(730, 411);
            this.Controls.Add(this.LblNivel);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.CmbNivelAcesso);
            this.Controls.Add(this.TxbNewPassword);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxbNewLogin);
            this.Controls.Add(this.TxbNewName);
            this.Controls.Add(this.PbxNewUser);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.PbxNewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PbxNewUser;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxbNewLogin;
        private System.Windows.Forms.TextBox TxbNewName;
        private System.Windows.Forms.TextBox TxbNewPassword;
        private System.Windows.Forms.ComboBox CmbNivelAcesso;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Label LblNivel;
    }
}