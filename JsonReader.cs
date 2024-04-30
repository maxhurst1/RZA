using Json.Net;

namespace RZA
{
    /*
     * Responsible for reading and deserializing json files
     */
    internal class JsonReader
    {
        // takes the absolute filepath to the json file to read
        // returns the generic type given to the method with the deserialized json values
        public static T Read<T>(string path)
        {
            StreamReader reader = new StreamReader(path);
            string json = reader.ReadToEnd();
            reader.Close();
            return JsonNet.Deserialize<T>(json); // deserializes using json.
        }
    }
}
