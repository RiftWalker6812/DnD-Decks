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

namespace Rpg_Decks
{
    public partial class PreLoader : Form
    {
        public PreLoader()
        {
            InitializeComponent();
        }

        private void PreLoader_Load(object sender, EventArgs e)
        {
          

        }
        private void PreLoading()
        {
            //pre-loads 400 pieces of data
            GetCard.SpellList = new List<Spell>();

            string[] Files = Directory.GetFiles(@"JSON\Cards\Spells\", "*.json");
            int count = 0;
            int countMax = Files.Length;
            PreLoadBar.Maximum = countMax;
            foreach (string filePath in Files)
            {
                StreamReader reader = new StreamReader(filePath);
                Spell spell = Spell.FromJson(reader.ReadToEnd());
                reader.Close();
                GetCard.SpellList.Add(spell);

                count++;
                PreLoadBar.Value = count;
                string PreString = ((PreLoadBar.Value / PreLoadBar.Maximum) * 100).ToString();
                PreLoadBar.Text = PreString;
                DataLabel.Text = filePath;

                Thread.Sleep(10);
                Refresh();
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;

        }

        private void PreLoader_Shown(object sender, EventArgs e)
        {
            PreLoading();
        }
    }
}
