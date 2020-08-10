namespace LinkedList.src.Infrastructure
{
    /// <summary>
    /// This class represents a doubly linked node.
    /// </summary>
    public sealed class DoubleNode
    {
        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }
        public object Value { get; }

        public DoubleNode(object value)
        {
            Value = value;
        }
    }
}