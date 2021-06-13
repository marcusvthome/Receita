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
    public partial class FormPrincipal : FormBase
    {
        private List<Receita> dados = new List<Receita>();

        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            FormInsercao f = new FormInsercao();
            f.ShowDialog();
            
            if (f.ReceitaInserida != null)
            {
                dados.Add(f.ReceitaInserida);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dados;
                MessageBox.Show("Usuário inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
