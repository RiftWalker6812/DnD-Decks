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
using System.Threading;
using QuickType;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing.Text;

namespace Rpg_Decks
{
    public partial class PreLoader : Form
    {
        public PreLoader()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"JSON\Defualts\Irken-Like.ttf");
            DataLabel.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
        }

        private void PreLoading()
        {
            //pre-loads 400 pieces of data SRD
            GetCard.SpellList = new List<Spell>();
            
            //string[] Files = Directory.GetFiles(@"JSON\Cards\Spells\", "*.json");

            StreamReader reader1 = new StreamReader(@"JSON\Defualts\spellsSRD.json");

            var SpellsListed = SpellListed.FromJson(reader1.ReadToEnd());

            List<string> jList = new List<string>();
            foreach(Json j in SpellsListed.Json)
            {
                if (j != null)
                {
                    Json JO = j;
                    jList.Add(JO.ToJson2());
                }
            }
            int count = 0;
            int countMax = jList.Count;
            PreLoadBar.Maximum = countMax;
            foreach (string str in jList)
            {
                Spell spell = Spell.FromJson(str);
                GetCard.SpellList.Add(spell);

                count++;
                PreLoadBar.Value = count;
                string PreString = (((float)PreLoadBar.Value / PreLoadBar.Maximum) * 100).ToString("f2");
                PreLoadBar.Text = PreString + "%";
                DataLabel.Text = str;

                Thread.Sleep(10);
                Refresh();
            }

            GetCard.AllSpells(); //homebrew collection
            GetCard.spellsForm = new SpellsForm();
            GetCard.Form1 = new Form1();
            GetCard.Form1.Show();
            this.Visible = false;
        }
 

        private void PreLoader_Shown(object sender, EventArgs e)
        {
            PreLoading();
                     
        }
    }
}

