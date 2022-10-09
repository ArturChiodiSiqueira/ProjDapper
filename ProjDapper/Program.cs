using ProjDapper.Model;
using ProjDapper.Service;
using System;

namespace ProjDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            Client client = new Client()
            {
                ID = 1,
                Nome = "Teste",
                Telefone = "16 997349433"
            };

            new ClientService().Add(client);

            new ClientService().GetAll().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Ufa!");
        }
    }
}
