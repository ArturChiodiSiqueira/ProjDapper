using ProjDapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDapper.Repository
{
    internal interface IClientRepository
    {
        bool Add(Client cliente);

        List<Client> GetAll();
    }
}
