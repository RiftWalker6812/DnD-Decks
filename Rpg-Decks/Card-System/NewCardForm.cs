using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Decks.Card_System;
using System.IO;

namespace Rpg_Decks.Card_System
{
    public partial class NewCardForm : Form
    {
        public NewCardForm()
        {
            InitializeComponent();
            DisplaySpell = new Spell();
        }
        Spell DisplaySpell;

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validator

            //error fix it
            GetCard.SpellList.Add(DisplaySpell);
            StreamWriter streamWriter = new StreamWriter($@"JSON\Cards\SpellsHB\{DisplaySpell.CardName}.json");
            string SpellString = DisplaySpell.ToJson();
            streamWriter.Write(SpellString);
            streamWriter.Close();
            SpellCard card = new SpellCard(DisplaySpell);
            switch (DisplaySpell.Level)
            {
                case "Cantrip":
                    GetCard.spellsForm.Cantrip.Add(card);
                    break;
                case "1st-Level":
                    GetCard.spellsForm.Level1.Add(card);
                    break;
                case "2nd-Level":
                    GetCard.spellsForm.Level2.Add(card);
                    break;
                case "3rd-Level":
                    GetCard.spellsForm.Level3.Add(card);
                    break;
                case "4th-Level":
                    GetCard.spellsForm.Level4.Add(card);
                    break;
                case "5th-Level":
                    GetCard.spellsForm.Level5.Add(card);
                    break;
                case "6th-Level":
                    GetCard.spellsForm.Level6.Add(card);
                    break;
                case "7th-Level":
                    GetCard.spellsForm.Level7.Add(card);
                    break;
                case "8th-Level":
                    GetCard.spellsForm.Level8.Add(card);
                    break;
                case "9th-Level":
                    GetCard.spellsForm.Level9.Add(card);
                    break;
                case "10th-Level":
                    GetCard.spellsForm.Level10.Add(card);
                    break;
                case "11th-Level":
                    GetCard.spellsForm.Level11.Add(card);
                    break;
                case "12th-Level":
                    GetCard.spellsForm.Level12.Add(card);
                    break;
                case "13th-Level":
                    GetCard.spellsForm.Level13.Add(card);
                    break;
                case "14th-Level":
                    GetCard.spellsForm.Level14.Add(card);
                    break;
                case "15th-Level":
                    GetCard.spellsForm.Level15.Add(card);
                    break;
                case "16th-Level":
                    GetCard.spellsForm.Level16.Add(card);
                    break;
                case "17th-Level":
                    GetCard.spellsForm.Level17.Add(card);
                    break;
                case "18th-Level":
                    GetCard.spellsForm.Level18.Add(card);
                    break;
                case "19th-Level":
                    GetCard.spellsForm.Level19.Add(card);
                    break;
                case "20th-Level":
                    GetCard.spellsForm.Level20.Add(card);
                    break;
                //case "HomeBrew":
                //    EachLevel(HomeBrew);
                //    break;
                default:
                    Console.WriteLine("Heh HET!");
                    break;
                    //case null:
                    //    break;
            }
            Close();
        }

        private string LL;
        private void AddingEvent(object sender, EventArgs e)
        {
            DisplaySpell.CardName = AddName.Text;
            DisplaySpell.Level = AddLevel.Text.ToString();
            DisplaySpell.School = AddSchool.Text;
            DisplaySpell.Ritual = AddRitual.Checked;
            DisplaySpell.Concentration = AddConcentration.Checked;
            DisplaySpell.CastingTime = AddCasting.Text;
            DisplaySpell.Range = AddRange.Text;
            DisplaySpell.Components = AddComponents.Text;
            DisplaySpell.Duration = AddDuration.Text;
            DisplaySpell.Description = AddDescript.Text;
            DisplaySpell.Materials = AddMaterials.Text;
            DisplaySpell.AtHigherLevels = AddHigher.Text;
            DisplaySpell.Catagory = AddClass.Text;
            TempCard(DisplaySpell);
            LL = AddLevel.Text.ToString();
        }

        public void TempCard(Spell spell)
        {
            //CardControl Name
            Name = spell.CardName;

            NameBox.Text = spell.CardName;
            LevelConjurBox.Text = spell.Level + " " + spell.School;

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
            else
            {
                DescriptionBox.Width = 191;
                DescriptionBox.Height = 88;
            }
            ClassBox.Text = spell.Catagory;

            DurationBox.Text = spell.Duration;
            ConcenLabel.Visible = spell.Concentration;
            ritualLabel.Visible = spell.Ritual;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void SpellsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
