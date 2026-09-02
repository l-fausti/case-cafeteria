using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseCafeteria.Model
{
    public class Pedido
    {
        public int Numero { get; set; }
        public string NomeCliente { get; set; }
        List<string> Itens { get; set; } = new List<string>();

        private static int contador = 0;
 
        public Pedido (string nomecliente, List<string> itens)
        {
            contador++;
            Numero = contador;
            NomeCliente = nomecliente;
            Itens = itens;
        }
 
        public void Apresentar()
        {
            string itensFormatados = string.Join(", ", Itens);
            Console.WriteLine($"Numero: {Numero}. Nome do cliente: {NomeCliente}. Itens: {itensFormatados}");
        }
        
    }
}