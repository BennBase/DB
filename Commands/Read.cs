using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Commands
{
    public static class Read
    {
        public static Dictionary<string, string> ReadJson(string JsonFilePath)
        {
            try
            {
                
                string jsonString = File.ReadAllText(JsonFilePath);

                // Deserialize the JSON string into a Dictionary
                Dictionary<string, string> yourObject = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);

                return yourObject;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, deserialization issues)
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
