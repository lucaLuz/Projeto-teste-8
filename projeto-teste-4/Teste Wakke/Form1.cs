using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Teste_Wakke
{
    public partial class frm_inicio : Form
    {
        string path = "BancoWakke.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\BancoWakke.db";
        int id = 0;

        public frm_inicio()
        {
            InitializeComponent();
        }

        public frm_inicio(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frm_inicio_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=" + path))
                {
                    con.Open();
                    var sql = "SELECT id, nome, ativo, sobrenome, altura, datanascimento  FROM usuario";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            Dt_formulario.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            frm_cadastro cadastro = new frm_cadastro(0);

            cadastro.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Dt_formulario.Rows[Dt_formulario.CurrentCell.RowIndex].Cells[0].Value);
            frm_cadastro cadastro = new frm_cadastro(id);

            cadastro.ShowDialog();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Dt_formulario.Rows[Dt_formulario.CurrentCell.RowIndex].Cells[0].Value);
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();
                    var sql = "DELETE FROM usuario WHERE ID=" + id;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
