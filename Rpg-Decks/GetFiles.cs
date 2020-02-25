using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickType;
using System.IO;

namespace Rpg_Decks
{
    static class GetFiles
    {
        public static Profile GetjsonData()
        {
            string path, fileName, subFolder;
            subFolder = "JsonFiles";
            fileName = "json1.json";
           // path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, subFolder, fileName);
           path = "json1.json";
            StreamReader stream = new StreamReader(path);
            string result = stream.ReadToEnd();

            var profile = Profile.FromJson(result);
            
            return profile;
        }
    }
}
