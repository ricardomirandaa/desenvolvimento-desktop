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
            CarregarTodasCategorias();
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
            CarregarTodasCategorias();

        }
        private void CarregarTodasCategorias()
        {
            var categoriaRepository = new CategoriaRepository();
            var listaDeCategorias = categoriaRepository.ListarTodasCategorias();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome da Categoria",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HeaderText = "Data de Cadastro",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            });
            dataGridView1.DataSource = listaDeCategorias;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                if (e.Value != null)
                {
                    StatusEnum status = (StatusEnum)e.Value;
                    switch (status)
                    {
                        case StatusEnum.Inativo:
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        case StatusEnum.Ativo:
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case StatusEnum.Excluido:
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                    }
                }
            }
        }
    }
}
