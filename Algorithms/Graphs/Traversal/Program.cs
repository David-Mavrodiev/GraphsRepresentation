using Models;

namespace Traversal
{
    public class Program
    {
        public static void Main()
        {
            Graph graph = new Graph(5);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 4);

            BfsTraversal bfs = new BfsTraversal(graph);
            List<int> bfsTraversalOrder = bfs.Traverse(0);
            Console.WriteLine($"The graph was traversed using BFS and the result order is: {String.Join(',', bfsTraversalOrder)}");

            DfsTraversal dfs = new DfsTraversal(graph);
            List<int> dfsTraversalOrder = dfs.Traverse(0);
            Console.WriteLine($"The graph was traversed using DFS and the result order is: {String.Join(',', dfsTraversalOrder)}");
        }
    }
}
