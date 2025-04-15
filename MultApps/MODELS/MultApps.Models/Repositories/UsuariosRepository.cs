using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public class UsuariosRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";
        
        public bool CadastrarUsuario(Usuarios usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuarios (Nome, Email, Senha, cpf) VALUES (@Nome, @Email, @Senha, @cpf)";
                var parametro = new DynamicParameters();
                parametro.Add("@Nome", usuario.Nome);
                parametro.Add("@Email", usuario.Email);
                parametro.Add("@Senha", usuario.Senha);
                parametro.Add("@cpf", usuario.cpf);
                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
            }
        }

        public bool AtualizarUsuario(Usuarios usuarios)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuarios SET Nome = @Nome, Email = @Email, Senha = @Senha, cpf = @cpf WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", usuarios.Id);
                parametros.Add("@Nome", usuarios.Nome);
                parametros.Add("@Email", usuarios.Email);
                parametros.Add("@Senha", usuarios.Senha);
                parametros.Add("@cpf", usuarios.cpf);
                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }
        public List<Usuarios> ListarTodosUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, Nome, Email, Senha, cpf FROM usuarios";
                var resultado = db.Query<Usuarios>(comandoSql).ToList();
                return resultado;
            }
        }
    }
}
