using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recreational_Centre
{
    class Utility
    {
        public static string WriteToCSV(string data, string _filePath)
        {
            if (!File.Exists(_filePath))
            {
#pragma warning disable CS0642 // Possible mistaken empty statement
                using (File.Create(_filePath)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }
            return "success";
        }
        public static string[] ReadFromFile(string _filePath)
        {
            if (File.Exists(_filePath))
            {
                string[] data = File.ReadAllLines(_filePath);
                return data;
            }
            return null;
        }
        public static string ReadFromTXT(string _filePath)
        {
            if (File.Exists(_filePath))
            {
                string data = File.ReadAllText(_filePath);
                return data;

            }
            return null;
        }
    }
}
