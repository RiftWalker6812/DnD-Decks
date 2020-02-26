using System;
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
        public static RootProfile GetjsonData()
        {
            //Future Note: Add StringPath accessability so that class can be called with stringpath                      
            string path = "Data/JsonTest.json";


            StreamReader stream = new StreamReader(path);
            string result = stream.ReadToEnd();

            JProfile profile = JProfile.FromJson(result);
            RootProfile RP = new RootProfile();
            RP = profile.ProType;
            return RP; //returns it with the properties            
        }
        public static string GetPath()
        {
            return "test";
        }
    }
}
