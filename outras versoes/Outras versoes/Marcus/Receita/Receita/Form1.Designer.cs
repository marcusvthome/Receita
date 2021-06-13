
namespace Receita
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntInserir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextoReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntInserir
            // 
            this.bntInserir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntInserir.Location = new System.Drawing.Point(12, 473);
            this.bntInserir.Name = "bntInserir";
            this.bntInserir.Size = new System.Drawing.Size(604, 39);
            this.bntInserir.TabIndex = 3;
            this.bntInserir.Text = "+ Inserir Nova Receita";
            this.bntInserir.UseVisualStyleBackColor = true;
            this.bntInserir.Click += new System.EventHandler(this.bntInserir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.DataCriacao,
            this.DataAtualizacao,
            this.NomeAutor,
            this.TextoReceita});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(604, 449);
            this.dataGridView1.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.FillWeight = 20F;
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataCriacao.DataPropertyName = "DataCriacao";
            this.DataCriacao.FillWeight = 20F;
            this.DataCriacao.HeaderText = "Data Criacao";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            this.DataCriacao.Visible = false;
            // 
            // DataAtualizacao
            // 
            this.DataAtualizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataAtualizacao.DataPropertyName = "DataAtualizacao";
            this.DataAtualizacao.FillWeight = 20F;
            this.DataAtualizacao.HeaderText = "Data Atualizacao";
            this.DataAtualizacao.Name = "DataAtualizacao";
            this.DataAtualizacao.ReadOnly = true;
            this.DataAtualizacao.Visible = false;
            // 
            // NomeAutor
            // 
            this.NomeAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeAutor.DataPropertyName = "NomeAutor";
            this.NomeAutor.FillWeight = 20F;
            this.NomeAutor.HeaderText = "Nome do Autor";
            this.NomeAutor.Name = "NomeAutor";
            this.NomeAutor.ReadOnly = true;
            // 
            // TextoReceita
            // 
            this.TextoReceita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextoReceita.DataPropertyName = "TextoReceita";
            this.TextoReceita.FillWeight = 20F;
            this.TextoReceita.HeaderText = "Receita";
            this.TextoReceita.Name = "TextoReceita";
            this.TextoReceita.ReadOnly = true;
            this.TextoReceita.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 524);
            this.Controls.Add(this.bntInserir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPrincipal";
            this.Text = "Receitas Culinárias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntInserir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextoReceita;
    }
}

