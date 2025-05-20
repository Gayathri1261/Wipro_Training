using System;
using System.Collections.Generic;

class DijkstraAlgorithm
{
    static int MinDistance(int[] dist, bool[] visited, int V)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    static void PrintSolution(int[] dist, List<int>[] paths, int src)
    {
        Console.WriteLine("Vertex\tDistance\tPath");
        for (int i = 0; i < dist.Length; i++)
        {
            Console.Write($"{i}\t{dist[i]}\t\t{src}");
            foreach (int node in paths[i])
            {
                Console.Write($" -> {node}");
            }
            Console.WriteLine();
        }
    }

    static void Dijkstra(int[,] graph, int src, int V)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];
        List<int>[] paths = new List<int>[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            paths[i] = new List<int>();
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited, V);
            visited[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && graph[u, v] != 0 &&
                    dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    paths[v] = new List<int>(paths[u]);
                    paths[v].Add(u);
                }
            }
        }

        for (int i = 0; i < V; i++)
        {
            if (i != src)
                paths[i].Add(i);
        }

        PrintSolution(dist, paths, src);
    }

    static void Main()
    {
        int V = 5;
        int[,] graph = new int[,]
        {
            {  0, 10, 0, 30, 100 },
            { 10, 0, 50, 0, 0 },
            { 0, 50, 0, 20, 10 },
            { 30, 0, 20, 0, 60 },
            { 100, 0, 10, 60, 0 }
        };

        int source = 0;
        Console.WriteLine($"Dijkstra’s Algorithm from node {source}:\n");
        Dijkstra(graph, source, V);
    }
}
