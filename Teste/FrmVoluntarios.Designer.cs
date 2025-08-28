using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SistemaCestas
{
    partial class FrmVoluntarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LbNome = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.LbTelefone = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.TxtFuncao = new System.Windows.Forms.TextBox();
            this.LbFuncao = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvVoluntarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVoluntarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(113, 44);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(150, 22);
            this.TxtNome.TabIndex = 0;
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(40, 44);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(44, 16);
            this.LbNome.Text = "Nome";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(113, 80);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(150, 22);
            this.TxtTelefone.TabIndex = 1;
            // 
            // LbTelefone
            // 
            this.LbTelefone.AutoSize = true;
            this.LbTelefone.Location = new System.Drawing.Point(40, 80);
            this.LbTelefone.Name = "LbTelefone";
            this.LbTelefone.Size = new System.Drawing.Size(61, 16);
            this.LbTelefone.Text = "Telefone";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(113, 116);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(150, 22);
            this.TxtEmail.TabIndex = 2;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Location = new System.Drawing.Point(40, 116);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(41, 16);
            this.LbEmail.Text = "Email";
            // 
            // TxtFuncao
            // 
            this.TxtFuncao.Location = new System.Drawing.Point(113, 152);
            this.TxtFuncao.Name = "TxtFuncao";
            this.TxtFuncao.Size = new System.Drawing.Size(150, 22);
            this.TxtFuncao.TabIndex = 3;
            // 
            // LbFuncao
            // 
            this.LbFuncao.AutoSize = true;
            this.LbFuncao.Location = new System.Drawing.Point(40, 152);
            this.LbFuncao.Name = "LbFuncao";
            this.LbFuncao.Size = new System.Drawing.Size(52, 16);
            this.LbFuncao.Text = "Função";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(43, 200);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(135, 200);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(227, 200);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvVoluntarios
            // 
            this.DgvVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVoluntarios.Location = new System.Drawing.Point(350, 44);
            this.DgvVoluntarios.Name = "DgvVoluntarios";
            this.DgvVoluntarios.Size = new System.Drawing.Size(400, 250);
            // 
            // FrmVoluntarios
            // 
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.LbTelefone);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.TxtFuncao);
            this.Controls.Add(this.LbFuncao);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.DgvVoluntarios);
            this.Name = "FrmVoluntarios";
            this.Text = "Cadastro de Voluntários";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVoluntarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label LbTelefone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.TextBox TxtFuncao;
        private System.Windows.Forms.Label LbFuncao;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvVoluntarios;
    }
}


