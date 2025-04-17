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
            var status = new[] { "ativo", "inativo" };
            var filtros = new[] { "todos", "ativo", "inativo"};
            cmbStatus.Items.AddRange(status);
            cmbStatus.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TemCamposEmBranco())
                {
                    return;
                }

                var usuario = new Usuarios();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = mtxCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                var usuariosRepository = new UsuariosRepository();

                var emailJaExistente = usuariosRepository.EmailExistente(usuario.Email);
                if (emailJaExistente)
                {
                    MessageBox.Show($"Email já cadastrado");
                    txtEmail.Focus();
                    return;
                }

                var sucesso = usuariosRepository.CadastrarUsuario(usuario);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso");
                    CarregarTodosUsuarios();
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar usuário: {usuario.Nome}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show($"Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(mtxCpf.Text))
            {
                MessageBox.Show($"Campo Cpf é obrigatório");
                mtxCpf.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show($"Campo Email é obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show($"Campo Senha é obrigatório");
                txtSenha.Focus();
                return true;
            }
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show($"Campo Status é obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
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
            txtNome.Text = usuarios.Nome;
            txtEmail.Text = usuarios.Email;
            txtSenha.Text = usuarios.Senha;
            mtxCpf.Text = usuarios.Cpf;
            cmbStatus.SelectedIndex = (int)usuarios.Status;
            txtDataAcesso.Text = usuarios.DataAlteracao.ToString("dd/MM/yyyy");
            txtDataCadastro.Text = usuarios.DataCadastro.ToString("dd/MM/yyyy");
        }

    }
}
