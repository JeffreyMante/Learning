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

        // Adds an object at the start of the list.
         void AddAtStart(object value);

        // Adds an object at the end of the list.
        //
         void AddAtEnd(object value);

        // Adds an object at a specific position in the list.
        //
         void AddAtPosition(int index, object value);

        // Removes the starting object from the list.
         void RemoveAtStart();

         // Removes the ending object from the list.
         void RemoveAtEnd();

        // Removes an object from the list.
        //
         void Remove(object value);

        // Removes an object at the position from the list.
        //
         void RemoveAtPosition(int index);
    }
}