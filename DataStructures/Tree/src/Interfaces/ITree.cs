namespace Tree.src.Interfaces
{
    public interface ITree
    {
        // Get the count of the tree
        //
        int Count { get; }

        // Adds an object to the tree
        //
         void Add(object value);
    }
}