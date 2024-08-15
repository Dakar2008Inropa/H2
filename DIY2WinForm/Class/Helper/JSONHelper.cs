using Newtonsoft.Json;

namespace DIY2WinForm.Class.Helper
{
    public static class JSONHelper
    {
        public static void SerializeObject<T>(T objectToSerialize, string fileName)
        {
            string json = JsonConvert.SerializeObject(objectToSerialize, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }

        public static T DeserializeObject<T>(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}