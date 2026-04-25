using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_BoxHouse
{
    public class Cliente
    {
        public string nome_cliente {  get; set; }
        public int telefone { get; set; }
        public string nome_pet { get; set; }

        public Cliente (string Nome, int Telefone, string Nome_pet)
        {
            nome_cliente = Nome;
            telefone = Telefone;
            nome_pet = Nome_pet;
        }
    }
}
