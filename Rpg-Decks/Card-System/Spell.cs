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
        [JsonProperty("Spell")]
        public SpellClass SpellClass { get; set; }
    }

    public partial class SpellClass
    {
        [JsonProperty("CardName")]
        public string CardName { get; set; }

        [JsonProperty("Level")]
        public int Level { get; set; }

        [JsonProperty("ConjureType")]
        public string ConjureType { get; set; }

        [JsonProperty("CastingTime")]
        public string CastingTime { get; set; }

        [JsonProperty("Range")]
        public string Range { get; set; }

        [JsonProperty("SpellComponents")]
        public string SpellComponents { get; set; }

        [JsonProperty("Duration")]
        public string Duration { get; set; }

        [JsonProperty("Description")]
        public FormattableString Description { get; set; }

        [JsonProperty("AtHigherLevels")]
        public FormattableString AtHigherLevels { get; set; }

        [JsonProperty("Catagory")]
        public string Catagory { get; set; }
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
