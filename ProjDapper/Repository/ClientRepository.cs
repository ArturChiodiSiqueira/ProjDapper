using Dapper;
using ProjDapper.Config;
using ProjDapper.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjDapper.Repository
{
    internal class ClientRepository : IClientRepository
    {
        private string _conn;

        public ClientRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Client cliente)
        {
            bool result = false;

            using(var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Client.INSERT, cliente);
                result = true;
            }
            return result;
        }

        public List<Client> GetAll()
        {
            using(var db = new SqlConnection(_conn))
            {
                db.Open();
                var clients = db.Query<Client>(Client.SELECT);
                return (List<Client>) clients;
            }
        }
    }
}
