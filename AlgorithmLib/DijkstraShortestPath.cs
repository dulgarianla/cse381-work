namespace AlgorithmLib;

public static class DijkstraShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // Define a constant for infinity, typically the maximum possible integer value.
        int INF = int.MaxValue;

        // Create a list 'distance' of size 'g.Size()' and initialize all elements with 'INF'.
        List<int> distance = Enumerable.Repeat(INF, g.Size()).ToList();
        // Create a list 'pred' of size 'g.Size()' and initialize all elements with 'INF'.
        List<int> pred = Enumerable.Repeat(INF, g.Size()).ToList();

        // Set the initial distance for the 'startVertex' to 0 (it's the starting point).
        distance[startVertex] = 0;

        // Create a list 'queue' containing numbers from 0 to 'g.Size()' (inclusive).
        List<int> queue = Enumerable.Range(0, g.Size()).ToList();

        // Enter a loop that continues while there are vertices in the 'queue'.
        while (queue.Count > 0)
        {
            // Initialize 'smallestIndex' to 0 as the index of the smallest distance vertex.
            int smallestIndex = 0;

            // Loop through 'queue' to find the vertex with the smallest distance.
            for (int index = 0; index < queue.Count; index++)
            {
                // Compare distances to find the vertex with the smallest distance.
                if (distance[queue[index]] < distance[queue[smallestIndex]])
                {
                    smallestIndex = index;
                }
            }

            // 'smallestId' represents the vertex with the smallest distance.
            int smallestId = queue[smallestIndex];

            // Remove the 'smallestId' vertex from the 'queue'.
            queue.RemoveAt(smallestIndex);

            // Iterate over the edges of the 'smallestId' vertex in the graph.
            foreach (Edge edge in g.Edges(smallestId))
            {
                // Calculate the potential new distance to 'edge.DestId' through 'smallestId'.
                int potentialDistance = distance[smallestId] + edge.Weight;

                // If the potential distance is smaller than the current distance to 'edge.DestId', update it.
                if (potentialDistance < distance[edge.DestId])
                {
                    distance[edge.DestId] = potentialDistance;
                    pred[edge.DestId] = smallestId;
                }
            }
        }
        // Return the calculated distances and predecessors as a null.
        return (distance, pred);
    }
}

