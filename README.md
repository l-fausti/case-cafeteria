📋 Sobre o case

O sistema simula o atendimento de uma cafeteria: cadastro de cardápio, fila de pedidos e controle de cancelamentos.

✅ Requisitos

1. Cardápio — Dictionary<string, decimal>
Nome do produto como chave, preço como valor.
Métodos: adicionar produto, remover produto, consultar preço.

2. Fila de pedidos — Queue<Pedido>
Clientes fazem pedidos e entram na fila por ordem de chegada.
Um Pedido tem: número, nome do cliente e lista de itens (nomes dos produtos).
Métodos: novo pedido entra na fila; atender o próximo pedido (sai da fila e calcula o total buscando os preços no cardápio).

3. Cancelados — Stack<Pedido>
Pedido cancelado antes de ser atendido sai da fila e vai para uma pilha de "cancelados recentemente".
Métodos: cancelar um pedido específico (por número); reativar o último cancelado, voltando para o fim da fila.

⚠️ Regras de negócio

Não é possível atender pedido se a fila estiver vazia.

Não é possível calcular o total de um pedido com produto que não existe no cardápio (tratar erro).

Pedido reativado entra no fim da fila — não recupera a posição original.

🗂️ Estrutura do projeto

CaseCafeteria/
├── CaseCafeteria.csproj
├── Program.cs           # roteiro de testes (Main)
├── Cafeteria.cs          # classe orquestradora (Dictionary + Queue + Stack)
└── Models/
    ├── Produto.cs
    └── Pedido.cs


🧪 Cenários de testes sugerido

1. Criar uma Cafeteria
2. Cadastrar uns 4 produtos no cardápio
3. Criar 3 pedidos com clientes e itens diferentes
4. Mostrar a fila de espera
5. Atender 1 pedido
6. Cancelar outro pedido (pelo número)
7. Mostrar fila de espera + mostrar cancelados
8. Reativar o último cancelado
9. Mostrar fila de espera novamente (o reativado deve estar no fim)
