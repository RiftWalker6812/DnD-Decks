using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Decks.Card_System
{
    public partial class SpellCard : UserControl
    {
        public SpellCard()
        {
            InitializeComponent();
        }
        public SpellCard(Spell spell)
        {
            InitializeComponent();

            //CardControl Name
            Name = spell.CardName;

            NameBox.Text = spell.CardName;
            LevelConjurBox.Text = spell.Level + " " + spell.School;
            CastingBox.Text = spell.CastingTime;
            RangeBox.Text = spell.Range;
            ComponentsBox.Text = spell.Components;

            string desc = string.Format("{0}    {1}", spell.Materials, spell.Description);

            DescriptionBox.Text = desc;
            
            HigherDescBox.Text = spell.AtHigherLevels;

            ClassBox.Text = spell.Catagory;

            ConcenLabel.Visible = spell.Concentration;
            ritualLabel.Visible = spell.Ritual;

        }
    }
}
