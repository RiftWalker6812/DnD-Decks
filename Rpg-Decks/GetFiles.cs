using System;
using System.Collections.Generic;
using QuickType;
using System.IO;
using Rpg_Decks.JsonProfiling;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;

namespace Rpg_Decks
{
    static class GetFiles
    {

        //List of RootProfile Instances
        public static List<RootProfile> ProfilesList { get; set; }

        public static string path = @"JSON\Profiles\";

        public static Dictionary<int, string> IdPath { get; set; }
        public static int IdCounter { get; set; }

        public static RootProfile GetjsonData(string tempPath)
        {
            //Future Note: Add StringPath accessability so that class can be called with stringpath                      
            IdCounter++;
            StreamReader stream;

            
            stream = new StreamReader(tempPath);
            string result = stream.ReadToEnd();
            stream.Close();//closes so savable
            JProfile profile = JProfile.FromJson(result);
            RootProfile RP = new RootProfile();
            RP = profile.ProType;
            RP.TempId = IdCounter;
            IdPath.Add(IdCounter, tempPath);
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
        
        //new save  //saving bools for later implementation of validation
        public static bool SaveData(RootProfile TemporalSave)
        {
            JProfile JPro = new JProfile();
            JPro.ProType = TemporalSave;
            //JPro.ToJson();
            
            string writePath = path + JPro.ProType.ProfileName + ".json";
            if (FileFind(writePath)) { writePath = path + JPro.ProType.ProfileName + "1" + ".json"; }

            StreamWriter writer = new StreamWriter(writePath);
            writer.Write(JPro.ToJson());
            writer.Close();
            Console.WriteLine("Saved Profile");
            MessageBox.Show("Profile has been saved");
            return true;
        } 
        
        public static bool SaveUpdateData(RootProfile TemporalSave)
        {
            JProfile JPro = new JProfile();
            JPro.ProType = TemporalSave;

            StreamWriter writer = new StreamWriter(IdPath[TemporalSave.TempId]);
            writer.Write(JPro.ToJson());
            writer.Close();
            Console.WriteLine("Updated Profile");
            MessageBox.Show("Profile has been Updated");
            return true;

        }

        public static List<int> Exp()
        {

            List<int> ExpList = new List<int>();

            StreamReader sr = new StreamReader(@"Json\Defualts\Leveling.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            
            csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
         
            

            

            return ExpList;
        }
        

        //made and extension method for effieciency
        public static float ToFloat(this string str)
        {
            if (float.TryParse(str, out float converted))
            {
                return converted;
            }
            else { return 0; }

        }

    }
}
