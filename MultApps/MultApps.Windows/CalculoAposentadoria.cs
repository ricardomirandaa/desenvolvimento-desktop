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
    public partial class CalculoAposentadoria : Form
    {
        public CalculoAposentadoria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nascimento = DateTime.Parse(txtNascimento.Text);
            var sexo = cmbSexo.Text;
            var contribucao = int.Parse(txtContribuicao.Text);
            var idade = DateTime.Now.Year - nascimento.Year;

            if (sexo == "Homem")
            {
                if (idade >= 65 && contribucao >= 20)
                {
                    MessageBox.Show("Você pode dar entrada no processo de aposentadoria");
                }
                else
                {
                    MessageBox.Show("Você não cumpre o requisitos para se aposentar");
                }
            }
            else
            {
                if (idade >= 62 && contribucao >= 30)
                {
                    MessageBox.Show("Você pode dar entrada no processo de aposentadoria");
                }
                else
                {
                    MessageBox.Show("Você não cumpre o requisitos para se aposentar");
                }
            }
        }
    }
}
