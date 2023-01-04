public class Graph
{
    private readonly int MAX_VERTS = 10;
    private Vertex[] vertexList;
    private int[,] adjMatrix;
    private int vertexCount;

    public Vertex[] VertexList { get => vertexList; set => vertexList = value; }
    public int[,] AdjMatrix { get => adjMatrix; set => adjMatrix = value; }
    public int VertexCount { get => vertexCount; set => vertexCount = value; }

    public Graph()
    {
        vertexList = new Vertex[MAX_VERTS];
        adjMatrix = new int[MAX_VERTS, MAX_VERTS];
        vertexCount = 0;

        for (int i = 0; i < MAX_VERTS; i++)
        {
            for (int j = 0; j < MAX_VERTS; j++)
            {
                adjMatrix[i, j] = 0;
            }
        }
    }

    public void AddVertex(char label)
    {
        vertexList[vertexCount++] = new Vertex(label);
    }

    public void AddEdge(int start, int end, int weight)
    {
        adjMatrix[start, end] = weight;
    }

    public void PrintVertex(int index)
    {
        Console.WriteLine(vertexList[index].Label);
    }
}