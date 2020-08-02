namespace LinkedList.src.Infrastructure
{
    /// <summary>
    /// This class represents a node.
    /// </summary>
    public sealed class Node
    {
        public Node Next { get; set; }
        public object Value { get; }

        public Node(object value)
        {
            Value = value;
        }
    }
}