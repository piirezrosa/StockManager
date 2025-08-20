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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultProducts));
            this.DgvConsultProducts = new System.Windows.Forms.DataGridView();
            this.LblConsultProducts = new System.Windows.Forms.Label();
            this.BtnRechargeConsultProducts = new System.Windows.Forms.Button();
            this.PnlConsultProducts = new System.Windows.Forms.Panel();
            this.PbxConsultProducts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultProducts)).BeginInit();
            this.PnlConsultProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxConsultProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultProducts
            // 
            this.DgvConsultProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultProducts.Location = new System.Drawing.Point(21, 31);
            this.DgvConsultProducts.Name = "DgvConsultProducts";
            this.DgvConsultProducts.Size = new System.Drawing.Size(240, 150);
            this.DgvConsultProducts.TabIndex = 0;
            // 
            // LblConsultProducts
            // 
            this.LblConsultProducts.AutoSize = true;
            this.LblConsultProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsultProducts.Location = new System.Drawing.Point(302, 81);
            this.LblConsultProducts.Name = "LblConsultProducts";
            this.LblConsultProducts.Size = new System.Drawing.Size(209, 24);
            this.LblConsultProducts.TabIndex = 1;
            this.LblConsultProducts.Text = "Consulta de produtos";
            // 
            // BtnRechargeConsultProducts
            // 
            this.BtnRechargeConsultProducts.Location = new System.Drawing.Point(315, 92);
            this.BtnRechargeConsultProducts.Name = "BtnRechargeConsultProducts";
            this.BtnRechargeConsultProducts.Size = new System.Drawing.Size(75, 23);
            this.BtnRechargeConsultProducts.TabIndex = 2;
            this.BtnRechargeConsultProducts.Text = "Recarregar";
            this.BtnRechargeConsultProducts.UseVisualStyleBackColor = true;
            // 
            // PnlConsultProducts
            // 
            this.PnlConsultProducts.BackColor = System.Drawing.SystemColors.Control;
            this.PnlConsultProducts.Controls.Add(this.DgvConsultProducts);
            this.PnlConsultProducts.Controls.Add(this.BtnRechargeConsultProducts);
            this.PnlConsultProducts.Location = new System.Drawing.Point(182, 108);
            this.PnlConsultProducts.Name = "PnlConsultProducts";
            this.PnlConsultProducts.Size = new System.Drawing.Size(429, 208);
            this.PnlConsultProducts.TabIndex = 3;
            // 
            // PbxConsultProducts
            // 
            this.PbxConsultProducts.Image = ((System.Drawing.Image)(resources.GetObject("PbxConsultProducts.Image")));
            this.PbxConsultProducts.Location = new System.Drawing.Point(629, 301);
            this.PbxConsultProducts.Name = "PbxConsultProducts";
            this.PbxConsultProducts.Size = new System.Drawing.Size(215, 225);
            this.PbxConsultProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxConsultProducts.TabIndex = 4;
            this.PbxConsultProducts.TabStop = false;
            // 
            // FrmConsultProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlConsultProducts);
            this.Controls.Add(this.LblConsultProducts);
            this.Controls.Add(this.PbxConsultProducts);
            this.Name = "FrmConsultProducts";
            this.Text = "FrmConsultProducts";
            this.Load += new System.EventHandler(this.FrmConsultProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultProducts)).EndInit();
            this.PnlConsultProducts.ResumeLayout(false);
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
    }
}