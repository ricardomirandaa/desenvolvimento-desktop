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
            listBoxPedidos.Items.Add(new PedidoItem("Banana", 1, 2.50m));
            listBoxPedidos.Items.Add(new PedidoItem("Morango", 1, 3.00m));
            listBoxPedidos.Items.Add(new PedidoItem("Leite Condensado", 1, 2.00m));
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
    }
}
