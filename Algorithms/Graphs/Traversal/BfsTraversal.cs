namespace Models
{
    public class BfsTraversal
    {
        private Graph graph;

        public BfsTraversal(Graph graph)
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

            Queue<int> queue = new Queue<int>();

            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Any())
            {
                start = queue.Dequeue();
                visitedOrder.Add(start);

                LinkedList<int> vertices = this.graph.GetAdjacentVertices(start);

                foreach (var vertex in vertices)
                {
                    if (!visited[vertex])
                    {
                        visited[vertex] = true;
                        queue.Enqueue(vertex);
                    }
                }
            }

            return visitedOrder;
        }
    }
}
