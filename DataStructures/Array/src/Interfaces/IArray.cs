namespace Array.src.Interfaces
{
    public interface IArray
    {
        // Returns the number of items in the array.
        //
        int Count { get; } 

        // Adds an item to the array.
        //
        void Add(object value);

        // Adds an item to the array at a specific position.
        //
        void AddAtPosition(object value, int index);

        // Removes the first occurance of an item from the array.
        //
        void Remove(object value);

        // Removes an item at a specific position.
        //
        void RemoveAtPosition(int index);
    }
}