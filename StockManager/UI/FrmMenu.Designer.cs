namespace StockManager
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.PbxMenu = new System.Windows.Forms.PictureBox();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenu)).BeginInit();
            //this.menuStripMenu.SuspendLayout();
            // 
            // PbxMenu
            // 
            this.PbxMenu.Image = ((System.Drawing.Image)(resources.GetObject("PbxMenu.Image")));
            this.PbxMenu.Location = new System.Drawing.Point(-3, 27);
            this.PbxMenu.Name = "PbxMenu";
            this.PbxMenu.Size = new System.Drawing.Size(803, 453);
            this.PbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMenu.TabIndex = 0;
            this.PbxMenu.TabStop = false;
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProdutos,
            this.menuSair});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(800, 24);
            this.menuStripMenu.TabIndex = 1;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarProduto,
            this.menuConsultarProduto,
            this.menuCadastrarUsuario});
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(67, 20);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastrarProduto
            // 
            this.menuCadastrarProduto.Name = "menuCadastrarProduto";
            this.menuCadastrarProduto.Size = new System.Drawing.Size(180, 22);
            this.menuCadastrarProduto.Text = "Cadastrar produto";
            this.menuCadastrarProduto.Click += new System.EventHandler(this.menuCadastrarProduto_Click_1);
            // 
            // menuConsultarProduto
            // 
            this.menuConsultarProduto.Name = "menuConsultarProduto";
            this.menuConsultarProduto.Size = new System.Drawing.Size(180, 22);
            this.menuConsultarProduto.Text = "Consultar";
            this.menuConsultarProduto.Click += new System.EventHandler(this.menuConsultarProduto_Click_1);
            // 
            // menuCadastrarUsuario
            // 
            this.menuCadastrarUsuario.Name = "menuCadastrarUsuario";
            this.menuCadastrarUsuario.Size = new System.Drawing.Size(180, 22);
            this.menuCadastrarUsuario.Text = "Cadastrar usuario";
            this.menuCadastrarUsuario.Click += new System.EventHandler(this.menuCadastrarUsuario_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click_1);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(305, 136);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "label1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStripMenu);
            this.Controls.Add(this.PbxMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenu)).EndInit();
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxMenu;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarUsuario;
        private System.Windows.Forms.Label lblUsuario;
    }
}