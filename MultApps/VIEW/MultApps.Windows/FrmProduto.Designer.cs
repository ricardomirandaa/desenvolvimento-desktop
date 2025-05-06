namespace MultApps.Windows
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGestaoProdutos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrlImagem = new System.Windows.Forms.TextBox();
            this.lblUrlImagem = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rdoStatusInativo = new System.Windows.Forms.RadioButton();
            this.rdoStatusAtivo = new System.Windows.Forms.RadioButton();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCadastroGestao = new System.Windows.Forms.Label();
            this.cmbFiltroStatus = new System.Windows.Forms.ComboBox();
            this.lblFiltroStatus = new System.Windows.Forms.Label();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestaoProdutos
            // 
            this.lblGestaoProdutos.AutoSize = true;
            this.lblGestaoProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoProdutos.Location = new System.Drawing.Point(12, 380);
            this.lblGestaoProdutos.Name = "lblGestaoProdutos";
            this.lblGestaoProdutos.Size = new System.Drawing.Size(197, 20);
            this.lblGestaoProdutos.TabIndex = 0;
            this.lblGestaoProdutos.Text = "GESTÃO DE PRODUTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 455);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 182);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUrlImagem);
            this.panel1.Controls.Add(this.lblUrlImagem);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.rdoStatusInativo);
            this.panel1.Controls.Add(this.rdoStatusAtivo);
            this.panel1.Controls.Add(this.txtEstoque);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblEstoque);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblPreco);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 322);
            this.panel1.TabIndex = 2;
            // 
            // txtUrlImagem
            // 
            this.txtUrlImagem.Location = new System.Drawing.Point(16, 235);
            this.txtUrlImagem.Name = "txtUrlImagem";
            this.txtUrlImagem.Size = new System.Drawing.Size(371, 20);
            this.txtUrlImagem.TabIndex = 16;
            // 
            // lblUrlImagem
            // 
            this.lblUrlImagem.AutoSize = true;
            this.lblUrlImagem.Location = new System.Drawing.Point(13, 219);
            this.lblUrlImagem.Name = "lblUrlImagem";
            this.lblUrlImagem.Size = new System.Drawing.Size(84, 13);
            this.lblUrlImagem.TabIndex = 15;
            this.lblUrlImagem.Text = "URL da Imagem";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(271, 284);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 284);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(494, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(138, 284);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rdoStatusInativo
            // 
            this.rdoStatusInativo.AutoSize = true;
            this.rdoStatusInativo.Location = new System.Drawing.Point(601, 236);
            this.rdoStatusInativo.Name = "rdoStatusInativo";
            this.rdoStatusInativo.Size = new System.Drawing.Size(57, 17);
            this.rdoStatusInativo.TabIndex = 11;
            this.rdoStatusInativo.TabStop = true;
            this.rdoStatusInativo.Text = "Inativo";
            this.rdoStatusInativo.UseVisualStyleBackColor = true;
            // 
            // rdoStatusAtivo
            // 
            this.rdoStatusAtivo.AutoSize = true;
            this.rdoStatusAtivo.Location = new System.Drawing.Point(540, 236);
            this.rdoStatusAtivo.Name = "rdoStatusAtivo";
            this.rdoStatusAtivo.Size = new System.Drawing.Size(55, 17);
            this.rdoStatusAtivo.TabIndex = 10;
            this.rdoStatusAtivo.TabStop = true;
            this.rdoStatusAtivo.Text = "Status";
            this.rdoStatusAtivo.UseVisualStyleBackColor = true;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(476, 135);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(285, 20);
            this.txtEstoque.TabIndex = 9;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(476, 18);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(285, 21);
            this.cmbCategoria.TabIndex = 8;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 180);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(371, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 76);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(371, 79);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(371, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(473, 118);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 4;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(473, 3);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 163);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 60);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCadastroGestao
            // 
            this.lblCadastroGestao.AutoSize = true;
            this.lblCadastroGestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroGestao.Location = new System.Drawing.Point(8, 9);
            this.lblCadastroGestao.Name = "lblCadastroGestao";
            this.lblCadastroGestao.Size = new System.Drawing.Size(213, 20);
            this.lblCadastroGestao.TabIndex = 3;
            this.lblCadastroGestao.Text = "Cadastro/Gestão de Produto";
            // 
            // cmbFiltroStatus
            // 
            this.cmbFiltroStatus.FormattingEnabled = true;
            this.cmbFiltroStatus.Location = new System.Drawing.Point(16, 428);
            this.cmbFiltroStatus.Name = "cmbFiltroStatus";
            this.cmbFiltroStatus.Size = new System.Drawing.Size(130, 21);
            this.cmbFiltroStatus.TabIndex = 4;
            // 
            // lblFiltroStatus
            // 
            this.lblFiltroStatus.AutoSize = true;
            this.lblFiltroStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroStatus.Location = new System.Drawing.Point(13, 412);
            this.lblFiltroStatus.Name = "lblFiltroStatus";
            this.lblFiltroStatus.Size = new System.Drawing.Size(44, 16);
            this.lblFiltroStatus.TabIndex = 5;
            this.lblFiltroStatus.Text = "Status";
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(169, 428);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(130, 21);
            this.cmbFiltroCategoria.TabIndex = 6;
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(169, 414);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblFiltroCategoria.TabIndex = 7;
            this.lblFiltroCategoria.Text = "Categoria";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.lblFiltroCategoria);
            this.Controls.Add(this.cmbFiltroCategoria);
            this.Controls.Add(this.lblFiltroStatus);
            this.Controls.Add(this.cmbFiltroStatus);
            this.Controls.Add(this.lblCadastroGestao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblGestaoProdutos);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestaoProdutos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCadastroGestao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.RadioButton rdoStatusAtivo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rdoStatusInativo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbFiltroStatus;
        private System.Windows.Forms.Label lblFiltroStatus;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.TextBox txtUrlImagem;
        private System.Windows.Forms.Label lblUrlImagem;
    }
}