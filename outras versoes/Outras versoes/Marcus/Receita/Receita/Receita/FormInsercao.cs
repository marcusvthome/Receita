using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receita
{
    public partial class FormInsercao : Form
    {
        public Receita ReceitaInserida = null;

        public FormInsercao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtNomeAutor.Text = "";
            txtReceita.Text = "";

            txtTitulo.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool erros = false;

            if (txtTitulo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTitulo, "Campo obrigatório");
                erros = true;
            }

            if (txtNomeAutor.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNomeAutor, "Campo obrigatório");
                erros = true;
            }

            if (txtReceita.Text.Trim() == "")
            {
                errorProvider1.SetError(txtReceita, "Campo obrigatório");
                erros = true;
            }

           
            if (erros == false)
            {
                FormPrincipal fp = new FormPrincipal();

                Receita r = new Receita();
                r.Titulo = txtTitulo.Text.Trim();
                r.NomeAutor = txtNomeAutor.Text.Trim();
                r.TextoReceita = txtReceita.Text;

            ReceitaInserida = r;  

                if (ReceitaInserida != null)
                {
                    //fp.dados.Add(ReceitaInserida);
                    Arquivo.CriarArquivo(ReceitaInserida);
                    //listaDados = dados;
                    //dataGridView1.DataSource = listaDados;
                    MessageBox.Show("Usuário inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //fp.PassarArquivos(ReceitaInserida);
                }

                Close();

            }
        }

        private void FormInsercao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReceitaInserida == null)
            {
                if (MessageBox.Show("Deseja fechar o formulário?", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
