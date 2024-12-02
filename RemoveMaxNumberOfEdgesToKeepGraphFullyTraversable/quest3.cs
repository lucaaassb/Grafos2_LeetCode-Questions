using System;
using System.Collections.Generic;

public class Solution
{
    public int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        int[] parentAlice = new int[n + 1];
        int[] parentBob = new int[n + 1];
        
        // Inicializa os conjuntos
        for (int i = 0; i <= n; i++)
        {
            parentAlice[i] = i;
            parentBob[i] = i;
        }

        int totalEdgesUsed = 0;

        // Função para encontrar o representante de um nó
        int Find(int[] parent, int x)
        {
            if (parent[x] != x)
                parent[x] = Find(parent, parent[x]);
            return parent[x];
        }

        // Função para unir dois conjuntos
        bool Union(int[] parent, int x, int y)
        {
            int rootX = Find(parent, x);
            int rootY = Find(parent, y);
            if (rootX == rootY)
                return false;
            parent[rootX] = rootY;
            return true;
        }

        // Adiciona primeiro as arestas do tipo 3
        foreach (var edge in edges)
        {
            if (edge[0] == 3)
            {
                bool aliceUsed = Union(parentAlice, edge[1], edge[2]);
                bool bobUsed = Union(parentBob, edge[1], edge[2]);
                if (aliceUsed || bobUsed)
                    totalEdgesUsed++;
            }
        }

        // Adiciona as arestas do tipo 1 (Alice)
        foreach (var edge in edges)
        {
            if (edge[0] == 1 && Union(parentAlice, edge[1], edge[2]))
                totalEdgesUsed++;
        }

        // Adiciona as arestas do tipo 2 (Bob)
        foreach (var edge in edges)
        {
            if (edge[0] == 2 && Union(parentBob, edge[1], edge[2]))
                totalEdgesUsed++;
        }

        // Verifica se Alice e Bob podem alcançar todos os nós
        int rootAlice = Find(parentAlice, 1);
        int rootBob = Find(parentBob, 1);
        for (int i = 2; i <= n; i++)
        {
            if (Find(parentAlice, i) != rootAlice || Find(parentBob, i) != rootBob)
                return -1;
        }

        // Retorna o número máximo de arestas que podem ser removidas
        return edges.Length - totalEdgesUsed;
    }
}