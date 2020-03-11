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

        public List<SpellCard> Cantrip, Level1, Level2, Level3, Level4, Level5;
        private void SpellsForm_Load(object sender, EventArgs e)
        {
            //list data foreach level
            Cantrip = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "Cantrip"; });
            Level1 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "1st-Level"; });
            Level2 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "2nd-Level"; });
            Level3 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "3rd-Level"; });
            Level4 = listCards.FindAll(delegate (SpellCard s) { return s.SpellLevel == "4th-Level"; });
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
