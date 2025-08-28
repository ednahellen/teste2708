namespace SistemaCestas
{
    partial class FrmProdutos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lbCodBarras = new System.Windows.Forms.Label();
            this.lbNomeProd = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lbPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.lbValidade = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoBarras
            this.txtCodigoBarras.Location = new System.Drawing.Point(218, 64);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.ReadOnly = true; // SOMENTE LEITURA
            this.txtCodigoBarras.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoBarras.TabIndex = 0;
            // 
            // lbCodBarras
            this.lbCodBarras.AutoSize = true;
            this.lbCodBarras.Location = new System.Drawing.Point(67, 67);
            this.lbCodBarras.Name = "lbCodBarras";
            this.lbCodBarras.Size = new System.Drawing.Size(113, 16);
            this.lbCodBarras.TabIndex = 1;
            this.lbCodBarras.Text = "Código de Barras";
            // 
            // lbNomeProd
            this.lbNomeProd.AutoSize = true;
            this.lbNomeProd.Location = new System.Drawing.Point(67, 109);
            this.lbNomeProd.Name = "lbNomeProd";
            this.lbNomeProd.Size = new System.Drawing.Size(113, 16);
            this.lbNomeProd.TabIndex = 3;
            this.lbNomeProd.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            this.txtNomeProduto.Location = new System.Drawing.Point(218, 106);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true; // SOMENTE LEITURA
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 22);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // lbPeso
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(67, 144);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(39, 16);
            this.lbPeso.TabIndex = 5;
            this.lbPeso.Text = "Peso";
            // 
            // txtPeso
            this.txtPeso.Location = new System.Drawing.Point(218, 138);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true; // SOMENTE LEITURA
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 4;
            // 
            // lbCategoria
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(67, 178);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(66, 16);
            this.lbCategoria.TabIndex = 7;
            this.lbCategoria.Text = "Categoria";
            // 
            // txtCategoria
            this.txtCategoria.Location = new System.Drawing.Point(218, 172);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true; // SOMENTE LEITURA
            this.txtCategoria.Size = new System.Drawing.Size(100, 22);
            this.txtCategoria.TabIndex = 6;
            // 
            // dtpValidade
            this.dtpValidade.Location = new System.Drawing.Point(211, 265);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(200, 22);
            this.dtpValidade.TabIndex = 8;
            // 
            // lbValidade
            this.lbValidade.AutoSize = true;
            this.lbValidade.Location = new System.Drawing.Point(60, 271);
            this.lbValidade.Name = "lbValidade";
            this.lbValidade.Size = new System.Drawing.Size(62, 16);
            this.lbValidade.TabIndex = 9;
            this.lbValidade.Text = "Validade";
            // 
            // txtQuantidade
            this.txtQuantidade.Location = new System.Drawing.Point(218, 215);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true; // SOMENTE LEITURA
            this.txtQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidade.TabIndex = 14;
            // 
            // lbQuantidade
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(71, 221);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(77, 16);
            this.lbQuantidade.TabIndex = 15;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // Botões
            this.btnNovo.Location = new System.Drawing.Point(55, 324);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            this.btnSalvar.Location = new System.Drawing.Point(188, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click); // Corrigido
            // 
            this.btnExcluir.Location = new System.Drawing.Point(343, 324);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(494, 87);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.Size = new System.Drawing.Size(240, 150);
            this.dgvProdutos.TabIndex = 13;
            // 
            // FrmProdutos
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbValidade);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbNomeProd);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lbCodBarras);
            this.Controls.Add(this.txtCodigoBarras);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lbCodBarras;
        private System.Windows.Forms.Label lbNomeProd;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label lbValidade;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lbQuantidade;
    }
}
