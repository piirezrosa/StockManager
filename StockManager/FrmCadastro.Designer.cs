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
            this.TxbNewPassword = new System.Windows.Forms.TextBox();
            this.TxbNewUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxNewUser
            // 
            this.PbxNewUser.Image = ((System.Drawing.Image)(resources.GetObject("PbxNewUser.Image")));
            this.PbxNewUser.Location = new System.Drawing.Point(0, -2);
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
            this.BtnCadastrar.Location = new System.Drawing.Point(381, 203);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click_1);
            // 
            // TxbNewPassword
            // 
            this.TxbNewPassword.Location = new System.Drawing.Point(275, 218);
            this.TxbNewPassword.Name = "TxbNewPassword";
            this.TxbNewPassword.Size = new System.Drawing.Size(100, 20);
            this.TxbNewPassword.TabIndex = 5;
            this.TxbNewPassword.UseSystemPasswordChar = true;
            // 
            // TxbNewUser
            // 
            this.TxbNewUser.Location = new System.Drawing.Point(275, 192);
            this.TxbNewUser.Name = "TxbNewUser";
            this.TxbNewUser.Size = new System.Drawing.Size(100, 20);
            this.TxbNewUser.TabIndex = 4;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(730, 411);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxbNewPassword);
            this.Controls.Add(this.TxbNewUser);
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
        private System.Windows.Forms.TextBox TxbNewPassword;
        private System.Windows.Forms.TextBox TxbNewUser;
    }
}