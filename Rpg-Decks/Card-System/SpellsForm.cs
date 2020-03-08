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
           
        }

        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //CardFlow.Dispose();
            this.Dispose(); //cleans it
        }

        private void SpellLoad()
        {

            foreach (Spell spell in GetCard.SpellList)
            {
                SpellCard card = new SpellCard(spell);
                CardFlow.Controls.Add(card);
            }
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

       
        void SpellsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }
    }
}
