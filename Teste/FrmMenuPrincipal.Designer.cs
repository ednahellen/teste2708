namespace SistemaCestas
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnDashboard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.Location = new System.Drawing.Point(40, 30);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Size = new System.Drawing.Size(140, 50);
            this.btnVoluntarios.TabIndex = 0;
            this.btnVoluntarios.Text = "Voluntários";
            this.btnVoluntarios.UseVisualStyleBackColor = true;
            this.btnVoluntarios.Click += new System.EventHandler(this.BtnVoluntarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(40, 100);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(140, 50);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(40, 170);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(140, 50);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(220, 250);
            this.Controls.Add(this.btnVoluntarios);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnDashboard);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
        }
    }
}
