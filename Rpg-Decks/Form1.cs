using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;
using Rpg_Decks.UserControls;
using Rpg_Decks.JsonProfiling;

namespace Rpg_Decks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProfilesList = new List<RootProfile>();

            //empty profile for clearing
            
        }

           
        //List of RootProfile Instances
        public List<RootProfile> ProfilesList { get; set; }
                   
        
        //On Load
        //  - gets all paths
        //  - call on Profile Spawner
        private void Form1_Load(object sender, EventArgs e)
        {
            //adding empty
            emptyProfile = GetFiles.GetjsonData(@"JSON\Defualts\DefPro.json");

            //calls GetPaths and make class instance
            List<string> FileStr = GetFiles.GetPath();
            foreach(string str in FileStr)
            {
                RootProfile profile = new RootProfile();
                profile = GetFiles.GetjsonData(str);
                ProfilesList.Add(profile);
            }

            //calls Spawner
            ProSpawn();

            
        }

        //load all Profiles from List
        //onto FlowPanel as UserControls
        private void ProSpawn()
        {
            int index = 0;
            foreach(RootProfile pro in ProfilesList)
            {
                //contructor
                LoadControl lc = new LoadControl(pro.ProfileName, index);
                lc.ParentForm = this;
                FlowLayout.Controls.Add(lc);
                index++;
            }
            NewControl nc = new NewControl();
            FlowLayout.Controls.Add(nc);
        }
        public void pubTabSwitch()
        {
            TabConMain.SelectedTab = tabPage2;
        }


        private void SaveTool_Click(object sender, EventArgs e)
        {
            //check if user is saving in selectedTab
            if (TabConMain.SelectedTab == tabPage2) 
            {
                GetFiles.SaveData(ProControlU.GetProfileData());
            }
        }
        public RootProfile emptyProfile = new RootProfile();
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the flow of profiles so it doesnt keep stacking and makes my life easier with programming 
            //also by stacking i mean for everytime i add a new profile to the list
            if(TabConMain.SelectedTab == tabPage1)
            {
                FlowLayout.Controls.Clear();
                
                ProSpawn();
            }
            else if(TabConMain.SelectedTab == tabPage2)
            {
                
            }
        }
        public void LoadFunction(int id)
        {
            if (TabConMain.SelectedTab != tabPage2) { Console.WriteLine("HET"); }
            else
            {
                //re-Initializing
                ProControlU.DataLoader(emptyProfile);
                //get values from list
                RootProfile TempData = ProfilesList[id];
                //add all values
                ProControlU.DataLoader(TempData);

                ProControlU.Refresh();
            }
        }
        

    }
    
}
