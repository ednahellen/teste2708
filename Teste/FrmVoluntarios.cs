using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace SistemaCestas
{
    public partial class FrmVoluntarios : Form
    {
        public FrmVoluntarios()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voluntário cadastrado com sucesso!");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voluntário excluído!");
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Clear();
            TxtTelefone.Clear();
            TxtEmail.Clear();
            TxtFuncao.Clear();
        }
    }
}

