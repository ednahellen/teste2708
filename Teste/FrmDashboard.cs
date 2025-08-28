using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SistemaCestas;

namespace SistemaCestas
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        private void AtualizarDashboard()
        {
            var produtosMes = ProdutoDAL.ObterProdutosDoMes(DateTime.Now.Month, DateTime.Now.Year);

            // Cards
            lblTotalProdutos.Text = produtosMes.Count.ToString();
            lblTotalItens.Text = produtosMes.Sum(p => p.Quantidade).ToString();
            lblTotalPeso.Text = produtosMes.Sum(p => p.Quantidade * p.Peso).ToString("N2") + " kg";

            // Gráficos
            CarregarGraficoQuantidade(produtosMes);
            CarregarGraficoPeso(produtosMes);
            CarregarGraficoEntradasPorDia(produtosMes);
        }

        private void CarregarGraficoQuantidade(System.Collections.Generic.List<Produto> produtosMes)
        {
            chartQuantidade.Series.Clear();
            Series serie = new Series("Quantidade") { ChartType = SeriesChartType.Column };

            var dados = produtosMes
                .GroupBy(p => p.Nome)
                .Select(g => new { Nome = g.Key, Quantidade = g.Sum(x => x.Quantidade) })
                .OrderByDescending(x => x.Quantidade);

            foreach (var item in dados)
                serie.Points.AddXY(item.Nome, item.Quantidade);

            chartQuantidade.Series.Add(serie);
        }

        private void CarregarGraficoPeso(System.Collections.Generic.List<Produto> produtosMes)
        {
            chartPeso.Series.Clear();
            Series serie = new Series("Peso Total") { ChartType = SeriesChartType.Column };

            var dados = produtosMes
                .GroupBy(p => p.Nome)
                .Select(g => new { Nome = g.Key, PesoTotal = g.Sum(x => x.Peso * x.Quantidade) })
                .OrderByDescending(x => x.PesoTotal);

            foreach (var item in dados)
                serie.Points.AddXY(item.Nome, item.PesoTotal);

            chartPeso.Series.Add(serie);
        }

        private void CarregarGraficoEntradasPorDia(System.Collections.Generic.List<Produto> produtosMes)
        {
            chartEntradas.Series.Clear();
            Series serie = new Series("Entradas por Dia") { ChartType = SeriesChartType.Line };

            var dados = produtosMes
                .GroupBy(p => p.DataEntrada.Day)
                .Select(g => new { Dia = g.Key, Quantidade = g.Sum(x => x.Quantidade) })
                .OrderBy(x => x.Dia);

            foreach (var item in dados)
                serie.Points.AddXY(item.Dia, item.Quantidade);

            chartEntradas.Series.Add(serie);
        }

        private void BtnAbrirFrmProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.ProdutoCadastrado += AtualizarDashboard;
            frmProdutos.Show();
        }
    }
}
