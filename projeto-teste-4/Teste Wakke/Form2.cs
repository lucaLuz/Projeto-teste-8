using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_Wakke
{
    public partial class frm_cadastro : Form
    {
        int Id = 0;
        string path = "BancoWakke.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\BancoWakke.db";

        SQLiteDataReader dr;

        public frm_cadastro()
        {
            InitializeComponent();
        }

        public frm_cadastro(int Id)
        {
            InitializeComponent();
            this.Id = Id;

            if (Id > 0)
            {
                GetUsuario(Id);
            }
        }

        public void GetUsuario(int Id)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();
                    string stm = "SELECT ativo, nome, sobrenome, altura, datanascimento  FROM usuario WHERE ID=" + Id;

                    using (SQLiteCommand cmd = new SQLiteCommand(stm,con))
                    {
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    Txt_nome.Text = dr["nome"].ToString();
                                    Txt_sobrenome.Text = dr["sobrenome"].ToString();
                                    Txt_altura.Text = dr["altura"].ToString();
                                    txd_cdata.Text = dr["data"].ToString();

                                    if (Convert.ToBoolean(dr["ativo"]))
                                    {
                                        rb_ativo.Checked = true;
                                        rb_inativo.Checked = false;
                                    }
                                    else
                                    {
                                        rb_inativo.Checked = true;
                                        rb_ativo.Checked = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        public void Salvar()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();
                    var sql = "";

                    if (this.Id == 0)
                    {
                        var data = txd_cdata.Text.Split('/');
                        sql = $"INSERT INTO usuario(ID, ativo, nome, sobrenome, datanascimento, altura) values ({txd_id.Text}, {(rb_ativo.Text.Substring(0, 1) == "1" ? 1 : 0 )}, '{Txt_nome.Text}', '{Txt_sobrenome.Text}', '{data[2]}{data[1]}{data[0]}',{decimal.Parse(Txt_altura.Text).ToString("N2").Replace(",", ".")})";
                    }
                    else
                    {
                        var data = txd_cdata.Text.Split('/');
                        sql = $"UPDATE usuario SET ativo = '{(rb_ativo.Text.Substring(0, 1) == "1" ? 1 : 0)}', nome = '{Txt_nome.Text}', sobrenome = '{Txt_sobrenome.Text}', datanascimento = '{data[2]}{data[1]}{data[0]}', altura = { decimal.Parse(Txt_altura.Text).ToString("N2").Replace(",", ".") }  WHERE ID=" + this.Id; 
                    }
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch   (Exception)
            {
                return;
            }
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_cnome_TextChanged(object sender, EventArgs e)
        {

        }

        public void Btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }

        public void Frm_cadastro_Load(object sender, EventArgs e)
        {


        }

        private void Txd_cid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txd_cdata_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Txt_sobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rb_ativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rb_inativo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
