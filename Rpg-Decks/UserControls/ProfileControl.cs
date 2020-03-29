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
using Rpg_Decks.Card_System;

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
        }
        
        //temporal id variable profile location
        public int temporalId;

        public void DataLoader(RootProfile TemporalData)
        {
            //id for later
            temporalId = TemporalData.TempId;

            ProName.Text = TemporalData.ProfileName;
            hitdiceTextBox.Text = TemporalData.HitDie;

            classComboBox.Text = TemporalData.RpgClass;
            levelUpDown.Value = TemporalData.Level;
            XPText.Text = TemporalData.XpValue.ToString("f");
            hpTextBox.Text = TemporalData.HpValue.ToString();
            HpMaxValueBox.Value = TemporalData.HpMax;
            proficiencyTextBox.Text = TemporalData.Proficiency.ToString();
            acTextBox.Text = TemporalData.Ac.ToString();
       
            //clears spells
            SpellFlow.Controls.Clear();
            if (TemporalData.SpellCardsV != null)
            {
                foreach (Spell card in TemporalData.SpellCardsV)
                {
                    SpellCard spellCard = new SpellCard(card);
                    SpellFlow.Controls.Add(spellCard);
                }
            }
            else { SpellFlow.Controls.Clear(); }

            //Items
            InventoryFlow.Controls.Clear();
            if(TemporalData.ItemCardsV != null)
            {
                foreach(Item card in TemporalData.ItemCardsV)
                {
                    ItemCard itemCard = new ItemCard(card);
                    InventoryFlow.Controls.Add(itemCard);
                }
            }
            else { InventoryFlow.Controls.Clear(); }

            HpBarCalculation();
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
            TemporalProfile.RpgClass = classComboBox.Text;
            //TemporalProfile.RpgClass = classComboBox.SelectedItem.ToString();
            TemporalProfile.Level = (int)levelUpDown.Value;
            TemporalProfile.XpValue = XPText.Text.ToFloat();
            TemporalProfile.HpValue = (int)hpTextBox.Value;
            TemporalProfile.HpMax = (int)HpMaxValueBox.Value;
            TemporalProfile.Proficiency = (int)proficiencyTextBox.Text.ToFloat();
            TemporalProfile.Ac = int.Parse(acTextBox.Text);            

            //retrieves spellscards
            TemporalProfile.SpellCardsV = new List<Spell>();
            foreach (SpellCard card in SpellFlow.Controls)
            {
                TemporalProfile.SpellCardsV.Add(card.SpellVariable);
            }
            //retreives Itemcards
            TemporalProfile.ItemCardsV = new List<Item>();
            foreach(ItemCard card in InventoryFlow.Controls)
            {
                TemporalProfile.ItemCardsV.Add(card.ItemVar);
            }

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
           
        }

        private void SkillListBox_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
        public Dictionary<int, int> ExpDict;
        private void ProfileControl_Load(object sender, EventArgs e)
        {
            //experience to level
            ExpDict = new Dictionary<int, int>();
            {
                
                ExpDict.Add(0,1);
                ExpDict.Add(300,2);
                ExpDict.Add(900,3);
                ExpDict.Add(2700,4);
                ExpDict.Add(6500,5);
                ExpDict.Add(1400,6);
                ExpDict.Add(23000,7);
                ExpDict.Add(34000,8);
                ExpDict.Add(48000,9);
                ExpDict.Add(64000,10);
                ExpDict.Add(85000,11);
                ExpDict.Add(100000,12);
                ExpDict.Add(120000,13);
                ExpDict.Add(140000,14);
                ExpDict.Add(165000,15);
                ExpDict.Add(195000,16);
                ExpDict.Add(225000,17);
                ExpDict.Add(265000,18);
                ExpDict.Add(305000,19);
                ExpDict.Add(355000,20);
               
            };
        }

        private void XPText_TextChanged(object sender, EventArgs e)
        {
            int xp = (int)XPText.Value;

            int level = 0;
            int max = 0;
            foreach(int key in ExpDict.Keys)
            {
                if(xp >= key) { level = ExpDict[key]; }
                    
                else { max = key; break; }
            }
            if(xp >= 355000) { max = 355000; xp = 355000; level = 20; }
            levelUpDown.Value = level;
            xpBar.Maximum = max;
            xpBar.Value = xp;
            xpBar.Minimum = 0;
            xpDisplayLabel.Text = $"{xp}/{max}";
            
        }
        
        
        //opens inventory form as spell form
        private void SpellBtn_Click(object sender, EventArgs e)
        {
            //bool IsOpen = false;
            //foreach(Form f in Application.OpenForms)
            //{
            //    if(f.Name == "SpellsForm")
            //    {
            //        IsOpen = true;
            //        break;
            //    }
            //}

            //if (IsOpen == false)
            //{
            //    SpellsForm SpellForm = new SpellsForm();
            //    SpellForm.Name = "SpellsForm";

            //    //SpellForm.FormSelect(SpellForm.option.Spells);

            //    SpellForm.Show();

            GetCard.spellsForm.Visible = true;
        
        }

        //deletes profile
        private void DPbtn_Click(object sender, EventArgs e)
        {
            //are you sure box
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this profile!", "Delete Profile", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                //deletion sequence
                int deletionNum = temporalId;
                string deletionStr = GetFiles.IdPath[deletionNum];
                if(GetFiles.FileFind(deletionStr))
                {
                    deletionStr.DeletePath();
                }
                MessageBox.Show($"Deleted file in path {deletionStr}");
                GetCard.Form1.TabConMain.SelectedIndex = 0;
                GetCard.Form1.FormLoadingMethod();
                GetCard.Form1.ProControlU.DPbtn.Enabled = false;
            }
            else if(dialog == DialogResult.No)
            {
                
            }
            
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
            GetCard.ItemsForm.Visible = !GetCard.ItemsForm.Visible;
        }
    }
    
}
