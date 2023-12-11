# CSE 381 - Final Exam 

(c) BYU-Idaho - It is an honor code violation ot post this file completed or uncompleted in a public sharing site.

Instructions:  Record your answers to the final exam below.  Remember to put your name and date below.

Name: Lauren Dulgarian 

Date: 11/29/23

## Part 1

1. What is an Algorithm?
        
        An algorithm is a set of instructions that a computer can follow to complete a particular task, much like a recipe. Certain patterns emerge when these instructions are converted into code. Programming languages differ in their syntax, or the way instructions are expressed. Both the language and the structure of a program affect its speed; certain languages support short, understandable code, while others require longer instructions. Error control procedures and the kinds of data structures that are employed also differ. The programming language determines how code is organized, and built-in tools can make this process easier. Because different programming languages have different techniques, it might be difficult to achieve consistency because of these unique features. Even yet, when dealing with different programming languages, it is important to realize that the language selection has a big influence on how a program looks and works.

2. How to determine the run time performance of an algorithm? 

        When assessing an algorithm's runtime performance, different approaches provide insight into how well these algorithms manage different amounts of data. An important technique for estimating how an algorithm's speed changes with increased data is Big O notation. The second approach is theoretical analysis, in which we investigate the program and construct pseudocode. Experimental analysis is an extra method that helps to understand the program's performance by testing it with various forms of input. By using tools to pinpoint the parts of the program that take a long time, we can better understand how the program behaves. To put it simply, taking into account these complex variables offers a comprehensive understanding of how a program functions in various contexts.


3. Compare and contrast the performance of the Directed Acyclic Graph (DAG) shortest path, the Dijkstra shortest path, and the Bellman-Ford shortest path. In your discussion consider what happens to performance for very sparse or very dense graphs.

       The Bellman-Ford Shortest Path Algorithm, Dijkstra's Shortest Path Algorithm, and the Directed Acyclic Graph (DAG) Shortest Path. DAG Shortest Path uses efficient programming and ordering specifically for directed acyclic graphs. Dijkstra's Algorithm, which uses a priority queue within a greedy strategy, works effectively in graphs whose weights are non-negative. Conversely, Bellman-Ford is optimized for graphs with negative weights; it uses edge relaxation that is iterative, can handle cycles—including negative ones—and performs best when the weights of the graph are negative. In contrast, Dijkstra is not suitable for handling negative weights; on the other hand, Bellman-Ford is, and DAG Shortest Path assumes non-negative weights. These algorithms are further distinguished by graph-specific factors: DAG can only be used to acyclic networks, Dijkstra works well with non-negative weighted graphs, and Bellman-Ford can handle negative weights and cycles. Bellman-Ford might perform better in graphs with negative weights, Dijkstra performs best in sparse graphs, and DAG Shortest Path is effective in acyclic graphs. The choice of these methods is influenced by the graph's properties, including its density, cycles, and negative weights.

## Part 2

Algorithm Selected: QuickSort

Public or Unlisted (not private) YouTube URL for your video:

