using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests.Payloads
{
    public static class Helper
    {

        public static void SaveJsonFile(string fileName,  string jsn)
        {
            var fullPath = $"Payloads/{fileName}.json";

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(fullPath)
                ? fullPath
                : Path.GetRelativePath(Directory.GetCurrentDirectory(), fullPath);

            //// Write that JSON to txt file,  
            //var read = System.IO.File.ReadAllText(path + "output.json");
            System.IO.File.WriteAllText(path, jsn);
        }
    }
}
