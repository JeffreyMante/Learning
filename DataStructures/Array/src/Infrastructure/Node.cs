namespace Array.src.Infrastructure
{
    public class Node
    {
        public Node Next { get; set; }
        public object Value { get; }

        public Node(object value)
        {
            Value = value;
        }
    }
}