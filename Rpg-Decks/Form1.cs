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


namespace Rpg_Decks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Profile instance structer
        public struct Profile
        {
            public string ProfileName { get; set; }
            public string HitDie { get; set; }
            public string RpgClass { get; set; }
            public int Level { get; set; }
            public float XpValue { get; set; }
            public int HpValue { get; set; }
            public int Proficiency { get; set; }
            public int AC { get; set; }
            public List<string> Skills;
        }

        //List of Profile Instances
        List<Profile> profilesList = new List<Profile>();
        //On Load
        //  - call on Profile Spawner
        private void Form1_Load(object sender, EventArgs e)
        {
            //testing Instance
            Profile profile = new Profile();
            profile.ProfileName = "Rift";

            profilesList.Add(profile);

            //testing method          
            var test = GetFiles.GetjsonData();

            foreach(var pro in test.ProfileList)
            {
                Profile profile1 = new Profile
                {
                    ProfileName = pro.ProfileName,
                    HitDie = pro.HitDie,
                    RpgClass = pro.RpgClass,
                    Level = pro.Level,
                    XpValue = pro.XpValue,
                    HpValue = pro.HpValue,
                    Proficiency = pro.Proficiency,
                    AC = pro.Ac,
                    Skills = pro.Skills

                };
                profilesList.Add(profile1);
            }


            //calls Spawner
            ProSpawn();

            
        }

        //load all Profiles from List
        //onto FlowPanel as UserControls
        private void ProSpawn()
        {
            int index = 0;
            foreach(Profile pro in profilesList)
            {
                LoadControl lc = new LoadControl(pro.ProfileName, index);
                FlowLayout.Controls.Add(lc);
                index++;
            }
            NewControl nc = new NewControl();
            FlowLayout.Controls.Add(nc);
        }

        private void SaveTool_Click(object sender, EventArgs e)
        {

        }
        
    }
    
}
