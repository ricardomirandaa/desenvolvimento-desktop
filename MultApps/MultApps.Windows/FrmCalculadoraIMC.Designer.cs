namespace MultApps.Windows
{
    partial class FrmCalculadoraIMC
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
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.chkHomem = new System.Windows.Forms.CheckBox();
            this.chkMulher = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.Color.Goldenrod;
            this.chkAdulto.Location = new System.Drawing.Point(51, 55);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(68, 22);
            this.chkAdulto.TabIndex = 0;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.CheckedChanged += new System.EventHandler(this.chkAdulto_CheckedChanged);
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkCrianca.Location = new System.Drawing.Point(154, 55);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(78, 22);
            this.chkCrianca.TabIndex = 1;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = true;
            this.chkCrianca.CheckedChanged += new System.EventHandler(this.chkCrianca_CheckedChanged);
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(47, 32);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(95, 24);
            this.lblSelecione.TabIndex = 2;
            this.lblSelecione.Text = "Selecione";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(411, 32);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 24);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // chkHomem
            // 
            this.chkHomem.AutoSize = true;
            this.chkHomem.Checked = true;
            this.chkHomem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHomem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHomem.ForeColor = System.Drawing.Color.Goldenrod;
            this.chkHomem.Location = new System.Drawing.Point(414, 55);
            this.chkHomem.Name = "chkHomem";
            this.chkHomem.Size = new System.Drawing.Size(81, 22);
            this.chkHomem.TabIndex = 4;
            this.chkHomem.Text = "Homem";
            this.chkHomem.UseVisualStyleBackColor = true;
            // 
            // chkMulher
            // 
            this.chkMulher.AutoSize = true;
            this.chkMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMulher.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkMulher.Location = new System.Drawing.Point(514, 55);
            this.chkMulher.Name = "chkMulher";
            this.chkMulher.Size = new System.Drawing.Size(72, 22);
            this.chkMulher.TabIndex = 5;
            this.chkMulher.Text = "Mulher";
            this.chkMulher.UseVisualStyleBackColor = true;
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkMulher);
            this.Controls.Add(this.chkHomem);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.chkCrianca);
            this.Controls.Add(this.chkAdulto);
            this.Name = "FrmCalculadoraIMC";
            this.Text = "FrmCalculadoraIMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.CheckBox chkCrianca;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.CheckBox chkHomem;
        private System.Windows.Forms.CheckBox chkMulher;
    }
}