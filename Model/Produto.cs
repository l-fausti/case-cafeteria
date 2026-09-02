using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseCafeteria.Model
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto (string nome, decimal preco)
        {
            Nome = nome.ToString();
            Preco = preco;
        }

        
    }
}