using System;

namespace Teste_Wakke
{
    partial class frm_cadastro
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro));
            this.lbl_textoInicio = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.Lbl_nome = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_csituacao = new System.Windows.Forms.Label();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txd_cdata = new System.Windows.Forms.MaskedTextBox();
            this.txd_id = new System.Windows.Forms.MaskedTextBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Txt_sobrenome = new System.Windows.Forms.TextBox();
            this.Txt_altura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_textoInicio
            // 
            this.lbl_textoInicio.AutoSize = true;
            this.lbl_textoInicio.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textoInicio.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_textoInicio.Location = new System.Drawing.Point(16, 12);
            this.lbl_textoInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_textoInicio.Name = "lbl_textoInicio";
            this.lbl_textoInicio.Size = new System.Drawing.Size(348, 39);
            this.lbl_textoInicio.TabIndex = 0;
            this.lbl_textoInicio.Text = "Informações Pessoais";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(21, 88);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 17);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            // 
            // Lbl_nome
            // 
            this.Lbl_nome.AutoSize = true;
            this.Lbl_nome.Location = new System.Drawing.Point(21, 145);
            this.Lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nome.Name = "Lbl_nome";
            this.Lbl_nome.Size = new System.Drawing.Size(48, 17);
            this.Lbl_nome.TabIndex = 4;
            this.Lbl_nome.Text = "Nome";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(263, 145);
            this.lbl_sobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(82, 17);
            this.lbl_sobrenome.TabIndex = 6;
            this.lbl_sobrenome.Text = "Sobrenome";
            this.lbl_sobrenome.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(21, 213);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(142, 17);
            this.lbl_data.TabIndex = 7;
            this.lbl_data.Text = "Data de nascimento";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(263, 213);
            this.lbl_altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(46, 17);
            this.lbl_altura.TabIndex = 9;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_csituacao
            // 
            this.lbl_csituacao.AutoSize = true;
            this.lbl_csituacao.Location = new System.Drawing.Point(512, 213);
            this.lbl_csituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_csituacao.Name = "lbl_csituacao";
            this.lbl_csituacao.Size = new System.Drawing.Size(65, 17);
            this.lbl_csituacao.TabIndex = 11;
            this.lbl_csituacao.Text = "Situação";
            this.lbl_csituacao.Click += new System.EventHandler(this.Label6_Click);
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Location = new System.Drawing.Point(515, 236);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(60, 21);
            this.rb_ativo.TabIndex = 12;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            this.rb_ativo.CheckedChanged += new System.EventHandler(this.Rb_ativo_CheckedChanged);
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Location = new System.Drawing.Point(591, 234);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(71, 21);
            this.rb_inativo.TabIndex = 13;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            this.rb_inativo.CheckedChanged += new System.EventHandler(this.Rb_inativo_CheckedChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_salvar.Location = new System.Drawing.Point(687, 302);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // txd_cdata
            // 
            this.txd_cdata.BackColor = System.Drawing.Color.SeaShell;
            this.txd_cdata.ForeColor = System.Drawing.Color.DarkRed;
            this.txd_cdata.Location = new System.Drawing.Point(23, 236);
            this.txd_cdata.Mask = "00/00/0000";
            this.txd_cdata.Name = "txd_cdata";
            this.txd_cdata.Size = new System.Drawing.Size(194, 23);
            this.txd_cdata.TabIndex = 15;
            this.txd_cdata.ValidatingType = typeof(System.DateTime);
            this.txd_cdata.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txd_cdata_MaskInputRejected);
            // 
            // txd_id
            // 
            this.txd_id.BackColor = System.Drawing.Color.SeaShell;
            this.txd_id.Enabled = false;
            this.txd_id.ForeColor = System.Drawing.Color.DarkRed;
            this.txd_id.Location = new System.Drawing.Point(23, 108);
            this.txd_id.Mask = "00000";
            this.txd_id.Name = "txd_id";
            this.txd_id.Size = new System.Drawing.Size(140, 23);
            this.txd_id.TabIndex = 16;
            this.txd_id.ValidatingType = typeof(int);
            this.txd_id.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txd_cid_MaskInputRejected);
            // 
            // Txt_nome
            // 
            this.Txt_nome.BackColor = System.Drawing.Color.SeaShell;
            this.Txt_nome.ForeColor = System.Drawing.Color.DarkRed;
            this.Txt_nome.Location = new System.Drawing.Point(23, 166);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(194, 23);
            this.Txt_nome.TabIndex = 17;
            this.Txt_nome.TextChanged += new System.EventHandler(this.Txt_nome_TextChanged);
            // 
            // Txt_sobrenome
            // 
            this.Txt_sobrenome.BackColor = System.Drawing.Color.SeaShell;
            this.Txt_sobrenome.ForeColor = System.Drawing.Color.DarkRed;
            this.Txt_sobrenome.Location = new System.Drawing.Point(266, 166);
            this.Txt_sobrenome.Name = "Txt_sobrenome";
            this.Txt_sobrenome.Size = new System.Drawing.Size(194, 23);
            this.Txt_sobrenome.TabIndex = 18;
            this.Txt_sobrenome.TextChanged += new System.EventHandler(this.Txt_sobrenome_TextChanged);
            // 
            // Txt_altura
            // 
            this.Txt_altura.BackColor = System.Drawing.Color.SeaShell;
            this.Txt_altura.ForeColor = System.Drawing.Color.DarkRed;
            this.Txt_altura.Location = new System.Drawing.Point(266, 236);
            this.Txt_altura.Name = "Txt_altura";
            this.Txt_altura.Size = new System.Drawing.Size(194, 23);
            this.Txt_altura.TabIndex = 19;
            this.Txt_altura.TextChanged += new System.EventHandler(this.Txt_altura_TextChanged);
            // 
            // frm_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.Txt_altura);
            this.Controls.Add(this.Txt_sobrenome);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.txd_id);
            this.Controls.Add(this.txd_cdata);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.rb_inativo);
            this.Controls.Add(this.rb_ativo);
            this.Controls.Add(this.lbl_csituacao);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.Lbl_nome);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_textoInicio);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Frm_cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_textoInicio;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label Lbl_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_csituacao;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.MaskedTextBox txd_cdata;
        private System.Windows.Forms.MaskedTextBox txd_id;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.TextBox Txt_sobrenome;
        private System.Windows.Forms.TextBox Txt_altura;
    }
}