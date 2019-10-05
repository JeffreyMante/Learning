namespace Stack.src.Interfaces
{
    /// <summary>
    /// This represents the interface for a stack of objects.
    /// </summary>
    public interface IStack
    {
        // Returns a value indicating the amount of objects in the stack.
        //
        int Count { get; }

        // Returns the object at the top of the stack but does not remove it.
        //
        object Peek();

        // Returns the object at the top of the stack and removes it.
        //
        object Pop();

        // Adds an object to the top of the stack.
        //
        void Push(object obj);
    }
}