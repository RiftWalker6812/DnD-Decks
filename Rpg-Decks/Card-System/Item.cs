using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rpg_Decks.Card_System
{
    public partial class Item
    {
        [JsonProperty("ItemName", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemName { get; set; }

        [JsonProperty("ItemType", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemType { get; set; }

        [JsonProperty("DamageDice", NullValueHandling = NullValueHandling.Ignore)]
        public string DamageDice { get; set; }

        [JsonProperty("DamageType", NullValueHandling = NullValueHandling.Ignore)]
        public string DamageType { get; set; }

        [JsonProperty("Bonus", NullValueHandling = NullValueHandling.Ignore)]
        public string Bonus { get; set; }

        [JsonProperty("Str", NullValueHandling = NullValueHandling.Ignore)]
        public string Str { get; set; }

        [JsonProperty("Stealth", NullValueHandling = NullValueHandling.Ignore)]
        public string Stealth { get; set; }

        [JsonProperty("AC", NullValueHandling = NullValueHandling.Ignore)]
        public string Ac { get; set; }

        [JsonProperty("ItemDescript", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemDescript { get; set; }
    }

    public partial class Item
    {
        public static Item FromJson(string json) => JsonConvert.DeserializeObject<Item>(json, Rpg_Decks.Card_System.ItemConverter.Settings);
    }

    public static class SerializeItem
    {
        public static string ToJson(this Item self) => JsonConvert.SerializeObject(self, Formatting.Indented, Rpg_Decks.Card_System.ItemConverter.Settings);
    }

    internal static class ItemConverter
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
