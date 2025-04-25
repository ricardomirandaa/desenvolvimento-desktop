using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;

namespace MultApps.Models.Repositories
{
    public class UsuariosRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        public bool CadastrarUsuario(Usuario usuario)
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
        
        public DataTable ListarTodosUsuarios(string status)
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
                var usuarios = db.Query<Usuario>(comandoSql).ToList();
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
        
        public DataTable ListarUsuariosPorStatus(string status)
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
                                 FROM usuario
                                 WHERE status = @Status";
                var parametro = new DynamicParameters();
                parametro.Add("@Status", status);
                var usuarios = db.Query<Usuario>(comandoSql).ToList();
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Cpf", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                dataTable.Columns.Add("Data Ultimo Acesso", typeof(DateTime));
                dataTable.Columns.Add("Status", typeof(string));
                foreach (var usuario in usuarios)
                {
                    dataTable.Rows.Add(usuario.Id,
                                       usuario.Nome,
                                       usuario.Cpf,
                                       usuario.Email,
                                       usuario.DataCadastro,
                                       usuario.DataAlteracao,
                                       usuario.DataUltimoAcesso,
                                       usuario.Status);
                }
                return dataTable;
            }
        }
        
        public Usuario ObterUsuarioPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id as Id, 
                                          nome as Nome,
                                          cpf as Cpf,
                                          email as Email, 
                                          senha as Senha,
                                          data_criacao as DataCadastro,
                                          data_ultimo_acesso as DataUltimoAcesso,
                                          status as Status
                                          FROM usuario WHERE id = @Id";
                var parametro = new DynamicParameters();
                parametro.Add("@Id", id);
                var resultado = db.Query<Usuario>(comandoSql, parametro).FirstOrDefault();
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

        public Usuario ObterUsuarioPorEmail(string email)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id as Id, 
                                          nome as Nome,
                                          email as Email, 
                                          senha as Senha,
                                          status as Status
                                          FROM usuario WHERE email = @Email";
                var parametro = new DynamicParameters();
                parametro.Add("@Email", email);
                var resultado = db.Query<Usuario>(comandoSql, parametro).FirstOrDefault();
                return resultado;
            }
        }

        public bool AtualizarSenha(string novaSenha, string email)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario SET senha = @Senha WHERE email = @Email";
                var parametros = new DynamicParameters();
                parametros.Add("@Senha", novaSenha);
                parametros.Add("@Email", email);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }
    }
}
