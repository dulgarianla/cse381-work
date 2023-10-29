namespace AlgorithmLib;

public static class BellmanFordShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // Define a constant for infinity, typically the maximum possible integer value.
        int INF = int.MaxValue;
        // Create a list to store distances, initialized with infinity for all vertices
        List<int>distance = Enumerable.Repeat(INF, g.Size()).ToList(); 
        // Create a list to store predecessors, initialized with infinity for all vertices
        List<int>pred = Enumerable.Repeat(INF, g.Size()).ToList();
        
        // Set the distance of the starting vertex to 0
        distance[startVertex] = 0;

        // Loop for a maximum of (n - 1) times, where n is the number of vertices
        for (int i = 0; i < g.Size() - 1; i++) 
        {
            // Flag to track if any changes have been made in this iteration
            bool changesMade = false;
            for (int vertex = 0; vertex < g.Size(); vertex++) // Iterate over all vertices
            {
                foreach (var edge in g.Edges(vertex)) // Iterate over the edges of the current vertex
                {
                    if (distance[vertex] + edge.Weight < distance[edge.DestId]) // Check if a shorter path is found
                    {
                        if (i == g.Size() - 1) // Check if this is the last iteration (negative cycle detected)
                        {
                            return (new List<int>(),
                                new List<int>()); // Return empty lists indicating no shortest path (negative cycle)
                        }

                        changesMade = true; // Mark that changes have been made
                        distance[edge.DestId] = distance[vertex] + edge.Weight; // Update the distance
                        pred[edge.DestId] = vertex; // Update the predecessor
                    }
                }
            }

            if (!changesMade) // If no changes were made in this iteration, break the loop
            {
                break;
            }
        }

        return (distance, pred); // Return the distance and predecessor lists
    }
}