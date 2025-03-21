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
    public partial class LojaAcai : Form
    {
        public LojaAcai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 300ml", 1, 15.00m));
            picBox1.ImageLocation = ImagemPedido.Acai300ml;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 500ml", 1, 20.00m));
            picBox1.ImageLocation = ImagemPedido.Acai500ml;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 700ml", 1, 25.00m));
            picBox1.ImageLocation = ImagemPedido.Acai700ml;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 1L", 1, 35.00m));
            picBox1.ImageLocation = ImagemPedido.AcaiFamilia;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem != null)
            {
                listBoxPedidos.Items.Remove(listBoxPedidos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudGranola.Minimum = 1;
            nudGranola.Maximum = 50;
            nudGranola.Increment = 1;
            nudGranola.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Granola", 1, 2.00m));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudBanana.Minimum = 1;
            nudBanana.Maximum = 50;
            nudBanana.Increment = 1;
            nudBanana.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Banana", 1, 2.50m));
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudMorango.Minimum = 1;
            nudMorango.Maximum = 50;
            nudMorango.Increment = 1;
            nudMorango.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Morango", 1, 3.00m));
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Leite Condensado", 1, 2.00m));
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Uva", 1, 1.00m));
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Maçã", 1, 1.50m));
        }

        private void nudChocolate_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Chocolate", 1, 0.50m));
        }

        private void nudCaramelo_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Caramelo", 1, 1.50m));
        }

        private void nudMel_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Mel", 1, 1.00m));
        }

        private void nudAmora_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Amora", 1, 2.00m));
        }

        private void nudUva2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Uva", 1, 0.50m));
        }

        private void nudMenta_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDownQuantidade = new NumericUpDown();
            nudLeiteCondensado.Minimum = 1;
            nudLeiteCondensado.Maximum = 50;
            nudLeiteCondensado.Increment = 1;
            nudLeiteCondensado.Value = 1;

            this.Controls.Add(numericUpDownQuantidade);
            this.Controls.Add(listBoxPedidos);
            int quantidade = (int)numericUpDownQuantidade.Value;
            listBoxPedidos.Items.Add(new PedidoItem("Menta", 1, 1.50m));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var total = 0m;
            foreach (PedidoItem item in listBoxPedidos.Items)
            {
                total += item.Preco;
                lblTotal2.Text = total.ToString("C");
            }
        }
    }
}
