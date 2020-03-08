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
            //pre-loads 400 pieces of data
            GetCard.SpellList = new List<Spell>();
            GetCard.AllSpells();

        }
    }
}
