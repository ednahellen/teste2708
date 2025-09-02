namespace chart
{
    partial class frmDashboard
    {
        private void InitializeComponet()
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartQuantidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalKg = new System.Windows.Forms.Label();
            this.listRanking = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.chartPeso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMensal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalItens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMensal)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartQuantidade
            // 
            chartArea1.Name = "ChartArea1";
            this.chartQuantidade.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQuantidade.Legends.Add(legend1);
            this.chartQuantidade.Location = new System.Drawing.Point(393, 143);
            this.chartQuantidade.Name = "chartQuantidade";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartQuantidade.Series.Add(series1);
            this.chartQuantidade.Size = new System.Drawing.Size(321, 475);
            this.chartQuantidade.TabIndex = 0;
            this.chartQuantidade.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnVoluntarios);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.btnProdutos);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 623);
            this.panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(9, 493);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 38);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(9, 449);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 38);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoluntarios.Location = new System.Drawing.Point(9, 225);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Size = new System.Drawing.Size(112, 38);
            this.btnVoluntarios.TabIndex = 3;
            this.btnVoluntarios.Text = "Voluntários";
            this.btnVoluntarios.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(9, 181);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(112, 38);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(9, 137);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(112, 38);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(9, 93);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(112, 38);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(366, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 131);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTotalKg);
            this.panel4.Location = new System.Drawing.Point(754, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 131);
            this.panel4.TabIndex = 1;
            // 
            // lblTotalKg
            // 
            this.lblTotalKg.AutoSize = true;
            this.lblTotalKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKg.Location = new System.Drawing.Point(64, 66);
            this.lblTotalKg.Name = "lblTotalKg";
            this.lblTotalKg.Size = new System.Drawing.Size(95, 20);
            this.lblTotalKg.TabIndex = 0;
            this.lblTotalKg.Text = "Total Kg: 0";
            // 
            // listRanking
            // 
            this.listRanking.FormattingEnabled = true;
            this.listRanking.Location = new System.Drawing.Point(148, 3);
            this.listRanking.Name = "listRanking";
            this.listRanking.Size = new System.Drawing.Size(222, 615);
            this.listRanking.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotalProdutos);
            this.panel3.Location = new System.Drawing.Point(441, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 131);
            this.panel3.TabIndex = 0;
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProdutos.Location = new System.Drawing.Point(41, 66);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(146, 20);
            this.lblTotalProdutos.TabIndex = 0;
            this.lblTotalProdutos.Text = "Total Produtos: 0";
            // 
            // chartPeso
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPeso.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPeso.Legends.Add(legend2);
            this.chartPeso.Location = new System.Drawing.Point(728, 144);
            this.chartPeso.Name = "chartPeso";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPeso.Series.Add(series2);
            this.chartPeso.Size = new System.Drawing.Size(321, 475);
            this.chartPeso.TabIndex = 4;
            this.chartPeso.Text = "chart1";
            // 
            // chartMensal
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMensal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMensal.Legends.Add(legend3);
            this.chartMensal.Location = new System.Drawing.Point(1060, 143);
            this.chartMensal.Name = "chartMensal";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartMensal.Series.Add(series3);
            this.chartMensal.Size = new System.Drawing.Size(321, 475);
            this.chartMensal.TabIndex = 5;
            this.chartMensal.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotalItens);
            this.panel5.Location = new System.Drawing.Point(774, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 131);
            this.panel5.TabIndex = 2;
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.AutoSize = true;
            this.lblTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItens.Location = new System.Drawing.Point(57, 66);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(115, 20);
            this.lblTotalItens.TabIndex = 0;
            this.lblTotalItens.Text = "Total Itens: 0";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 625);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chartMensal);
            this.Controls.Add(this.chartPeso);
            this.Controls.Add(this.listRanking);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartQuantidade);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMensal)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuantidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ListBox listRanking;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalKg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPeso;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMensal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalItens;
    }
}

