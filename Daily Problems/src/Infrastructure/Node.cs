namespace DailyCodingProblems.src.Infrastructure
{
    public sealed class Node
    {
        public object Data { get; }
        public Node Left { get; }
        public Node Right { get; }

        public Node(object data, Node left = null, Node right = null)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;
        }
    }
}