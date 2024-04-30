namespace RZA.memory
{
    /*
     * Enum declaring different types of memory stored
     * additional values can be added to this enum to allow the memory to store more types of data
     */
    internal enum Memories
    {
        User
    }

    /*
     * The memory class is used to store cached data in a dictionary to allow it to be accessed
     * and modified at anypoint using the static methods
     */
    internal class Memory
    {
        // event emitted every time a element in the memory is changed
        // updated to update ui live
        public static event Util.EmptyDelegate OnMemoryChanged;

        // the stored in this memory class is kept in this dictionary
        private static Dictionary<int, object> memory = new Dictionary<int, object>();

        // assigns the object value to the dictionary with the memories key. emits the memory changed event
        public static void Set(Memories key, object value)
        {
            memory[(int) key] = value;

            OnMemoryChanged.Invoke();
        }

        // removes one element of the memory by the memories key. emits the memory changed event
        public static void Remove(Memories key)
        {
            memory.Remove((int)key);

            OnMemoryChanged.Invoke();
        }

        // returns the object value from the memory with the given memories key parameter
        public static object? Get(Memories key)
        {
            if (!Contains(key)) // return null if memory does not contain this key
            {
                return null;
            }

            return memory[(int) key];
        }

        // clears everything stored in the memory. emits the memory changed event
        public static void Clear()
        {
            memory.Clear();

            OnMemoryChanged.Invoke();
        }

        // checks if the memory is containing a memories key. emits the memory changed event
        public static bool Contains(Memories key)
        {
            return memory.ContainsKey((int) key);
        }
    }
}
