using System;
using System.Collections.Generic;

public class Graph
{
    private readonly int _numeroDeNos;
    private readonly Dictionary<int, List<(int, int)>> _grafo;

    public Graph(int n, int[][] edges)
    {
        _numeroDeNos = n;
        _grafo = new Dictionary<int, List<(int, int)>>();
        for (int i = 0; i < n; i++)
        {
            _grafo[i] = new List<(int, int)>();
        }

        foreach (var edge in edges)
        {
            AddEdge(edge);
        }
    }

    public void AddEdge(int[] edge)
    {
        int from = edge[0];
        int to = edge[1];
        int cost = edge[2];
        _grafo[from].Add((to, cost));
    }

    public int ShortestPath(int node1, int node2)
    {
        var distances = new int[_numeroDeNos];
        Array.Fill(distances, int.MaxValue);
        distances[node1] = 0;

        var priorityQueue = new SortedSet<(int, int)>(Comparer<(int, int)>.Create((x, y) =>
        {
            int comparison = x.Item1.CompareTo(y.Item1);
            return comparison != 0 ? comparison : x.Item2.CompareTo(y.Item2);
        }));

        priorityQueue.Add((0, node1));

        while (priorityQueue.Count > 0)
        {
            var (currentDistance, currentNode) = priorityQueue.Min;
            priorityQueue.Remove(priorityQueue.Min);

            if (currentDistance > distances[currentNode]) continue;

            foreach (var (neighbor, cost) in _grafo[currentNode])
            {
                int newDistance = currentDistance + cost;
                if (newDistance < distances[neighbor])
                {
                    priorityQueue.Remove((distances[neighbor], neighbor));
                    distances[neighbor] = newDistance;
                    priorityQueue.Add((newDistance, neighbor));
                }
            }
        }

        return distances[node2] == int.MaxValue ? -1 : distances[node2];
    }
}