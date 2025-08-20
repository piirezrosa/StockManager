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
            this.PnlNewUser = new System.Windows.Forms.Panel();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxbNewPassword = new System.Windows.Forms.TextBox();
            this.TxbNewUser = new System.Windows.Forms.TextBox();
            this.PbxNewUser = new System.Windows.Forms.PictureBox();
            this.PnlNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlNewUser
            // 
            this.PnlNewUser.BackColor = System.Drawing.SystemColors.Control;
            this.PnlNewUser.Controls.Add(this.LblCadastro);
            this.PnlNewUser.Controls.Add(this.BtnCadastrar);
            this.PnlNewUser.Controls.Add(this.TxbNewPassword);
            this.PnlNewUser.Controls.Add(this.TxbNewUser);
            this.PnlNewUser.Location = new System.Drawing.Point(291, 190);
            this.PnlNewUser.Name = "PnlNewUser";
            this.PnlNewUser.Size = new System.Drawing.Size(200, 100);
            this.PnlNewUser.TabIndex = 0;
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.Location = new System.Drawing.Point(55, 15);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(92, 16);
            this.LblCadastro.TabIndex = 3;
            this.LblCadastro.Text = "Cadastre-se";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(120, 45);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxbNewPassword
            // 
            this.TxbNewPassword.Location = new System.Drawing.Point(14, 60);
            this.TxbNewPassword.Name = "TxbNewPassword";
            this.TxbNewPassword.Size = new System.Drawing.Size(100, 20);
            this.TxbNewPassword.TabIndex = 1;
            this.TxbNewPassword.UseSystemPasswordChar = true;
            // 
            // TxbNewUser
            // 
            this.TxbNewUser.Location = new System.Drawing.Point(14, 34);
            this.TxbNewUser.Name = "TxbNewUser";
            this.TxbNewUser.Size = new System.Drawing.Size(100, 20);
            this.TxbNewUser.TabIndex = 0;
            // 
            // PbxNewUser
            // 
            this.PbxNewUser.Image = ((System.Drawing.Image)(resources.GetObject("PbxNewUser.Image")));
            this.PbxNewUser.Location = new System.Drawing.Point(206, 62);
            this.PbxNewUser.Name = "PbxNewUser";
            this.PbxNewUser.Size = new System.Drawing.Size(371, 107);
            this.PbxNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNewUser.TabIndex = 1;
            this.PbxNewUser.TabStop = false;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbxNewUser);
            this.Controls.Add(this.PnlNewUser);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.PnlNewUser.ResumeLayout(false);
            this.PnlNewUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlNewUser;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxbNewPassword;
        private System.Windows.Forms.TextBox TxbNewUser;
        private System.Windows.Forms.PictureBox PbxNewUser;
        private System.Windows.Forms.Label LblCadastro;
    }
}