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

            foreach (Receita receita in FormPrincipal.ListaReceitas)
            {
                if (receita.Titulo == txtTitulo.Text.Trim())
                {
                    errorProvider1.SetError(txtTitulo, "A receita com este nome já existe!");
                    MessageBox.Show("A receita com o nome "+ receita.Titulo +" já existe!");
                    erros = true;
                } 
            }

            if (erros == false)
            {
                Receita r = new Receita();
                r.Titulo = txtTitulo.Text.Trim();
                r.NomeAutor = txtNomeAutor.Text.Trim();
                r.TextoReceita = txtReceita.Text;

                ReceitaInserida = r;

                if (ReceitaInserida != null)
                {
                    Arquivo.CriarArquivo(ReceitaInserida);
                    FormPrincipal.ListaReceitas.Add(ReceitaInserida);
                    MessageBox.Show("Receita inserida com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }
    }
}
