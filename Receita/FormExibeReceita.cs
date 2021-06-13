using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receita
{
    public partial class FormExibeReceita : FormBase
    {

        public FormExibeReceita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                if (txtTitulo.Text == FormPrincipal.TituloReceita)
                {
                    erros = false;
                }
                else if (receita.Titulo == txtTitulo.Text.Trim())
                {
                    errorProvider1.SetError(txtTitulo, "A receita com este nome já existe!");
                    MessageBox.Show("A receita com o nome " + receita.Titulo + " já existe!");
                    erros = true;
                }
            }

            if (erros == false)
            {
                foreach (Receita receita in FormPrincipal.ListaReceitas)
                {

                    if (receita.Titulo == FormPrincipal.TituloReceita)
                    {
                        receita.Titulo = txtTitulo.Text;
                        receita.NomeAutor = txtNomeAutor.Text;
                        receita.DataCriacao = receita.DataCriacao;
                        receita.DataAtualizacao = DateTime.Today;
                        receita.TextoReceita = txtReceita.Text;

                        Arquivo.AtualizarArquivo(receita, FormPrincipal.TituloReceita);

                        MessageBox.Show("Receita atualizada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }

                Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtTitulo.ReadOnly = false;
            txtNomeAutor.ReadOnly = false;
            txtReceita.ReadOnly = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.ReadOnly == false && txtNomeAutor.ReadOnly == false && txtReceita.ReadOnly == false)
            {
                txtTitulo.Text = "";
                txtNomeAutor.Text = "";
                txtReceita.Text = "";

                txtTitulo.Focus();
            }
            else
                MessageBox.Show("Só pode limpar os campos se estiver editando a receita!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
