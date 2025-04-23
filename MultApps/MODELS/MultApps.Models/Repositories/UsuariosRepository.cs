using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultApps.Models.Repositories
{
    public class UsuariosRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        public bool CadastrarUsuario(Usuarios usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario (Nome, Cpf, Email, Senha, Status) VALUES (@Nome, @Cpf, @Email, @Senha, @Status)";
                var parametro = new DynamicParameters();
                parametro.Add("@Nome", usuario.Nome);
                parametro.Add("@Cpf", usuario.Cpf);
                parametro.Add("@Email", usuario.Email);
                parametro.Add("@Senha", usuario.Senha);
                parametro.Add("@Status", usuario.Status);
                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
            }
        }
        public bool AtualizarUsuario(Usuarios usuarios)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario SET Nome = @Nome, Email = @Email, Senha = @Senha, Cpf = @Cpf WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", usuarios.Id);
                parametros.Add("@Nome", usuarios.Nome);
                parametros.Add("@Email", usuarios.Email);
                parametros.Add("@Senha", usuarios.Senha);
                parametros.Add("@Cpf", usuarios.Cpf);
                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }
        public bool DeletarUsuario(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM usuario WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public DataTable ListarTodosUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id as Id,
                                    nome as Nome,
                                    cpf as Cpf,
                                    email as Email,
                                    data_cadastro as DataCadastro,
                                    data_alteracao as DataAlteracao,
                                    data_ultimo_acesso as DataUltimoAcesso
                                 FROM usuario";
                var usuarios = db.Query<Usuarios>(comandoSql).ToList();
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Cpf", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                dataTable.Columns.Add("Data Ultimo Acesso", typeof(DateTime));
                foreach (var usuario in usuarios)
                {
                    dataTable.Rows.Add(usuario.Id,
                                       usuario.Nome,
                                       usuario.Cpf,
                                       usuario.Email,
                                       usuario.DataCadastro,
                                       usuario.DataAlteracao,
                                       usuario.DataUltimoAcesso);
                }
                return dataTable;
            }
        }
        public Usuarios ObterUsuarioPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, Nome, Email, Senha, Cpf FROM usuario WHERE id = @Id";
                var parametro = new DynamicParameters();
                parametro.Add("@Id", id);
                var resultado = db.Query<Usuarios>(comandoSql, parametro).FirstOrDefault();
                return resultado;
            }
        }
        public bool EmailExistente(string email)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT COUNT(*) FROM usuario WHERE Email = @Email";
                var parametro = new DynamicParameters();
                parametro.Add("@Email", email);
                var resultado = db.ExecuteScalar<int>(comandoSql, parametro);
                return resultado > 0;
            }
        }
    }
}
