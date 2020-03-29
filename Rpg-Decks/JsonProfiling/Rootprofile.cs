using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Decks.Card_System;

namespace Rpg_Decks.JsonProfiling
{
    public partial class RootProfile 
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
       
        public List<Spell> SpellCardsV { get; set; }
        public List<Item> ItemCardsV { get; set; }
    }
}
