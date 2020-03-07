using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Decks.Card_System
{
    public abstract class AbstactCard
    {

        //returns struct
        public abstract Type GetCard();

        //What type of card is it? A Spell or an Item!
        public virtual Type CardType { get; set; } 

        public virtual string CardName { get; set; }
        public virtual int CardLevel { get; set; }

        //spell card
        private struct SpellCard
        {
            public ConjureType ConjureType { get; set; }
        
            public CastingTime CTime { get; set; }
            public string Range { get; set; }
            public SpellComp Components { get; set; }
            public string Duration { get; set; }
        }
        
        //Item Card
        private struct ItemCard
        {
            public ItemType ItemType;
            public string DamageDice;
            public string DamageType;
            public int AtackBonus;
        }

        public virtual FormattableString Description { get; set; }
        public virtual FormattableString AtHigherLevels { get; set; }

        //catagorize Class Spell Type
        public virtual string Catagory { get; set; }
    }

    public enum CastingTime
    {
        One_action, bonus_action
    };
    public enum SpellComp
    {
        V, S, M
    };
    public enum ConjureType
    {
        Transmutaion, Conjuration, Divination
    };
    public enum ItemType
    {
        //colors for the enums (effieceincy)
        Weapon = 16711680, Armor = 32768, Item = 15794175
    };
}
