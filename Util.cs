using System.Reflection;

namespace RZA
{
    /*
     * The util class will store static methods which can be useful in a variation of classes
     * to make them easily accessable everywhere
     */
    internal class Util
    {
        public delegate void EmptyDelegate(); // 0 parameter delegate

        // returns a string of the name of a property that would be null in T
        // will return null if all fields have a value
        // this is to validate the data integrity of T to ensure that all properties have a value
        public static string? Integrity<T>(T obj)
        {
            // gets all the fields from T
            FieldInfo[] properties = typeof(T).GetFields();

            foreach (FieldInfo property in properties) // iterates over each property
            {
                object? value = property.GetValue(obj);

                // if the value of that property is null the loop will break and return the name
                if (value is null or (object)"")
                {
                    return property.Name.ToLower();
                }
            }

            return null; // return null if all properties in the model have a value
        }

        // returns the content passed as a parameter with the first character capitalised
        public static string Capitalise(string content)
        {
            return content.Substring(0, 1).ToUpper() + content.Substring(1).ToLower();
        }

        // returns the root directory file path of the project
        public static string GetRootDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory());
        }

        // shortcut to compare the type of the passed parameter to the passed generic type
        public static bool IsType<T>(object other)
        {
            return other.GetType() == typeof(T);
        }

        // returns true if the first date is after or the same as the second date
        public static bool OverlappingDates(DateTime dt1, DateTime dt2)
        {
            return DateTime.Compare(dt1, dt2) >= 0;
        }
    }
}
