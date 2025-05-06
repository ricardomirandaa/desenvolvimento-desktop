using Dapper;
using MultApps.Models.Entities;
using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enum;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public class ProdutoRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev;Uid=root;Pwd=root";

        public bool CadastrarUsuario(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO produto (CategoriaId, Nome, Preco, QuantidadeEmEstoque, Status) 
                                                VALUES (@CategoriaId, @Nome, @Preco, @QuantidadeEmEstoque, @Status)";
                var parametro = new DynamicParameters();
                parametro.Add("@CategoriaId", produto.CategoriaId);
                parametro.Add("@Nome", produto.Nome);
                parametro.Add("@Cpf", produto.Preco);
                parametro.Add("@Email", produto.QuantidadeEmEstoque);
                parametro.Add("@Status", produto.Status);
                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
            }
        }

        public bool DeletarProduto(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM produto WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
    }
}
