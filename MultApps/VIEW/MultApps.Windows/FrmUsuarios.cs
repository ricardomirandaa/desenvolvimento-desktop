using MultApps.Models.Entities;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CarregarTodosUsuarios();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            var usuarioRepository = new UsuariosRepository();
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.cpf = int.Parse(txtCpf.Text);
            usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;
            var resultado = usuarioRepository.CadastrarUsuario(usuario);
            if (resultado)
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        private void CarregarTodosUsuarios()
        {
            var usuarioRepository = new UsuariosRepository();
            var listaDeUsuarios = usuarioRepository.ListarTodosUsuarios();

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
            dataGridView1.DataSource = listaDeUsuarios;
        }
    }
}
