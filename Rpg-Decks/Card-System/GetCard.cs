using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Rpg_Decks.Card_System
{
    public static class GetCard
    {
        public static List<Spell> SpellList { get; set; }
        public static List<Item> ItemList { get; set; }
        public static SpellsForm spellsForm { get; set; }
        public static ItemsForm ItemsForm { get; set; }
        public static Form1 Form1 { get; set; }
        public static List<Spell> HomeBrewList { get; set; }

        public static void AllSpells()
        {
            foreach (string filePath in Directory.GetFiles(@"JSON\Cards\SpellsHB\", "*.json"))
            {
                try
                {
                    StreamReader reader = new StreamReader(filePath);

                    Spell spell = Spell.FromJson(reader.ReadToEnd());
                    SpellList.Add(spell);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
