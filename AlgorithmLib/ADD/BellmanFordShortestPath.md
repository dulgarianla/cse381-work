# Algorithm Description Document

Author: Lauren Dulgarian 

Date: 10/28/23

## 1. Name
Bellman Ford Shortest Path

## 2. Abstract
In this code it defines a method, ShortestPath, which calculates the shortest path in a graph using the Bellman-Ford algorithm. This algorithm is employed to find the shortest distance from a specified starting vertex to all other vertices in the graph. The code initializes distance and predecessor lists for each vertex, sets the distance of the starting vertex to zero, and iterates through the graph edges while updating distances and predecessors until the shortest paths are determined or a negative cycle is detected.

## 3. Methodology

In this code it implements the Bellman-Ford algorithm to find the shortest path in a weighted graph. It initializes distance and predecessor lists for each vertex and uses a constant (INF) to represent infinity. The algorithm starts from a specified source vertex and iterates through the graph's edges, updating distances and predecessors as it finds shorter paths. If a negative cycle is detected, it returns empty lists. The code also checks for convergence and exits early when no changes are made. In the end, it returns the shortest distances and predecessors for all vertices. Bellman-Ford is a versatile algorithm for various applications, particularly when dealing with graphs that have negative edge weights and need to detect negative cycles

## 4. Pseudocode

```
SHORTEST-PATH(graph, start_vertex)
    distance = [INF, graph.size()] 
    pred = [INF, graph.size()] 
    distance[start_vertex] = 0
    
    for i in range(graph.size()):
        bool changesMade = false
        
        for vertex in range(graph.size()):
            for edge in g.Edges(vertex):
                if distance[vertex] + edge.Weight < distance[edge.DestId]:
                    if (i == g.Size() - 1):
                        return ([], [])
                    changesMade = true
                    distance[edge.DestId] = distance[vertex] + edge.Weight
                    pred[edge.DestId] = vertex

        if not changesMade:
            break
            
    return (distance, pred)
```

## 5. Inputs & Outputs

**Inputs:** `Graph g` - The input graph where you want to find the shortest paths.

`int startVertex` - The starting point for finding the shortest paths.

**Outputs:** `distance` - Shortest distances from the startVertex to other vertices.

`pred` - Predecessor vertices on the shortest paths.


## 6. Analysis Results

* Worst Case: $O(VE)$

* Best Case: $O(V+E)$
