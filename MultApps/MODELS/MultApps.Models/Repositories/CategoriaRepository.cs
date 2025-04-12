using Dapper;
using MultApps.Models.Entities.Abstract;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultApps.Models.Repositories
{
    public class CategoriaRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO categoria (Nome, Status) VALUES (@Nome, @Status)";
                var parametro = new DynamicParameters();
                parametro.Add("@Nome", categoria.Nome);
                parametro.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
            }
        }
        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao AS DataCadastro, data_alteracao AS DataAlteracao, Status FROM categoria";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;
            }
        }
        public bool AtualizarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE categoria SET Nome = @Nome, Status = @Status WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", categoria.Id);
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);
                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }
        public bool DeletarCategoria(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM categoria WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public Categoria ObterCategoriaPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao AS DataCadastro, data_alteracao AS DataAlteracao, Status FROM categoria WHERE id = @Id";
                var parametro = new DynamicParameters();
                parametro.Add("@Id", id);
                var resultado = db.Query<Categoria>(comandoSql, parametro).FirstOrDefault();
                return resultado;
            }
        }

    }
}