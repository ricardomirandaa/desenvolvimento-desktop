using Dapper;
using MultApps.Models.Entities.Abstract;
using MySql.Data.MySqlClient;
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
    }
}
