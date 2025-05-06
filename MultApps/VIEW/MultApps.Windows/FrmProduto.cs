using MultApps.Models.Entities;
using MultApps.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto();

            produto.CategoriaId = (int)cmbFiltroCategoria.SelectedValue;
            produto.Nome = txtNome.Text;
            produto.Preco = decimal.Parse(txtPreco.Text);
            produto.QuantidadeEmEstoque = int.Parse(txtPreco.Text);
            produto.Status = (MultApps.Models.Enum.StatusEnum)cmbFiltroStatus.SelectedIndex;

            var produtoRepository = new ProdutoRepository();

            var sucesso = produtoRepository.CadastrarUsuario(produto);

            if (sucesso)
            {
                MessageBox.Show($"Usuário {produto.Nome} cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {produto.Nome}");
            }
            
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            cmbCategoria.Text = string.Empty;
            txtDescricao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            var categoriaId = int.Parse(txtNome.Text);
            var produtoRepository = new ProdutoRepository();
            var categoriaRepository = new CategoriaRepository();
            var sucesso = produtoRepository.DeletarProduto(categoriaId);

            if (sucesso)
            {
                MessageBox.Show($"Categoria removida com sucesso");
                produtoRepository.DeletarProduto(categoriaId);
            }
            else
            {
                MessageBox.Show($"Erro ao deletar categoria: {txtNome.Text}");
            }
        }
    }
}
    

