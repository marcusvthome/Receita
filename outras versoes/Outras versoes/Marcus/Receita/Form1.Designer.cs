
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
            this.dgTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluirReceita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntInserir
            // 
            this.bntInserir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntInserir.Location = new System.Drawing.Point(12, 473);
            this.bntInserir.Name = "bntInserir";
            this.bntInserir.Size = new System.Drawing.Size(336, 39);
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
            this.dgTitulo,
            this.dgNomeAutor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(604, 448);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dgTitulo
            // 
            this.dgTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgTitulo.DataPropertyName = "Titulo";
            this.dgTitulo.FillWeight = 50F;
            this.dgTitulo.HeaderText = "Título";
            this.dgTitulo.Name = "dgTitulo";
            this.dgTitulo.ReadOnly = true;
            // 
            // dgNomeAutor
            // 
            this.dgNomeAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgNomeAutor.DataPropertyName = "NomeAutor";
            this.dgNomeAutor.FillWeight = 50F;
            this.dgNomeAutor.HeaderText = "Nome Do Autor";
            this.dgNomeAutor.Name = "dgNomeAutor";
            this.dgNomeAutor.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(354, 473);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(128, 39);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnExcluirReceita
            // 
            this.btnExcluirReceita.Location = new System.Drawing.Point(488, 473);
            this.btnExcluirReceita.Name = "btnExcluirReceita";
            this.btnExcluirReceita.Size = new System.Drawing.Size(128, 39);
            this.btnExcluirReceita.TabIndex = 5;
            this.btnExcluirReceita.Text = "Excluir Receita";
            this.btnExcluirReceita.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 524);
            this.Controls.Add(this.btnExcluirReceita);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.bntInserir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPrincipal";
            this.Text = "Receitas Culinárias";
            this.Load += new System.EventHandler(this.FormPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluirReceita;
    }
}

