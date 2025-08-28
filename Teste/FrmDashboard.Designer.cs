namespace SistemaCestas
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnAbrirFrmProdutos;

        private System.Windows.Forms.Panel panelProdutos;
        private System.Windows.Forms.Panel panelItens;
        private System.Windows.Forms.Panel panelPeso;

        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.Label lblTituloProdutos;

        private System.Windows.Forms.Label lblTotalItens;
        private System.Windows.Forms.Label lblTituloItens;

        private System.Windows.Forms.Label lblTotalPeso;
        private System.Windows.Forms.Label lblTituloPeso;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuantidade;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPeso;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEntradas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnAbrirFrmProdutos = new System.Windows.Forms.Button();

            this.panelProdutos = new System.Windows.Forms.Panel();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.lblTituloProdutos = new System.Windows.Forms.Label();

            this.panelItens = new System.Windows.Forms.Panel();
            this.lblTotalItens = new System.Windows.Forms.Label();
            this.lblTituloItens = new System.Windows.Forms.Label();

            this.panelPeso = new System.Windows.Forms.Panel();
            this.lblTotalPeso = new System.Windows.Forms.Label();
            this.lblTituloPeso = new System.Windows.Forms.Label();

            this.chartQuantidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPeso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEntradas = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.panelProdutos.SuspendLayout();
            this.panelItens.SuspendLayout();
            this.panelPeso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradas)).BeginInit();
            this.SuspendLayout();

            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(670, 10);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(100, 30);
            this.BtnAtualizar.TabIndex = 0;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);

            // 
            // BtnAbrirFrmProdutos
            // 
            this.BtnAbrirFrmProdutos.Location = new System.Drawing.Point(670, 50);
            this.BtnAbrirFrmProdutos.Name = "BtnAbrirFrmProdutos";
            this.BtnAbrirFrmProdutos.Size = new System.Drawing.Size(100, 30);
            this.BtnAbrirFrmProdutos.TabIndex = 1;
            this.BtnAbrirFrmProdutos.Text = "Produtos";
            this.BtnAbrirFrmProdutos.Click += new System.EventHandler(this.BtnAbrirFrmProdutos_Click);

            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.CadetBlue;
            this.panelProdutos.Controls.Add(this.lblTotalProdutos);
            this.panelProdutos.Controls.Add(this.lblTituloProdutos);
            this.panelProdutos.Location = new System.Drawing.Point(10, 10);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(200, 80);
            this.panelProdutos.TabIndex = 2;

            // lblTotalProdutos
            this.lblTotalProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalProdutos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProdutos.Location = new System.Drawing.Point(10, 40);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(100, 23);
            this.lblTotalProdutos.TabIndex = 0;
            this.lblTotalProdutos.Text = "0";

            // lblTituloProdutos
            this.lblTituloProdutos.AutoSize = true;
            this.lblTituloProdutos.ForeColor = System.Drawing.Color.White;
            this.lblTituloProdutos.Location = new System.Drawing.Point(10, 10);
            this.lblTituloProdutos.Name = "lblTituloProdutos";
            this.lblTituloProdutos.Size = new System.Drawing.Size(61, 16);
            this.lblTituloProdutos.TabIndex = 1;
            this.lblTituloProdutos.Text = "Produtos";

            // 
            // panelItens
            // 
            this.panelItens.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelItens.Controls.Add(this.lblTotalItens);
            this.panelItens.Controls.Add(this.lblTituloItens);
            this.panelItens.Location = new System.Drawing.Point(220, 10);
            this.panelItens.Name = "panelItens";
            this.panelItens.Size = new System.Drawing.Size(200, 80);
            this.panelItens.TabIndex = 3;

            // lblTotalItens
            this.lblTotalItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalItens.ForeColor = System.Drawing.Color.White;
            this.lblTotalItens.Location = new System.Drawing.Point(10, 40);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(100, 23);
            this.lblTotalItens.TabIndex = 0;
            this.lblTotalItens.Text = "0";

            // lblTituloItens
            this.lblTituloItens.AutoSize = true;
            this.lblTituloItens.ForeColor = System.Drawing.Color.White;
            this.lblTituloItens.Location = new System.Drawing.Point(10, 10);
            this.lblTituloItens.Name = "lblTituloItens";
            this.lblTituloItens.Size = new System.Drawing.Size(35, 16);
            this.lblTituloItens.TabIndex = 1;
            this.lblTituloItens.Text = "Itens";

            // 
            // panelPeso
            // 
            this.panelPeso.BackColor = System.Drawing.Color.OrangeRed;
            this.panelPeso.Controls.Add(this.lblTotalPeso);
            this.panelPeso.Controls.Add(this.lblTituloPeso);
            this.panelPeso.Location = new System.Drawing.Point(430, 10);
            this.panelPeso.Name = "panelPeso";
            this.panelPeso.Size = new System.Drawing.Size(200, 80);
            this.panelPeso.TabIndex = 4;

            // lblTotalPeso
            this.lblTotalPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPeso.ForeColor = System.Drawing.Color.White;
            this.lblTotalPeso.Location = new System.Drawing.Point(10, 40);
            this.lblTotalPeso.Name = "lblTotalPeso";
            this.lblTotalPeso.Size = new System.Drawing.Size(100, 23);
            this.lblTotalPeso.TabIndex = 0;
            this.lblTotalPeso.Text = "0 kg";

            // lblTituloPeso
            this.lblTituloPeso.AutoSize = true;
            this.lblTituloPeso.ForeColor = System.Drawing.Color.White;
            this.lblTituloPeso.Location = new System.Drawing.Point(10, 10);
            this.lblTituloPeso.Name = "lblTituloPeso";
            this.lblTituloPeso.Size = new System.Drawing.Size(73, 16);
            this.lblTituloPeso.TabIndex = 1;
            this.lblTituloPeso.Text = "Peso Total";

            // 
            // chartQuantidade
            // 
            this.chartQuantidade.Location = new System.Drawing.Point(10, 100);
            this.chartQuantidade.Name = "chartQuantidade";
            this.chartQuantidade.Size = new System.Drawing.Size(380, 200);
            this.chartQuantidade.TabIndex = 5;

            // 
            // chartPeso
            // 
            this.chartPeso.Location = new System.Drawing.Point(400, 100);
            this.chartPeso.Name = "chartPeso";
            this.chartPeso.Size = new System.Drawing.Size(380, 200);
            this.chartPeso.TabIndex = 6;

            // 
            // chartEntradas
            // 
            this.chartEntradas.Location = new System.Drawing.Point(10, 310);
            this.chartEntradas.Name = "chartEntradas";
            this.chartEntradas.Size = new System.Drawing.Size(770, 200);
            this.chartEntradas.TabIndex = 7;

            // 
            // FrmDashboard
            // 
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnAbrirFrmProdutos);
            this.Controls.Add(this.panelProdutos);
            this.Controls.Add(this.panelItens);
            this.Controls.Add(this.panelPeso);
            this.Controls.Add(this.chartQuantidade);
            this.Controls.Add(this.chartPeso);
            this.Controls.Add(this.chartEntradas);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";

            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.panelItens.ResumeLayout(false);
            this.panelItens.PerformLayout();
            this.panelPeso.ResumeLayout(false);
            this.panelPeso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
