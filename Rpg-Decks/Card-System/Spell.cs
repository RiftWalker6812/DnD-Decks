using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Rpg_Decks.Card_System
{
    
    public partial class Spell
    {
        [JsonProperty("CardName")]
        public string CardName { get; set; }

        [JsonProperty("Level")]
        public string Level { get; set; }

        [JsonProperty("School")]
        public string School { get; set; }

        [JsonProperty("CastingTime")]
        public string CastingTime { get; set; }

        [JsonProperty("Range")]
        public string Range { get; set; }

        [JsonProperty("Components")]
        public string Components { get; set; }

        [JsonProperty("Materials")]
        public string Materials { get; set; }
        
        [JsonProperty("Duration")]
        public string Duration { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("AtHigherLevels")]
        public string AtHigherLevels { get; set; }

        [JsonProperty("Catagory")]
        public string Catagory { get; set; }

        [JsonProperty("Concentration")]
        public bool Concentration { get; set; }

        [JsonProperty("Ritual")]
        public bool Ritual { get; set; }
    }
    public partial class Spell
    {
        public static Spell FromJson(string json) => JsonConvert.DeserializeObject<Spell>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Spell self) => JsonConvert.SerializeObject(self, Formatting.Indented, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
