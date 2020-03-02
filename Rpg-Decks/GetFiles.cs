using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickType;
using System.IO;
using Rpg_Decks.JsonProfiling;

namespace Rpg_Decks
{
    static class GetFiles
    {
        public static string path = @"JSON\Profiles\";
        public static RootProfile GetjsonData(string tempPath)
        {
            //Future Note: Add StringPath accessability so that class can be called with stringpath                      
            
            StreamReader stream;
            
                stream = new StreamReader(tempPath);
                string result = stream.ReadToEnd();

                JProfile profile = JProfile.FromJson(result);
                RootProfile RP = new RootProfile();
                RP = profile.ProType;
                return RP; //returns it with the properties            
            
        }
        //Look for the darn file    ??? Validation!
        public static bool FileFind(string path)
        {
            if (File.Exists(path)) { return true; }
            else {return false; }
            
        }

        //gets all paths
        public static List<string> GetPath()
        {
            //list of file path strings from directory
            List<string> FileEntries = new List<string>();
            foreach(string filePath in Directory.EnumerateFiles(path))
            {
                FileEntries.Add(filePath);
            }

            return FileEntries;     
        }
        
        public static void SaveData()
        {

        }

    }
}
