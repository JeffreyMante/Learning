namespace Queue.src.Interfaces
{
    public interface IQueue
    {
        // Gets the number of items in the queue.
        //
        int Count { get; }

        // Adds an item to the end of the queue.
        //
        void Enqueue(object value);

        // Returns and removes an item from the start queue.
        //
        object Dequeue();

        // Returns the item at the start of the queue.
        //
        object Peek();
    }
}