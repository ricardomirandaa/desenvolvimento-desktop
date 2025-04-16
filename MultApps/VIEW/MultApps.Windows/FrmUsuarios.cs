using MultApps.Models.Entities;
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
            usuario.Cpf = txtCpf.Text;
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
            var usuarios = new Usuarios();
            var usuariosRepository = new UsuariosRepository();
            usuarios.Nome = txtNome.Text;
            usuarios.Status = (StatusEnum)cmbStatus.SelectedIndex;


            if (string.IsNullOrEmpty(txtNome.Text))
            {
                var resultado = usuariosRepository.CadastrarUsuario(usuarios);
                if (resultado)
                {
                    MessageBox.Show("Categoria cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar categoria");
                }
            }
            else
            {
                usuarios.Id = int.Parse(txtId.Text);
                var resultado = usuariosRepository.AtualizarUsuario(usuarios);
                if (resultado)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário");
                }
            }
            CarregarTodosUsuarios();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var usuarioId = int.Parse(txtId.Text);
            var usuariosRepository = new UsuariosRepository();
            var sucesso = usuariosRepository.DeletarUsuario(usuarioId);

            if (sucesso)
            {
                MessageBox.Show($"Usuário removido com sucesso");
                CarregarTodosUsuarios();
            }
            else
            {
                MessageBox.Show($"Erro ao deletar usuário: {txtNome.Text}");
            }
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
                HeaderText = "Nome do Usuário",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "CPF",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "000.000.000-00" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Senha",
                HeaderText = "Senha",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "*****" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HeaderText = "Data de Cadastro",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAcesso",
                HeaderText = "Data do último acesso",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            });
            dataGridView1.DataSource = listaDeUsuarios;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var usuarioId = (int)row.Cells[0].Value;

            var usuarioRepository = new UsuariosRepository();
            var usuarios = usuarioRepository.ObterUsuarioPorId(usuarioId);

            if (usuarios == null)
            {
                MessageBox.Show($"Usuário #{usuarios} não encontrado");
                return;
            }

            txtId.Text = usuarios.Id.ToString();
            txtNome.Text = usuarios.Nome;
            txtEmail.Text = usuarios.Email;
            txtSenha.Text = usuarios.Senha;
            txtCpf.Text = usuarios.Cpf;
            cmbStatus.SelectedIndex = (int)usuarios.Status;
            txtDataAcesso.Text = usuarios.DataAlteracao.ToString("dd/MM/yyyy");
            txtDataCadastro.Text = usuarios.DataCadastro.ToString("dd/MM/yyyy");
        }

    }
}
