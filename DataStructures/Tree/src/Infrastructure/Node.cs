namespace Tree.src.Infrastructure
{
    public class Node
    {
        public Node Right { get; set; }
        public Node Left { get; set; }
        public object Value { get; }

        public Node (object value)
        {
            Value = value;
        }
    }
}