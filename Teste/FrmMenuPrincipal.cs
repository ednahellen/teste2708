using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCestas
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnVoluntarios_Click(object sender, EventArgs e)
        {
            FrmVoluntarios frm = new FrmVoluntarios();
            frm.ShowDialog(); // Use Show() se não quiser bloquear o menu
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos frm = new FrmProdutos();
            frm.ShowDialog();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.ShowDialog();
        }
    }
}


