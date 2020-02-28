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
            ProName.Text = TemporalData.ProfileName;
            hitdiceTextBox.Text = TemporalData.HitDie;

            classComboBox.SelectedItem = TemporalData.RpgClass;
            levelUpDown.Value = TemporalData.Level;
            XPText.Text = TemporalData.XpValue.ToString("f");
            hpTextBox.Text = TemporalData.HpValue.ToString();
            proficiencyTextBox.Text = TemporalData.Proficiency.ToString();
            acTextBox.Text = TemporalData.Ac.ToString();

            foreach(string str in TemporalData.Skills)
            {
                skillListBox.Items.Add(str);
            }

            StrScore.Value = TemporalData.Strength.Score;
            StrBonus.Value = TemporalData.Strength.Bonus;
            StrSaving.Value = TemporalData.Strength.Saving;

            DexScore.Value = TemporalData.Dexterety.Score;
            DexBonus.Value = TemporalData.Dexterety.Bonus;
            DecSaving.Value = TemporalData.Dexterety.Saving;

            ConScore.Value = TemporalData.Constitution.Score;
            ConBonus.Value = TemporalData.Constitution.Bonus;
            ConSaving.Value = TemporalData.Constitution.Saving;

            IntScore.Value = TemporalData.Intelligince.Score;
            IntBonus.Value = TemporalData.Intelligince.Bonus;
            IntSaving.Value = TemporalData.Intelligince.Saving;

            WisScore.Value = TemporalData.Wisdom.Score;
            WisBonus.Value = TemporalData.Wisdom.Bonus;
            WisSaving.Value = TemporalData.Wisdom.Saving;

            ChaScore.Value = TemporalData.Charisma.Score;
            ChaBonus.Value = TemporalData.Charisma.Bonus;
            ChaSaving.Value = TemporalData.Charisma.Saving;          
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GetFiles.SaveData();
        }
    }
}
