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
        //specal varialbes for easy spellcard usage
        public Spell SpellVariable { get; set; }
        public string SpellLevel { get; set; }

        //Control formatting and setup for the card
        public SpellCard(Spell spell)
        {
            InitializeComponent();

            SpellVariable = spell;

            //CardControl Name
            Name = spell.CardName;

            NameBox.Text = spell.CardName;
            LevelConjurBox.Text = spell.Level + " " + spell.School;

            SpellLevel = spell.Level;

            CastingBox.Text = spell.CastingTime;
            RangeBox.Text = spell.Range;
            ComponentsBox.Text = spell.Components;

            string desc = string.Format("({0})  {1}", "Materials: " + spell.Materials, spell.Description);
            
            DescriptionBox.Text = desc;
            HigherDescBox.Text = spell.AtHigherLevels;
            if (string.IsNullOrEmpty(spell.AtHigherLevels))
            {
                DescriptionBox.Width = 191;
                DescriptionBox.Height = 153;
            }
            ClassBox.Text = spell.Catagory;

            DurationBox.Text = spell.Duration;
            ConcenLabel.Visible = spell.Concentration;
            ritualLabel.Visible = spell.Ritual;
        }

        private void SpellCard_DoubleClick(object sender, EventArgs e)
        {
            //adds
            if (GetCard.Form1.ProControlU.SpellFlow.Controls.Contains(this) != true)
            {
                GetCard.Form1.ProControlU.SpellFlow.Controls.Add(this);
            }
            //removes
            else if(GetCard.Form1.ProControlU.SpellFlow.Controls.Contains(this) == true)
            {
                GetCard.Form1.ProControlU.SpellFlow.Controls.Remove(this);
            }
        }
    }
}
