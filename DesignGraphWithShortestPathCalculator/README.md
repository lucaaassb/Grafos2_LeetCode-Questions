# Design Graph With Shortest Path Calculator 🗺️

## Nome
Design Graph With Shortest Path Calculator

## Descrição
Um algoritmo dinâmico de grafos que permite adicionar arestas e encontrar o caminho mais curto entre nós com cálculo eficiente de rotas.

## Funcionalidades
- Criar grafos com múltiplos nós
- Adicionar arestas dinamicamente com diferentes custos
- Calcular o caminho de menor custo entre dois pontos
- Tratar cenários onde não existe caminho possível

## Detalhes Técnicos
- Implementa o algoritmo de Dijkstra para cálculo de caminho mais curto
- Otimizado com SortedSet para performance
- Suporta grafos direcionados e ponderados
- Utiliza estruturas de dados eficientes para processamento rápido de rotas

## Principais Métodos

### `Graph(int n, int[][] edges)`
- **Objetivo:** Inicializar o grafo com `n` nós e arestas iniciais
- **Parâmetros:**
    - `n`: Número total de nós
    - `edges`: Matriz de arestas iniciais

### `AddEdge(int[] edge)`
- **Objetivo:** Adicionar uma nova aresta ao grafo
- **Parâmetros:**
    - `edge`: Array representando a aresta [origem, destino, custo]

### `ShortestPath(int node1, int node2)`
- **Objetivo:** Encontrar o caminho de menor custo entre dois nós
- **Parâmetros:**
    - `node1`: Nó de origem
    - `node2`: Nó de destino
- **Retorno:**
    - Custo do caminho mais curto
    - `-1` se nenhum caminho existir