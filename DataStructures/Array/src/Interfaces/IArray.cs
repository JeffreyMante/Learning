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

        // Removes the first occurance of an item from the array.
        //
        void Remove(object value);
    }
}