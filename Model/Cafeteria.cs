using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;
using LanguageExt;
using LanguageExt.Common;
namespace CaseCafeteria.Model
{
    public class Cafeteria
    {
        public Dictionary<string, decimal> cardapio { get; set; } = new Dictionary<string, decimal>();      
        public Queue <Pedido> pedidosAguardandoAtendimento { get; set; } = new Queue<Pedido>();
        public Stack<string> pedidosCancelados { get; set; } = new Stack<string>();

        // ---------------- Cardápio (Dictionary) ----------------
        public void AdicionarProduto(string nome, decimal preco)
        {
            cardapio.Add(nome, preco);
        }

        public void RemoverProduto(string nome)
        {
            cardapio.Remove(nome);
        }

        public bool ConsultarPreco(string nome, out decimal preco)
        {
            return cardapio.TryGetValue(nome, out preco);
        }

        // ---------------- Fila de pedidos (Queue) ----------------
        public void NovoPedido(string nomeCliente, List<string> itens)
        {
            Pedido pedido = new Pedido(nomeCliente, itens);
            pedidosAguardandoAtendimento.Enqueue(pedido);
            Console.WriteLine("Pedido adicionado na fila");
        }

        public void AtenderProximoPedido(string nomeCliente, List<string> itens)
        {
            if (pedidosAguardandoAtendimento.Count == 0)
            {
                Console.WriteLine("A fila de pedidos se encontra vazia");
                return;
            }

            Pedido pedido = pedidosAguardandoAtendimento.Dequeue(); 
            decimal total = 0;
            foreach (string item in pedido.Itens)
            {
                if (ConsultarPreco(item, out decimal preco))
                {
                    total += preco;
                }
                else
                {
                    Console.WriteLine($"⚠ Produto '{item}' não encontrado no cardápio.");
                }
            }
            Console.WriteLine($"Pedido {pedido.Numero} atendido. Total: R$ {total:F2}");
        }

        // ---------------- Cancelados (Stack) ----------------
        public void CancelarPedido(int numeroPedido)
        {
                        
        }

        public void ReativarUltimoCancelado()
        {
            
            throw new NotImplementedException();
        }

        // ---------------- Relatórios ----------------
        public void MostrarFilaDeEspera()
        {
            throw new NotImplementedException();
        }

        public void MostrarCancelados()
        {
            throw new NotImplementedException();
        }
    }
}