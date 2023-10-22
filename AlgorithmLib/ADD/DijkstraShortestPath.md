# Algorithm Description Document

Author: Lauren Dulgarian 

Date: 10/21/23

## 1. Name
Dijkstra Shortest Path

## 2. Abstract
In this code it implements of a shortest path in a graph using Dijkstra's algorithm. The algorithm operates on a directed graph and calculates the shortest distances and predecessor vertices from a specified starting vertex. It employs a list-based representation for distances and predecessors, along with a priority queue for vertex selection. The algorithm iteratively explores the graph, updating distances and predecessors as it identifies the shortest path to each vertex. The result is a pair of lists representing the calculated distances and predecessor vertices.

## 3. Methodology
In the code it uses a Dijkstra's shortest path algorithm for a given graph. It starts by initializing the data structures and variables. A constant `INF` is defined to represent infinity, and two lists, `distance` and `pred`, are created to store the shortest distances and predecessor vertices for each vertex in the graph. The size of these lists matches the number of vertices in the input graph `g`. All distances are initially set to infinity, except for the `startVertex`, which is set to 0 to indicate that the shortest distance to itself is 0. A `queue` is established, containing integers from 0 to the graph's size, representing the vertices to be processed. It in a while loop as long as there are vertices in the `queue` to process. In each iteration, the code selects the vertex with the smallest distance from the `distance` list, removes it from the queue, and identifies it as `smallestId`. The algorithm explores the edges of `smallestId` in the graph. For each edge, it calculates a potential new distance to the destination vertex (`edge.DestId`) through `smallestId`. This potential distance is determined by adding the edge's weight to the current distance to `smallestId`. If the potential distance is smaller than the existing distance stored in the `distance` list for the destination vertex, the code updates both the distance and the predecessor for that vertex. This process repeats until all vertices have been processed, ensuring that the shortest distances and predecessors for each vertex are accurately computed. Finally, the method returns a tuple containing the calculated distances and predecessors, providing a comprehensive representation of the shortest paths within the graph. 

## 4. Pseudocode

```
SHORTEST-PATH(graph, start_vertex)
INF = infinity
    distance = [INF] * length(graph)
    pred = [INF] * length(graph)
    distance[start_vertex] = 0
    queue = list(range(length(graph)))

    loop queue is not empty
        smallest_index = 0
        for index in range(length(queue))
            if distance[queue[index]] < distance[queue[smallest_index]]
                smallest_index = index
        smallest_id = queue.remove(smallest_index)

        for edge in graph[smallest_id]
            potential_distance = distance[smallest_id] + edge['weight']
            if potential_distance < distance[edge['destId']]
                distance[edge['destId']] = potential_distance
                pred[edge['destId']] = smallest_id

    return (distance, pred)
```

## 5. Inputs & Outputs

**Inputs:** `Graph g` - The input graph where you want to find the shortest paths.

`int startVertex` - The starting point for finding the shortest paths.

**Outputs:** `distance` - Shortest distances from the startVertex to other vertices.

`pred` - Predecessor vertices on the shortest paths.

## 6. Analysis Results

* Worst Case: $O(E + V log V)$

* Best Case: $\Omega(V)$

