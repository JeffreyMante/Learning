namespace LinkedList.src.Interfaces
{
    /// <summary>
    /// This represents the interface for a linked list of objects.
    /// </summary>
    public interface ILinkedList
    {
        // Returns a value indicating the amount of objects in the list.
        //
         int Count { get; }

        // Adds an object to the list.
        //
         void Add(object value);

        // Removes an object from the list.
        //
         void Remove(object value);
    }
}