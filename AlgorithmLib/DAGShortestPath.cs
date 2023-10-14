using System.Runtime.CompilerServices;
namespace AlgorithmLib;

public static class DAGShortestPath
{

    public static (List<int> distance, List<int> pred) ShortestPath(Graph g, int startVertex)
    {
        // Get the topological sorting order of the vertices in the graph.
        List<int> sort = DAGTopologicalSort.Sort(g);

        // Create lists to store distances and predecessors for each vertex.
        List<int> distance = new List<int>(new int[g.Size()]);
        List<int> pred = new List<int>(new int[g.Size()]);

        // Define a constant for representing infinity.
        int INF = int.MaxValue;

        // Initialize distance and predecessor lists for all vertices.
        for (int i = 0; i < g.Size(); i++)
        {
            distance[i] = INF;
            pred[i] = INF;
        }

        // The distance to the starting vertex is set to 0.
        distance[startVertex] = 0;

        // Iterate through vertices in the topological order.
        foreach (int vertex in sort)
        {
            // Check if a valid distance is set for the current vertex.
            if (distance[vertex] != INF)
            {
                // Iterate through the outgoing edges of the current vertex.
                foreach (Edge edge in g.Edges(vertex))
                {
                    // Update the distance and predecessor if a shorter path is found.
                    if (distance[vertex] + edge.Weight < distance[edge.DestId])
                    {
                        distance[edge.DestId] = distance[vertex] + edge.Weight;
                        pred[edge.DestId] = vertex;
                    }
                }
            }
        }
        // Return the distances and predecessors as a tuple.
        return (distance, pred);
    }
}