# Remove Max Number of Edges to Keep Graph Fully Traversable 🌐

## Nome
Remove Max Number of Edges to Keep Graph Fully Traversable

## Descrição
Um algoritmo para determinar o número máximo de arestas que podem ser removidas de um grafo, mantendo-o totalmente transitável para Alice e Bob.

## Funcionalidades
- Processar grafo com arestas de três tipos diferentes
- Verificar transitividade para Alice e Bob
- Calcular número máximo de arestas removíveis
- Garantir conectividade do grafo para ambos os usuários

## Detalhes Técnicos
- Implementa algoritmo de União-Encontro (Union-Find)
- Utiliza estruturas de dados para rastreamento de conjuntos
- Processa arestas por tipo de prioridade
- Verifica conectividade do grafo com complexidade O(n)

## Principais Métodos

### `MaxNumEdgesToRemove(int n, int[][] edges)`
- **Objetivo:** Calcular máximo de arestas removíveis
- **Parâmetros:**
    - `n`: Número de nós no grafo
    - `edges`: Matriz de arestas com tipo, origem e destino
- **Retorno:**
    - Número de arestas removíveis
    - `-1` se grafo não for totalmente transitável