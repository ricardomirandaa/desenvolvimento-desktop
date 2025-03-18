using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class AppCarteirinha : Form
    {
        public AppCarteirinha()
        {
            InitializeComponent();
        }

        private void btnCarteirinha_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var cpf = txtCPF.Text;
            var dataNascimento = DateTime.Parse(txtNascimento2.Text);
            var idade = int.Parse(txtNascimento2.Text);
            var meio = cpf.Substring(3, 3);
            var ultimosTres = cpf.Substring(6, 3);

            if (idade <= 12)
            {
                this.BackColor = Color.Blue;
                lblCliente.Text = $"{nome}";
                lblCPFCliente.Text = $"{cpf}";
                lblIdadeCliente.Text = $"{idade}";
                picBox2.Load(FaseImagem.infantil);
            }
            else if(idade > 18)
            {
                this.BackColor = Color.Green;
                lblCliente.Text = $"{nome}";
                lblCPFCliente.Text = $"{cpf}";
                lblIdadeCliente.Text = $"{idade}";
                picBox2.Load(FaseImagem.jovem);
            }
            else if (idade <= 40)
            {
                this.BackColor = Color.Yellow;
                lblCliente.Text = $"{nome}";
                lblCPFCliente.Text = $"{cpf}";
                lblIdadeCliente.Text = $"{idade}";
                picBox2.Load(FaseImagem.adulto);
            }
            else if(idade > 65)
            {
                this.BackColor = Color.Purple;
                lblCliente.Text = $"{nome}";
                lblCPFCliente.Text = $"{cpf}";
                lblIdadeCliente.Text = $"{idade}";
                picBox2.Load(FaseImagem.idoso);
            }

            lblCPFCliente.Text = $"***.{meio}.{ultimosTres}-***";
        }
    }
}
