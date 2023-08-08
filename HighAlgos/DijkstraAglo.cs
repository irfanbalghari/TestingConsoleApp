using System;

namespace TestingConsoleApp.HighAlgos
{
    public class DijkstraAlgorithm
    {
        private int[,] graph; // Adjacency matrix representation of the graph
        private int numVertices; // Number of vertices in the graph

        public DijkstraAlgorithm(int[,] adjacencyMatrix)
        {
            graph = adjacencyMatrix;
            numVertices = graph.GetLength(0);
        }

        public void FindShortestPath(int startVertex)
        {
            int[] distances = new int[numVertices]; // Array to store the shortest distances
            bool[] visited = new bool[numVertices]; // Array to keep track of visited vertices

            // Initialize distances with a large value and visited array as false
            for (int i = 0; i < numVertices; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            distances[startVertex] = 0; // Set the distance of the starting vertex to 0

            for (int count = 0; count < numVertices - 1; count++)
            {
                int u = MinDistance(distances, visited); // Find the vertex with the smallest distance

                visited[u] = true; // Mark the selected vertex as visited

                // Update distances of the neighboring vertices
                for (int v = 0; v < numVertices; v++)
                {
                    if (!visited[v] && graph[u, v] != 0 && distances[u] != int.MaxValue &&
                        distances[u] + graph[u, v] < distances[v])
                    {
                        distances[v] = distances[u] + graph[u, v];
                    }
                }
            }

            PrintShortestPaths(distances, startVertex); // Print the shortest paths
        }

        private int MinDistance(int[] distances, bool[] visited)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < numVertices; v++)
            {
                if (!visited[v] && distances[v] <= min)
                {
                    min = distances[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private void PrintShortestPaths(int[] distances, int startVertex)
        {
            Console.WriteLine("Vertex\tDistance from Start Vertex");

            for (int i = 0; i < numVertices; i++)
            {
                Console.WriteLine($"{i}\t{distances[i]}");
            }
        }
    }


}
