namespace Models
{
    public class Graph
    {
        private int verticesCount;
        private LinkedList<int>[] adjacencyList;

        public Graph(int verticesCount)
        {
            this.verticesCount = verticesCount;

            this.adjacencyList = new LinkedList<int>[this.verticesCount];
            for (int i = 0; i < this.adjacencyList.Length; i++)
            {
                this.adjacencyList[i] = new LinkedList<int>();
            }
        }

        public LinkedList<int>[] AdjacencyList { get { return this.adjacencyList; } }

        public int VerticesCount { get { return this.verticesCount; } }

        public void AddEdge(int v, int w)
        {
            this.adjacencyList[v].AddLast(w);
        }

        public LinkedList<int> GetAdjacentVertices(int fromVertex) => this.adjacencyList[fromVertex];
    }
}
