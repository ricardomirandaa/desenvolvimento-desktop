namespace MultApps.Windows
{
    partial class AppCarteirinha
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNascimento2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNascimento2 = new System.Windows.Forms.TextBox();
            this.btnCarteirinha = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.lblIdadeCliente = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(100, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(100, 153);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblNascimento2
            // 
            this.lblNascimento2.AutoSize = true;
            this.lblNascimento2.Location = new System.Drawing.Point(100, 212);
            this.lblNascimento2.Name = "lblNascimento2";
            this.lblNascimento2.Size = new System.Drawing.Size(104, 13);
            this.lblNascimento2.TabIndex = 2;
            this.lblNascimento2.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(101, 169);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtNascimento2
            // 
            this.txtNascimento2.Location = new System.Drawing.Point(103, 228);
            this.txtNascimento2.Name = "txtNascimento2";
            this.txtNascimento2.Size = new System.Drawing.Size(102, 20);
            this.txtNascimento2.TabIndex = 5;
            // 
            // btnCarteirinha
            // 
            this.btnCarteirinha.Location = new System.Drawing.Point(101, 279);
            this.btnCarteirinha.Name = "btnCarteirinha";
            this.btnCarteirinha.Size = new System.Drawing.Size(101, 23);
            this.btnCarteirinha.TabIndex = 6;
            this.btnCarteirinha.Text = "Gerar Carteirinha";
            this.btnCarteirinha.UseVisualStyleBackColor = true;
            this.btnCarteirinha.Click += new System.EventHandler(this.btnCarteirinha_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(54, 185);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(85, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Nome do Cliente";
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Location = new System.Drawing.Point(54, 212);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(77, 13);
            this.lblCPFCliente.TabIndex = 10;
            this.lblCPFCliente.Text = "CPF do Cliente";
            // 
            // lblIdadeCliente
            // 
            this.lblIdadeCliente.AutoSize = true;
            this.lblIdadeCliente.Location = new System.Drawing.Point(54, 236);
            this.lblIdadeCliente.Name = "lblIdadeCliente";
            this.lblIdadeCliente.Size = new System.Drawing.Size(84, 13);
            this.lblIdadeCliente.TabIndex = 11;
            this.lblIdadeCliente.Text = "Idade do Cliente";
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(41, 28);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(130, 134);
            this.picBox2.TabIndex = 12;
            this.picBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBox2);
            this.panel1.Controls.Add(this.lblIdadeCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblCPFCliente);
            this.panel1.Location = new System.Drawing.Point(532, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 295);
            this.panel1.TabIndex = 13;
            // 
            // AppCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCarteirinha);
            this.Controls.Add(this.txtNascimento2);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNascimento2);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Name = "AppCarteirinha";
            this.Text = "AppCarteirinha";
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNascimento2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNascimento2;
        private System.Windows.Forms.Button btnCarteirinha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.Label lblIdadeCliente;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Panel panel1;
    }
}