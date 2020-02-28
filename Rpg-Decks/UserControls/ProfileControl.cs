using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Decks.JsonProfiling;

namespace Rpg_Decks.UserControls
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private void TraitRadio_CheckedChanged(object sender, EventArgs e)
        {

            if (ScoreRadio.Checked == true) { AblityScoresGroupBox.Visible = true; SkillsBox.Visible = false; TraitsBox.Visible = false; }
            else if (SkillRadio.Checked == true) { AblityScoresGroupBox.Visible = false; SkillsBox.Visible = true; TraitsBox.Visible = false; }
            else if (TraitRadio.Checked == true) { AblityScoresGroupBox.Visible = false; SkillsBox.Visible = false; TraitsBox.Visible = true; }
            
        }
        
        public void DataLoader(RootProfile TemporalData)
        {
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GetFiles.SaveData();
        }
    }
}
