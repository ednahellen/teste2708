using Novoprojeto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Novoprojeto.
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        public void AtualizarDashboard() 
        {
            var produtosMes = ProdutoDAL.ObterProdutosdoMes(DateTime.Now.Month, DateTime.Now.Year);

            lblTotalProdutos.Text = produtosMes.Count.ToString();
            lblTotalItens.Text = produtosMes.Sum(p => p.Quantidade).ToString();
            lblTotalKg.Text = produtosMes.Sum(p => p.Quantidade * p.Peso).ToString("N2") + "Kg";
        }
    }
}

