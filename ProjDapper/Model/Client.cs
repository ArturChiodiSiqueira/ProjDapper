using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDapper.Model
{
    internal class Client
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public readonly static string INSERT = "INSERT INTO TB_Cliente (ID,Nome,Telefone) VALUES(@Id,@Nome,@Telefone)";
        public readonly static string SELECT = "SELECT Id,Nome,Telefone FROM TB_Cliente";

        public override string ToString()
        {
            return "ID: " + ID + "\nNome: " + Nome + "\nTelefone: " + Telefone;
        }
    }
}
