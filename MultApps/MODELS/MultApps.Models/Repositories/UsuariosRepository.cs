﻿using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
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
        public List<Usuarios> ListarTodosUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, Nome, Email, Senha, Cpf FROM usuario";
                var resultado = db.Query<Usuarios>(comandoSql).ToList();
                return resultado;
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
