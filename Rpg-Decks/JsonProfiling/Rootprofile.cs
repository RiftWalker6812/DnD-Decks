using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Decks.Card_System;

namespace Rpg_Decks.JsonProfiling
{
    public partial class RootProfile : ProfileInterface
    {
        public int TempId { get; set; }
        public string ProfileName { get; set; }
        public string HitDie { get; set; }
        public string RpgClass { get; set; }
        public int Level { get; set; }
        public float XpValue { get; set; }
        public int HpValue { get; set; }
        public int HpMax { get; set; }
        public int Proficiency { get; set; }
        public int Ac { get; set; }
        public List<string> Skills { get; set; }
        public Ability Strength { get; set; }
        public Ability Dexterety { get; set; }
        public Ability Constitution { get; set; }
        public Ability Intelligince { get; set; }
        public Ability Wisdom { get; set; }
        public Ability Charisma { get; set; }
        public List<Spell> SpellCardsV { get; set; }
    }

    public partial class Ability
    {
        public int Score { get; set; }
        public int Bonus { get; set; }
        public int Saving { get; set; }
    }

}
