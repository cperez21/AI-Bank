using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace AI_Bank
{
    internal static class DataManager
    {
      //private static JsonSerializerOptions options = new JsonSerializerOptions();
        private static string pathRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private static string pathUser = pathRoot + "\\User Data\\";



      public static void PrintDirectories()//used for debugging
        {
            Console.WriteLine(pathRoot);
            Console.WriteLine(pathUser);
          
        }

        public static bool DoesUserExist(User u)//Check if user exists in the system
        {
            string userPath = $"{pathRoot}{u.userName}.json"; //User JSON is named after username.json
            return File.Exists(userPath);
        }

        public static void SaveUserData(User u) //Save user as JSON file in user folder path.
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            string userJson = JsonSerializer.Serialize(u, options);
            string pathUserFile = pathUser + u.userName + ".json"; 
            File.WriteAllText(pathUserFile, userJson);
        }

    }//end class





}//end namespace
