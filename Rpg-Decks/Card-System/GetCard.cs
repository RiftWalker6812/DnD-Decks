using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rpg_Decks.Card_System
{
    public static class GetCard
    {
        public static List<Spell> SpellList { get; set; }

        public static void AllSpells()
        {
            foreach(string filePath in Directory.GetFiles(@"JSON\Cards\Spells\", "*.json"))
            {
                StreamReader reader = new StreamReader(filePath);

                Spell spell = Spell.FromJson(reader.ReadToEnd());
                SpellList.Add(spell);
            }
        }
    }
}
