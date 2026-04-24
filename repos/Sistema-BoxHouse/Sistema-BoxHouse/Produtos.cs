using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_BoxHouse
    // primeiro passo crie class produto
    // crinado valores string e double
{
    public class Produtos
    {
        public string Nome_produto {  get; set; }
        public double Preco {  get; set; }
        // como se fosse um pedido e item e salva 

        public Produtos(string nome, double preco)
        { 
            Nome_produto = nome;
            Preco = preco;
        }

        

        


    }
}
