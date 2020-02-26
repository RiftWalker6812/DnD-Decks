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
        }

           
        //List of RootProfile Instances
        public List<RootProfile> ProfilesList { get; set; }
                   
        
        //On Load
        //  - call on Profile Spawner
        private void Form1_Load(object sender, EventArgs e)
        {

            //testing method          
            RootProfile proTest = new RootProfile(); 
            proTest = GetFiles.GetjsonData();
            ProfilesList.Add(proTest);
            
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
