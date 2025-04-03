using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enum;
using MultApps.Models.Repositories;
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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoriaRepository = new CategoriaRepository();

            var categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cmbStatus.SelectedIndex;
            var categoriarepository = new CategoriaRepository();
            var resultado = categoriarepository.CadastrarCategoria(categoria);
            if(resultado)
            {
                MessageBox.Show("Categoria cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar categoria");
            }
        }
    }
}
