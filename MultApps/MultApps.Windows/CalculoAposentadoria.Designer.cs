namespace MultApps.Windows
{
    partial class CalculoAposentadoria
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
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtContribuicao = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblContribuicao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(149, 93);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(101, 20);
            this.txtNascimento.TabIndex = 0;
            // 
            // txtContribuicao
            // 
            this.txtContribuicao.Location = new System.Drawing.Point(429, 93);
            this.txtContribuicao.Name = "txtContribuicao";
            this.txtContribuicao.Size = new System.Drawing.Size(114, 20);
            this.txtContribuicao.TabIndex = 2;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(146, 77);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblNascimento.TabIndex = 3;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(288, 77);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo";
            // 
            // lblContribuicao
            // 
            this.lblContribuicao.AutoSize = true;
            this.lblContribuicao.Location = new System.Drawing.Point(426, 77);
            this.lblContribuicao.Name = "lblContribuicao";
            this.lblContribuicao.Size = new System.Drawing.Size(117, 13);
            this.lblContribuicao.TabIndex = 5;
            this.lblContribuicao.Text = "Tempo de Contribuição";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(301, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Homem",
            "Mulher"});
            this.cmbSexo.Location = new System.Drawing.Point(291, 93);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(102, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // CalculoAposentadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblContribuicao);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.txtContribuicao);
            this.Controls.Add(this.txtNascimento);
            this.Name = "CalculoAposentadoria";
            this.Text = "CalculoAposentadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtContribuicao;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblContribuicao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbSexo;
    }
}