using System.Collections;

namespace AlgorithmLib;

public static class DAGTopologicalSort
{

    public static List<int> Sort(Graph g)
    {
        // Create an array to store the in-degrees of each vertex in the graph.
        int[] in_Degree = new int[g.Size()];

        // Create a list to store the linear order (topological order) of vertices.
        List<int> linear_Order = new List<int>();

        // Calculate the in-degrees of each vertex by iterating through the graph.
        for (int vertex = 0; vertex < g.Size(); vertex++)
        {
            // Iterate through the outgoing edges of the current vertex.
            foreach (Edge edge in g.Edges(vertex))
            {
                // Increment the in-degree of the destination vertex.
                in_Degree[edge.DestId]++;
            }
        }

        // Create a queue to store vertices with in-degrees equal to zero.
        Queue<int> next = new Queue<int>();

        // Initialize the queue with vertices that have in-degrees equal to zero.
        for (int vertex = 0; vertex < g.Size(); vertex++)
        {
            if (in_Degree[vertex] == 0)
            {
                next.Enqueue(vertex);
            }
        }

        // Process vertices in topological order.
        while (next.Count > 0)
        {
            // Dequeue a vertex with in-degree zero.
            int vertex = next.Dequeue();

            // Add the vertex to the linear order.
            linear_Order.Add(vertex);

            // Update the in-degrees of neighboring vertices.
            foreach (Edge edge in g.Edges(vertex))
            {
                // Decrement the in-degree of the destination vertex.
                in_Degree[edge.DestId]--;

                // If the in-degree becomes zero, enqueue the vertex for processing.
                if (in_Degree[edge.DestId] == 0)
                {
                    next.Enqueue(edge.DestId);
                }
            }
        }

        // Return the linear order (topological order) of the vertices.
        return linear_Order;
    }
}