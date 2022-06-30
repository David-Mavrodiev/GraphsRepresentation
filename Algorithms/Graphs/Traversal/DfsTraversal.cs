using Models;

namespace Traversal
{
    public class DfsTraversal
    {
        private Graph graph;

        public DfsTraversal(Graph graph)
        {
            this.graph = graph;
        }

        public List<int> Traverse(int start)
        {
            List<int> visitedOrder = new List<int>();
            bool[] visited = new bool[this.graph.VerticesCount];
            for (int i = 0; i < this.graph.VerticesCount; i++)
            {
                visited[i] = false;
            }

            Stack<int> stack = new Stack<int>();

            visited[start] = true;
            stack.Push(start);

            while (stack.Any())
            {
                start = stack.Pop();
                visitedOrder.Add(start);

                LinkedList<int> vertices = this.graph.GetAdjacentVertices(start);

                foreach (var vertex in vertices)
                {
                    if (!visited[vertex])
                    {
                        visited[vertex] = true;
                        stack.Push(vertex);
                    }
                }
            }

            return visitedOrder;
        }
     }
}
