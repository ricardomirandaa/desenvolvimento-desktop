﻿using Dapper;
using Microsoft.SqlServer.Server;
using MultApps.Models.Entities.Abstract;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Categoria AtualizarCategoria()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE categoria SET Nome = @Nome, Status = @Status WHERE id = @Id";
                var categoriaAtualizada = new Categoria();
                var parametro = new DynamicParameters();
                parametro.Add("@Id", categoriaAtualizada.Id);
                var resultado = db.Query<Categoria>Execute(comandoSql, parametro);
                return;
            }
        }
    }
}