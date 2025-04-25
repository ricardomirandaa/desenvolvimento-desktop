using MultApps.Models.Enum;
using MultApps.Models.Repositories;
using MultApps.Models.Services;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("usuário é obrigatório");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("senha é obrigatório");
                txtSenha.Focus();
                return;
            }

            var usuarioRepository = new UsuariosRepository();
            var usuario = usuarioRepository.ObterUsuarioPorEmail(txtUsuario.Text);

            if (usuario == null || usuario.Email != txtUsuario.Text)
            {
                MessageBox.Show("Usuário não encontrado");
                txtUsuario.Focus();
                return;
            }
            if (usuario.Status == StatusEnum.Inativo)
            {
                MessageBox.Show("O usuário está inativo");
                txtUsuario.Focus();
                return;
            }

            var senhaConfere = CriptografiaService.Verificar(txtSenha.Text, usuario.Senha);

            if(senhaConfere)
            {
                MessageBox.Show("Usuário e senha correto");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida");
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe o email do seu usuário");
                txtUsuario.Focus();
                return;
            }

            var usuarioRepository = new UsuariosRepository();

            var novaSenha = CriptografiaService.Criptografar("123456");

            var senhaAtualizou = usuarioRepository.AtualizarSenha(novaSenha, txtUsuario.Text);

            if(senhaAtualizou)
            {
                MessageBox.Show("Senha atualizada com sucesso. Anova senha é: 123456");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a senha");
            }
        }
    }
}
