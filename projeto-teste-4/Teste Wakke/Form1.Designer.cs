namespace Teste_Wakke
{
    partial class frm_inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_cadastro = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Dt_formulario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_formulario)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Lbl_titulo.Location = new System.Drawing.Point(12, 29);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(347, 39);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Pessoas Cadastradas";
            // 
            // Btn_cadastro
            // 
            this.Btn_cadastro.BackColor = System.Drawing.Color.SaddleBrown;
            this.Btn_cadastro.FlatAppearance.BorderSize = 0;
            this.Btn_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cadastro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cadastro.ForeColor = System.Drawing.Color.PeachPuff;
            this.Btn_cadastro.Location = new System.Drawing.Point(404, 43);
            this.Btn_cadastro.Name = "Btn_cadastro";
            this.Btn_cadastro.Size = new System.Drawing.Size(75, 23);
            this.Btn_cadastro.TabIndex = 1;
            this.Btn_cadastro.Text = "Cadastrar";
            this.Btn_cadastro.UseVisualStyleBackColor = false;
            this.Btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.SaddleBrown;
            this.Btn_editar.FlatAppearance.BorderSize = 0;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.Color.PeachPuff;
            this.Btn_editar.Location = new System.Drawing.Point(494, 43);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(108, 23);
            this.Btn_editar.TabIndex = 4;
            this.Btn_editar.Text = "Editar Cadastro";
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.BackColor = System.Drawing.Color.SaddleBrown;
            this.Btn_excluir.FlatAppearance.BorderSize = 0;
            this.Btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_excluir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_excluir.ForeColor = System.Drawing.Color.PeachPuff;
            this.Btn_excluir.Location = new System.Drawing.Point(623, 43);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_excluir.TabIndex = 5;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = false;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Dt_formulario
            // 
            this.Dt_formulario.AllowUserToAddRows = false;
            this.Dt_formulario.AllowUserToDeleteRows = false;
            this.Dt_formulario.AllowUserToResizeColumns = false;
            this.Dt_formulario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.Dt_formulario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dt_formulario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dt_formulario.BackgroundColor = System.Drawing.Color.Bisque;
            this.Dt_formulario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dt_formulario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dt_formulario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dt_formulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_formulario.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dt_formulario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dt_formulario.GridColor = System.Drawing.Color.Brown;
            this.Dt_formulario.Location = new System.Drawing.Point(12, 85);
            this.Dt_formulario.MultiSelect = false;
            this.Dt_formulario.Name = "Dt_formulario";
            this.Dt_formulario.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dt_formulario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dt_formulario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dt_formulario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dt_formulario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dt_formulario.ShowEditingIcon = false;
            this.Dt_formulario.Size = new System.Drawing.Size(769, 353);
            this.Dt_formulario.TabIndex = 7;
            this.Dt_formulario.TabStop = false;
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dt_formulario);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_cadastro);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Cadastrais";
            this.TransparencyKey = System.Drawing.Color.SeaShell;
            this.Load += new System.EventHandler(this.frm_inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_formulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_cadastro;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.DataGridView Dt_formulario;
    }
}

