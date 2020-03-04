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
using Rpg_Decks;

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

            if (ScoreRadio.Checked == true) { AblityScoresGroupBox.Visible = true; SkillsBox.Visible = false; TraitsBox.Visible = false; HpMaxValueBox.Visible = false; }
            else if (SkillRadio.Checked == true) { AblityScoresGroupBox.Visible = false; SkillsBox.Visible = true; TraitsBox.Visible = false; HpMaxValueBox.Visible = false; }
            else if (TraitRadio.Checked == true) { AblityScoresGroupBox.Visible = false; SkillsBox.Visible = false; TraitsBox.Visible = true; HpMaxValueBox.Visible = false; }
            else if (MainRadio.Checked == true) { AblityScoresGroupBox.Visible = false; SkillsBox.Visible = false; TraitsBox.Visible = false; HpMaxValueBox.Visible = true; }
            if(MainRadio.Checked == true) { hpMaxLabel.Visible = true; }
            else { hpMaxLabel.Visible = false; }
        }
        public int temporalId;
        public void DataLoader(RootProfile TemporalData)
        {
            //id for later
            temporalId = TemporalData.TempId;

            ProName.Text = TemporalData.ProfileName;
            hitdiceTextBox.Text = TemporalData.HitDie;

            classComboBox.SelectedItem = TemporalData.RpgClass;
            levelUpDown.Value = TemporalData.Level;
            XPText.Text = TemporalData.XpValue.ToString("f");
            hpTextBox.Text = TemporalData.HpValue.ToString();
            proficiencyTextBox.Text = TemporalData.Proficiency.ToString();
            acTextBox.Text = TemporalData.Ac.ToString();

            skillListBox.Items.Clear();
            if (TemporalData.Skills != null)
            {
                foreach (string str in TemporalData.Skills)
                {
                    skillListBox.Items.Add(str);
                }
            }
            else { skillListBox.Items.Clear(); }

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

            GetFiles.SaveData(GetProfileData());

            TabControl tab = (ParentForm.Controls["TabConMain"] as TabControl);
            tab.SelectedIndex = 0;
        }//Application.OpenForms["Form1"].Controls["ProControlU"] as ProfileControl
        
        public RootProfile GetProfileData()
        {//added for saving

            RootProfile TemporalProfile = new RootProfile();

            TemporalProfile.TempId = temporalId;

            TemporalProfile.ProfileName = ProName.Text;
            TemporalProfile.HitDie = hitdiceTextBox.Text;

            TemporalProfile.RpgClass = classComboBox.SelectedItem.ToString();
            TemporalProfile.Level = (int)levelUpDown.Value;
            TemporalProfile.XpValue = XPText.Text.ToFloat();
            TemporalProfile.HpValue = (int)hpTextBox.Value;
            TemporalProfile.Proficiency = (int)proficiencyTextBox.Text.ToFloat();
            TemporalProfile.Ac = int.Parse(acTextBox.Text);

            TemporalProfile.Skills = new List<string>();
            foreach(string str in skillListBox.Items)
            {
                TemporalProfile.Skills.Add(str);
            }

            TemporalProfile.Strength = new Ability();
            TemporalProfile.Dexterety = new Ability();
            TemporalProfile.Constitution = new Ability();
            TemporalProfile.Intelligince = new Ability();
            TemporalProfile.Wisdom = new Ability();
            TemporalProfile.Charisma = new Ability();



            TemporalProfile.Strength.Score = (int)StrScore.Value;
            TemporalProfile.Strength.Bonus = (int)StrBonus.Value;
            TemporalProfile.Strength.Saving = (int)StrSaving.Value;

            TemporalProfile.Dexterety.Score = (int)DexScore.Value;
            TemporalProfile.Dexterety.Bonus = (int)DexBonus.Value;
            TemporalProfile.Dexterety.Saving = (int)DecSaving.Value;

            TemporalProfile.Constitution.Score = (int)ConScore.Value;
            TemporalProfile.Constitution.Bonus = (int)ConBonus.Value;
            TemporalProfile.Constitution.Saving = (int)ConSaving.Value;

            TemporalProfile.Intelligince.Score = (int)IntScore.Value;
            TemporalProfile.Intelligince.Bonus = (int)IntBonus.Value;
            TemporalProfile.Intelligince.Saving = (int)IntSaving.Value;

            TemporalProfile.Wisdom.Score = (int)WisScore.Value;
            TemporalProfile.Wisdom.Bonus = (int)WisBonus.Value;
            TemporalProfile.Wisdom.Saving = (int)WisSaving.Value;

            TemporalProfile.Charisma.Score = (int)ChaScore.Value;
            TemporalProfile.Charisma.Bonus = (int)ChaBonus.Value;
            TemporalProfile.Charisma.Saving = (int)ChaSaving.Value;

            return TemporalProfile;
        }

        private void SaveUpdateBtn_Click(object sender, EventArgs e)
        {
            GetFiles.SaveUpdateData(GetProfileData());
            TabControl tab = (ParentForm.Controls["TabConMain"] as TabControl);
            tab.SelectedIndex = 0;
        }

        private void SaveBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(this.SaveBtn, "will overwrite or make a new file based on name");
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            HpBarCalculation();
        }
        private void HpBarCalculation()
        {
            int MaxHP = (int)HpMaxValueBox.Value;
            int HP = (int)hpTextBox.Value;
            if (MaxHP >= HP) { hpBar.Maximum = MaxHP; hpBar.Value = HP; hpBar.Enabled = true; }
            else { hpBar.Enabled = false; }
        }

        private void HpMaxValueBox_ValueChanged(object sender, EventArgs e)
        {
            HpBarCalculation();
        }

        private void SkillAdd_Click(object sender, EventArgs e)
        {
            string skill = comboBox1.Text;
            int mod = (int)skillModUpDown.Value;
            string combo = $"{mod} {skill}";
            skillListBox.Items.Add(combo);
        }
    }
}
