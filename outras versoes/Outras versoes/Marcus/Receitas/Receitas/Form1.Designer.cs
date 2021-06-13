
namespace Receitas
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTituloReceita = new System.Windows.Forms.TextBox();
            this.lblTituloReceita = new System.Windows.Forms.Label();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.lblReceita = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.rtxtReceita = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar Receita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTituloReceita
            // 
            this.txtTituloReceita.Location = new System.Drawing.Point(56, 54);
            this.txtTituloReceita.Name = "txtTituloReceita";
            this.txtTituloReceita.Size = new System.Drawing.Size(215, 23);
            this.txtTituloReceita.TabIndex = 1;
            this.txtTituloReceita.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTituloReceita
            // 
            this.lblTituloReceita.AutoSize = true;
            this.lblTituloReceita.Location = new System.Drawing.Point(114, 36);
            this.lblTituloReceita.Name = "lblTituloReceita";
            this.lblTituloReceita.Size = new System.Drawing.Size(94, 15);
            this.lblTituloReceita.TabIndex = 2;
            this.lblTituloReceita.Text = "Título da Receita";
            this.lblTituloReceita.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(114, 98);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(90, 15);
            this.lblNomeAutor.TabIndex = 3;
            this.lblNomeAutor.Text = "Nome do Autor";
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Location = new System.Drawing.Point(139, 142);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(45, 15);
            this.lblReceita.TabIndex = 4;
            this.lblReceita.Text = "Receita";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(56, 116);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(215, 23);
            this.txtNomeAutor.TabIndex = 7;
            // 
            // rtxtReceita
            // 
            this.rtxtReceita.Location = new System.Drawing.Point(40, 182);
            this.rtxtReceita.Name = "rtxtReceita";
            this.rtxtReceita.Size = new System.Drawing.Size(231, 182);
            this.rtxtReceita.TabIndex = 8;
            this.rtxtReceita.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "X";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exemplo Conexão";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(128, 370);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(84, 49);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar Receita";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(314, 486);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtxtReceita);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.lblNomeAutor);
            this.Controls.Add(this.lblTituloReceita);
            this.Controls.Add(this.txtTituloReceita);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTituloReceita;
        private System.Windows.Forms.Label lblTituloReceita;
        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.RichTextBox rtxtReceita;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnApagar;
    }
}

