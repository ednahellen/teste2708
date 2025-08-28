using System;
using System.Windows.Forms;
using SistemaCestas;

namespace SistemaCestas
{
    public partial class FrmProdutos : Form
    {
        public event Action ProdutoCadastrado;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            var lista = ProdutoDAL.ObterProdutosDoMes(DateTime.Now.Month, DateTime.Now.Year);
            dgvProdutos.DataSource = lista;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto
                {
                    CodigoBarras = txtCodigoBarras.Text,
                    Nome = txtNomeProduto.Text,
                    Quantidade = int.Parse(txtQuantidade.Text),
                    Peso = double.Parse(txtPeso.Text),
                    Validade = dtpValidade.Value,
                    DataEntrada = DateTime.Now
                };

                ProdutoDAL.InserirProduto(produto);

                ProdutoCadastrado?.Invoke();
                AtualizarGrid();

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtCodigoBarras.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtPeso.Clear();
            dtpValidade.Value = DateTime.Now;
        }
    }
}

