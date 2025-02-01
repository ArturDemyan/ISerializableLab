using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISerializableLB
{
    public class SearchFile
    {
        private static string[] files;
        private static string _directoryPath;
        private static string? fils;

        public SearchFile() { } 
        public SearchFile(string directoryPath)
         {
            _directoryPath = directoryPath;
         }

        public string FindFile()
        {
            if (Directory.Exists(_directoryPath))
            {
                files = Directory.GetFiles(_directoryPath, "*.json");
                fils = files.FirstOrDefault(x => x.EndsWith("SuperHeroSquad.json", StringComparison.OrdinalIgnoreCase));
            }

            return fils;
        }

    }
}
