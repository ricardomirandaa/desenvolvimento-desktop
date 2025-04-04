namespace MultApps.Windows
{
    partial class FrmCategoria
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataCriacao = new System.Windows.Forms.Label();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.txtDataCriacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.grpCategoriaProduto = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCategoriaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(124, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.AutoSize = true;
            this.lblDataCriacao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCriacao.Location = new System.Drawing.Point(280, 28);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(103, 17);
            this.lblDataCriacao.TabIndex = 3;
            this.lblDataCriacao.Text = "Data De Criação";
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAlteracao.Location = new System.Drawing.Point(429, 27);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(151, 17);
            this.lblDataAlteracao.TabIndex = 4;
            this.lblDataAlteracao.Text = "Data da ultima alteração";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(6, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(82, 23);
            this.txtId.TabIndex = 5;
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAlteracao.Location = new System.Drawing.Point(432, 43);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(148, 23);
            this.txtDataAlteracao.TabIndex = 8;
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Enabled = false;
            this.txtDataCriacao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCriacao.Location = new System.Drawing.Point(283, 43);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.Size = new System.Drawing.Size(100, 23);
            this.txtDataCriacao.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(127, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(94, 23);
            this.txtNome.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(634, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 17);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Inativo",
            "Ativo",
            "Excluído"});
            this.cmbStatus.Location = new System.Drawing.Point(637, 42);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(88, 25);
            this.cmbStatus.TabIndex = 12;
            // 
            // grpCategoriaProduto
            // 
            this.grpCategoriaProduto.BackColor = System.Drawing.Color.White;
            this.grpCategoriaProduto.Controls.Add(this.btnSalvar);
            this.grpCategoriaProduto.Controls.Add(this.txtId);
            this.grpCategoriaProduto.Controls.Add(this.cmbStatus);
            this.grpCategoriaProduto.Controls.Add(this.lblId);
            this.grpCategoriaProduto.Controls.Add(this.lblStatus);
            this.grpCategoriaProduto.Controls.Add(this.lblNome);
            this.grpCategoriaProduto.Controls.Add(this.txtNome);
            this.grpCategoriaProduto.Controls.Add(this.lblDataCriacao);
            this.grpCategoriaProduto.Controls.Add(this.txtDataCriacao);
            this.grpCategoriaProduto.Controls.Add(this.lblDataAlteracao);
            this.grpCategoriaProduto.Controls.Add(this.txtDataAlteracao);
            this.grpCategoriaProduto.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategoriaProduto.Location = new System.Drawing.Point(12, 52);
            this.grpCategoriaProduto.Name = "grpCategoriaProduto";
            this.grpCategoriaProduto.Size = new System.Drawing.Size(776, 143);
            this.grpCategoriaProduto.TabIndex = 13;
            this.grpCategoriaProduto.TabStop = false;
            this.grpCategoriaProduto.Text = "CATEGORIA DE PRODUTOS";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Honeydew;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(637, 102);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 198);
            this.dataGridView1.TabIndex = 14;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpCategoriaProduto);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.grpCategoriaProduto.ResumeLayout(false);
            this.grpCategoriaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataCriacao;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.TextBox txtDataCriacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox grpCategoriaProduto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}