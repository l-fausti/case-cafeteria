using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseCafeteria.Model
{
    public class Cafeteria
    {
        Dictionary<string, decimal> cardapio = new Dictionary<string, decimal>();        
        Queue <string> pedidosAguardandoAtendimento = new Queue<string>();
        Stack<string> pedidosCancelados = new Stack<string>();

        // ---------------- Cardápio (Dictionary) ----------------

        public void AdicionarProduto(string nome, decimal preco)
        {
            throw new NotImplementedException();
        }

        public void RemoverProduto(string nome)
        {
            throw new NotImplementedException();
        }

        public decimal ConsultarPreco(string nome)
        {
            
            throw new NotImplementedException();
        }

        // ---------------- Fila de pedidos (Queue) ----------------

        public void NovoPedido(string nomeCliente, List<string> itens)
        {
            throw new NotImplementedException();
        }

        public void AtenderProximoPedido()
        {
            
            throw new NotImplementedException();
        }

        // ---------------- Cancelados (Stack) ----------------

        public void CancelarPedido(int numeroPedido)
        {
            
            throw new NotImplementedException();
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