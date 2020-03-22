using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Decks.UserControls;
using Rpg_Decks.Card_System;

namespace Rpg_Decks
{
    public partial class SpellsForm : Form
    {
        public SpellsForm()
        {
            InitializeComponent();
            SpellLoad();
        }   

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //CardFlow.Controls.Clear();
            //CardFlow.Dispose();
            GetCard.spellsForm.Visible = false;
        }

        List<SpellCard> listCards = new List<SpellCard>();

        private void SpellLoad()
        {

            foreach (Spell spell in GetCard.SpellList)
            {
                SpellCard card = new SpellCard(spell);
               
                listCards.Add(card);

               // CardFlow.Controls.Add(card);
              //  ControlExtension.Draggable(card, true);
            }
            Refresh();
        }


        //Copied Code from Online
        //To make form movable
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
        //===================================================================================

        private void SpellsForm_Shown(object sender, EventArgs e)
        {
            Refresh();
        }

        public List<SpellCard> Cantrip, Level1, Level2, Level3, Level4, Level5,
            Level6, Level7, Level8, Level9, Level10, Level11, Level12, Level13,
            Level14, Level15, Level16, Level17, Level18, Level19, Level20;

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            NewCardForm form = new NewCardForm();
            form.ShowDialog();
        }

        private void SpellsForm_Load(object sender, EventArgs e)
        {
            //list data foreach level
            Cantrip = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "Cantrip"; });
            Level1 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "1st-Level"; });
            Level2 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "2nd-Level"; });
            Level3 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "3rd-Level"; });
            Level4 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "4th-Level"; });
            Level5 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "5th-Level"; });
            Level6 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "6th-Level"; });
            Level7 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "7th-Level"; });
            Level8 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "8th-Level"; });
            Level9 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "9th-Level"; });
            Level10 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "10th-Level"; });
            Level11 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "11th-Level"; });
            Level12 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "12th-Level"; });
            Level13 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "13th-Level"; });
            Level14 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "14th-Level"; });
            Level15 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "15th-Level"; });
            Level16 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "16th-Level"; });
            Level17 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "17th-Level"; });
            Level18 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "18th-Level"; });
            Level19 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "19th-Level"; });
            Level20 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "20th-Level"; });
            
            //clears original list for resource managment
            listCards.Clear();
            //loads all controls
            foreach (SpellCard c in Cantrip)
            {  
                CardFlow.Controls.Add(c);
            }
        }

        private void NameFilter_TextChanged(object sender, EventArgs e)
        {
            //foreach (SpellCard spellCard in CardFlow.Controls)
            //{
            //    if (spellCard.SpellLevel == NameFilter.Text)
            //    {
            //        spellCard.Visible = true;
            //    }
            //    else { spellCard.Visible = false; }
            //    CardFlow.Refresh();
            //}
        }
        
        private void LevelFilter_DropDownClosed(object sender, EventArgs e)
        {
            CardFlow.Controls.Clear();

            switch (LevelFilter.SelectedItem.ToString())
            {
                case "Cantrip":
                    EachLevel(Cantrip);
                    break;
                case "1st-Level":
                    EachLevel(Level1);
                    break;
                case "2nd-Level":
                    EachLevel(Level2);
                    break;
                case "3rd-Level":
                    EachLevel(Level3);
                    break;
                case "4th-Level":
                    EachLevel(Level4);
                    break;
                case "5th-Level":
                    EachLevel(Level5);
                    break;
                case "6th-Level":
                    EachLevel(Level6);
                    break;
                case "7th-Level":
                    EachLevel(Level7);
                    break;
                case "8th-Level":
                    EachLevel(Level8);
                    break;
                case "9th-Level":
                    EachLevel(Level9);
                    break;
                case "10th-Level":
                    EachLevel(Level10);
                    break;
                case "11th-Level":
                    EachLevel(Level11);
                    break;
                case "12th-Level":
                    EachLevel(Level12);
                    break;
                case "13th-Level":
                    EachLevel(Level13);
                    break;
                case "14th-Level":
                    EachLevel(Level14);
                    break;
                case "15th-Level":
                    EachLevel(Level15);
                    break;
                case "16th-Level":
                    EachLevel(Level16);
                    break;
                case "17th-Level":
                    EachLevel(Level17);
                    break;
                case "18th-Level":
                    EachLevel(Level18);
                    break;
                case "19th-Level":
                    EachLevel(Level19);
                    break;
                case "20th-Level":
                    EachLevel(Level20);
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
            CardFlow.Refresh();
        }

        private void LevelFilter_TextUpdate(object sender, EventArgs e)
        {
            
        }
        private void EachLevel(List<SpellCard> level)
        {
            foreach(SpellCard card in level)
            {
                CardFlow.Controls.Add(card);
            }
            CardFlow.Refresh();
            
        }
    }
}
