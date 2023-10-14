# Algorithm Description Document

Author: Lauren Dulgarian

Date: 10/12/23

## 1. Name
Directed Acyclic Graph (DAG) Shortest Path

## 2. Abstract
In this code it an implementation of a shortest path algorithm for a Directed Acyclic Graph (DAG). It finds the shortest distances from a specified starting vertex to all other vertices in the graph. The algorithm uses topological sorting to process vertices in a specific order, repeats through the vertices, and updates the shortest distances and predecessors based on the outgoing edges.

## 3. Methodology
In this code the purpose is to compute the shortest path from a chosen starting vertex to all other vertices in a Directed Acyclic Graph (DAG). The method `ShortestPath` takes the graph (`g`) and the starting point as inputs, providing two lists as output. The first list, distance, holds the shortest distances from the starting vertex to all others, while the second list, `pred`, stores the predecessors along the shortest path. Topological sorting is used to ensure a systematic traversal, arranging vertices to prevent processing before their predecessors. The code starts the lists with placeholders and introduces an `INF` constant which represents infinity. Initial distances are set for all vertices, beginning with infinity for most but zero for the starting vertex. It then traverses vertices, checking for valid distances in a nested loop. Within the inner loop, the code explores outgoing edges, comparing distances to identify shorter paths. If a shorter path is found, the distance to the destination vertex is updated, and the predecessor is recorded. The code eventually returns a null containing `distance` and `pred`, offering a compete view of the shortest path details for each vertex in the graph.

## 4. Pseudocode

```
SHORTEST-PATH(graph, start_vertex)
    sort = DAGTopologicalSort.sort(g)
    distance = list of size g.size(INF) 
    pred = list of size g.size(INF) 
    INF = infinity 

    loop i in range(g.size()):
        distance[i] = INF
        pred[i] = INF

    distance[start_vertex] = 0

    loop vertex in sort:
        if distance[vertex] != INF:

        loop each edge in g.edges(vertex):
            if distance[vertex] + edge.weight < distance[edge.dest_id]:
            distance[edge.dest_id] = distance[vertex] + edge.weight
            pred[edge.dest_id] = vertex

        return distance, pred

```

## 5. Inputs & Outputs

**Inputs:** `Graph g` - This is an object representing a Directed Acyclic Graph (DAG) on which the shortest path needs to be calculated.

`int startVertex` - This parameter specifies the starting vertex within the graph from which the shortest paths to other vertices will be determined.

**Outputs:** `distance` - This list represents the shortest distances from the starting vertex to all other vertices in the graph. Each element in this list corresponds to a vertex in the graph, and it contains the shortest distance from the starting vertex to that specific vertex.

`pred` - This list represents the predecessors for each vertex in the shortest path. It contains information about which vertex comes immediately before that specific vertex in the shortest path from the starting vertex.

## 6. Analysis Results

* Worst Case: $O(V+E)$

* Best Case: $\Omega(E+V)$

